using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateResponseDTO
    {
        /// <summary>
        /// Gets or sets the communityid.
        /// </summary>
        /// <value>
        /// The communityid.
        /// </value>
        [Required]
        public int communityid { get; set; }

        /// <summary>
        /// Gets or sets the communityname.
        /// </summary>
        /// <value>
        /// The communityname.
        /// </value>
        public string communityname { get; set; }

        /// <summary>
        /// Gets or sets the communitymanager.
        /// </summary>
        /// <value>
        /// The communitymanager.
        /// </value>
        public string? communitymanager { get; set; }

        /// <summary>
        /// Gets or sets the communitydesc.
        /// </summary>
        /// <value>
        /// The communitydesc.
        /// </value>
        public string communitydesc { get; set; }
    }
}