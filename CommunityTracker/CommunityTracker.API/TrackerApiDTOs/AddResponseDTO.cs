using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommunityTracker.API.TrackerApiDTO
{
    /// <summary>
    ///
    /// </summary>
    public class AddResponseDTO
    {
        /// <summary>
        /// Gets or sets the community identifier.
        /// </summary>
        /// <value>
        /// The community identifier.
        /// </value>
        [Key]
        [JsonPropertyName("Community Id")]
        public int CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the community.
        /// </summary>
        /// <value>
        /// The name of the community.
        /// </value>
        [JsonPropertyName("Community Name")]
        public string CommunityName { get; set; }

        /// <summary>
        /// Gets or sets the community manager.
        /// </summary>
        /// <value>
        /// The community manager.
        /// </value>
        [JsonPropertyName("Community Manager")]
        public string? CommunityManager { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        [JsonPropertyName("Description")]
        public string? Description { get; set; }
    }
}