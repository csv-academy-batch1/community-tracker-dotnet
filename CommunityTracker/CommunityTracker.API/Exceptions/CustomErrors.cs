namespace CommunityTracker.API.Exceptions
{
    /// <summary>
    ///
    /// </summary>
    public class CustomErrors
    {
        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public Result result { get; set; }
    }

    /// <summary>
    ///
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string message { get; set; } = "failed";
    }
}