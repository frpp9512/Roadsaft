namespace INGECO.DriversControl
{
    /// <summary>
    /// Represents a filter of drivers to be shown in the main form.
    /// </summary>
    public enum DriverCategoryFilter
    {
        /// <summary>
        /// All the drivers regradless the category.
        /// </summary>
        All = 0,

        /// <summary>
        /// All the Professional drivers only.
        /// </summary>
        ProfessionalsOnly = 1,

        /// <summary>
        /// All the Non-profressional drivers only.
        /// </summary>
        NonProfessionalsOnly = 2
    }
}