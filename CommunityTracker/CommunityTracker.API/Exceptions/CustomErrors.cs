using System.Text.Json.Serialization;

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
 
        [JsonPropertyName("result")]
        public Result? Result { get; set; }
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

        [JsonPropertyName("message")]
        public string Message { get; set; } = "failed";
    }
}