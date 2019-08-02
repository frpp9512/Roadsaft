namespace INGECO.DriversControl
{
    /// <summary>
    /// Represents the action that the Driver Detail form will perform when loads.
    /// </summary>
    public enum DriverDetailsInitialAction
    {
        /// <summary>
        /// No action.
        /// </summary>
        None = 0,
        
        /// <summary>
        /// Opens with the License tab active.
        /// </summary>
        LicenseTabOpen = 1,

        /// <summary>
        /// Opens with the Requalification tab active.
        /// </summary>
        RequalificationTabOpen = 2,

        /// <summary>
        /// Opens with the Medical Exam tab active.
        /// </summary>
        MedicalExamTabOpen = 3,

        /// <summary>
        /// Opens with the New License dialog open.
        /// </summary>
        LicenseRenewal = 4,
        
        /// <summary>
        /// Opens with the New Requalification dialog open.
        /// </summary>
        RequalificationRenewal = 5,

        /// <summary>
        /// Opens with the New Medical Exam dialog open.
        /// </summary>
        NewMedicalExam = 6
    }
}