using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartB1t.DI
{
    /// <summary>
    /// A basic implementation of a DI Container.
    /// </summary>
    public class DIContainer : IContainer
    {
        /// <summary>
        /// Storage for registered types.
        /// </summary>
        private readonly Dictionary<Type, Func<object>> _registeredTypes = new Dictionary<Type, Func<object>>();

        /// <summary>
        /// Get an instance of a registered type.
        /// </summary>
        /// <param name="type">The type to obtain instance from.</param>
        /// <returns>An instance of the specified type.</returns>
        public object GetInstance(Type type)
        {
            // Check if the type is already registered so then return it directly from the dictionary
            return _registeredTypes.ContainsKey(type) ? _registeredTypes[type]() : null;
        }

        /// <summary>
        /// Creates a new instance of the specified type and injects constructor
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private object CreateInstance(Type type)
        {
            // Obtains the parameterized constructor of the type
            var constructor = type.GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length)
                .First();

            // Get the arguments of the defined constructor and obtains the instances for them
            var args = constructor.GetParameters().Select(p => GetInstance(p.ParameterType)).Where(a => a != null).ToArray();

            // Creates a new instance of the type using the arguments instances
            return Activator.CreateInstance(type, args);
        }

        /// <summary>
        /// Creates a new instance of the specified type and injects constructor
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private object CreateInstance(Type type, params object[] constructorParameters)
        {
            // Obtains the parameterized constructor of the type
            var constructor = type.GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length)
                .First();

            // Get the arguments of the defined constructor and obtains the instances for them
            var args = constructor.GetParameters()
                .Select(p => 
                {
                    var instance = GetInstance(p.ParameterType);
                    if (instance == null)
                    {
                        instance = constructorParameters.FirstOrDefault(par => par.GetType().IsSubclassOf(p.ParameterType));
                    }
                    return instance;
                })
                .Where(a => a != null)
                .ToArray();

            var fullargs = args.ToList();
            //fullargs.AddRange(constructorParameters);

            // Creates a new instance of the type using the arguments instances
            return constructor.Invoke(fullargs.ToArray());
        }

        public T Get<T>() => (T)GetInstance(typeof(T));

        public void Register<I, C>() => Register(typeof(I), typeof(C));

        public void RegisterSingleton<I, C>()
            where C : I
        {
            var instance = CreateInstance(typeof(C));
            RegisterSingleton<I>((C)instance);
        }

        public void RegisterSingleton<T>(T obj) =>
            // Register the type in the dictionary using by definition the reference to the passed object.
            _registeredTypes.Add(typeof(T), () => obj);


        public void RemoveRegister<T>()
        {
            if (_registeredTypes.ContainsKey(typeof(T)))
            {
                _ = _registeredTypes.Remove(typeof(T));
            }
        }

        public T Get<T>(params object[] constructorParameters) => (T)CreateInstance(typeof(T), constructorParameters);

        public void Register(Type service, Type implementation) => _registeredTypes.Add(service, () => CreateInstance(implementation));

        public void Register(Type service) => _registeredTypes.Add(service, () => CreateInstance(service));

        public void RegisterFunction<T>(Func<object> function)
        {
            if (_registeredTypes.ContainsKey(typeof(T)))
            {
                _registeredTypes[typeof(T)] = function;
            }
            else
            {
                _registeredTypes.Add(typeof(T), function);
            }
        }

        public object Get(Type t) => CreateInstance(t);

        public object Get(Type t, params object[] constructorParameters) => CreateInstance(t, constructorParameters);

        public void RegisterSinglenton(Type service, Type implementation)
        {
            var instance = CreateInstance(implementation);
            _registeredTypes.Add(service, () => instance);
        }

        public void RegisterSinglenton(Type service, object implementation)
        {
            _registeredTypes.Add(service, () => implementation);
        }
    }
}