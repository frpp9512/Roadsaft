namespace INGECO.DriversControl
{
    /// <summary>
    /// Represents a filter of drivers to show in the main form.
    /// </summary>
    public enum DriversView
    {
        /// <summary>
        /// Shows all drivers registered in the system.
        /// </summary>
        AllDrivers = 0,

        /// <summary>
        /// Shows all drivers without warnings or issues.
        /// </summary>
        DriversWithoutIssues = 1,

        /// <summary>
        /// Shows all drivers with warnings, independently if have issues.
        /// </summary>
        DriversWithWarnings = 2,

        /// <summary>
        /// Shows all drivers with issues, independently if have warnings.
        /// </summary>
        DriversWithIssues = 3,
    }
}