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
        public int CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the communityname.
        /// </summary>
        /// <value>
        /// The communityname.
        /// </value>
        public string CommunityName { get; set; }
        public string Description { get; set; }
    }
}