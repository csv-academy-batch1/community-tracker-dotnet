using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommunityTracker.Service.ServicesDTO
{
    /// <summary>
    ///
    /// </summary>
    /// 
    public class CommunityDTOResponse
    {
        /// <summary>
        /// Gets or sets the communityid.
        /// </summary>
        /// <value>
        /// The communityid.
        /// </value>
        [Key]
        [JsonPropertyName("CommunityID")]
        public int communityid { get; set; }

        /// <summary>
        /// Gets or sets the communityname.
        /// </summary>
        /// <value>
        /// The communityname.
        /// </value>
        [JsonPropertyName("CommunityName")]
        public string communityname { get; set; }
        [JsonPropertyName("Description")]
        public string communitydescription { get; set; }
    }
}