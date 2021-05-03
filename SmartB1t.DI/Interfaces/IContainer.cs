using System;
using System.Collections.Generic;
using System.Text;

namespace SmartB1t.DI
{
    /// <summary>
    /// Represents an IoC Container.
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// Register an interface with it implementation.
        /// </summary>
        /// <typeparam name="I">The interface to register.</typeparam>
        /// <typeparam name="C">The implementation to register.</typeparam>
        void Register<I, C>();

        /// <summary>
        /// Register an interface with it implemetation.
        /// </summary>
        /// <param name="service">The interface to register.</param>
        /// <param name="implementation">The implementation to register.</param>
        void Register(Type service, Type implementation);

        /// <summary>
        /// Register an single instance of a specific type.
        /// </summary>
        /// <typeparam name="I">The service that implements the instance.</typeparam>
        /// <typeparam name="C">The implementation of the service.</typeparam>
        void RegisterSingleton<I, C>() 
            where C : I;

        /// <summary>
        /// Register an single instance of a specific type.
        /// </summary>
        /// <param name="service">The service that implements the instance.</typeparam>
        /// <param name="implementation">The implementation of the service.</typeparam>
        void RegisterSinglenton(Type service, Type implementation);

        /// <summary>
        /// Register an single instance of a specific type.
        /// </summary>
        /// <typeparam name="T">The type of the required instance.</typeparam>
        /// <param name="obj">The object to register as single instance.</param>
        void RegisterSingleton<T>(T implementation);

        /// <summary>
        /// Register an single instance of a specific type.
        /// </summary>
        /// <param name="service">The type of the required instance.</typeparam>
        /// <param name="obj">The object to register as single instance.</param>
        void RegisterSinglenton(Type service, object implementation);

        /// <summary>
        /// Register a function.
        /// </summary>
        /// <typeparam name="T">The registered type key.</typeparam>
        /// <param name="function">The function to execute when the <typeparamref name="T"/> key is requested.</param>
        void RegisterFunction<T>(Func<object> function);

        /// <summary>
        /// Removes a register.
        /// </summary>
        /// <typeparam name="T">The type of the register to remove.</typeparam>
        void RemoveRegister<T>();

        /// <summary>
        /// Get a registered instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The type of the required instance.</typeparam>
        /// <param name="ctorParameters">The parameters of the constructor.</param>
        /// <returns>The required instance.</returns>
        T Get<T>();

        /// <summary>
        /// Get a registered instance of a specified type.
        /// </summary>
        /// <typeparam name="T">The type of the required instance.</typeparam>
        /// <param name="ctorParameters">The parameters of the constructor.</param>
        /// <returns>The required instance.</returns>
        T Get<T>(params object[] constructorParameters);

        /// <summary>
        /// Get a registered instance of a specified type.
        /// </summary>
        /// <param name="t">The type of the registered instance.</param>
        /// <param name="ctorParameters">The parameters of the constructor.</param>
        /// <returns>The required instance.</returns>
        object Get(Type t);

        /// <summary>
        /// Get a registered instance of a specified type.
        /// </summary> 
        /// <param name="t">The type of the registered instance.</param>
        /// <param name="ctorParameters">The parameters of the constructor.</param>
        /// <returns>The required instance.</returns>
        object Get(Type t, params object[] constructorParameters);
    }
}
