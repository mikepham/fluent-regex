namespace FluentRegex
{
    /// <summary>
    /// Enumeration of phone number kinds.
    /// </summary>
    public enum PhoneNumberKind
    {
        /// <summary>
        /// Indicates a default phone number (United States).
        /// </summary>
        Default = 0,

        /// <summary>
        /// Indicates the phone number uses a mask matching United States numbers.
        /// </summary>
        UnitedStates = Default,
    }
}