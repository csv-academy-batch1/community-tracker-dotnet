using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommunityTracker.Service.ServicesDTO
{
    /// <summary>
    ///
    /// </summary>
    public class CommunityDTOResponse
    {
        /// <summary>
        /// Gets or sets the communityid.
        /// </summary>
        /// <value>
        /// The communityid.
        /// </value>
        [Key]
        [JsonPropertyName("Community ID")]
        public int communityid { get; set; }

        /// <summary>
        /// Gets or sets the communityname.
        /// </summary>
        /// <value>
        /// The communityname.
        /// </value>
        [JsonPropertyName("Community Name")]
        public string communityname { get; set; }
    }
}