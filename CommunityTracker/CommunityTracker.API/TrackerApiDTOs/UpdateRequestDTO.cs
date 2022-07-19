using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    /// <summary>
    ///
    /// </summary>
    public class UpdateRequestDTO
    {
        /// <summary>
        /// Gets or sets the communityid.
        /// </summary>
        /// <value>
        /// The communityid.
        /// </value>
        [Required]
        public int communityId { get; set; }

        /// <summary>
        /// Gets or sets the communityname.
        /// </summary>
        /// <value>
        /// The communityname.
        /// </value>
        public string communityName { get; set; }

        /// <summary>
        /// Gets or sets the communitymgrid.
        /// </summary>
        /// <value>
        /// The communitymgrid.
        /// </value>
        public int? communityMgrid { get; set; }

        /// <summary>
        /// Gets or sets the communitydesc.
        /// </summary>
        /// <value>
        /// The communitydesc.
        /// </value>
        public string communityDesc { get; set; }
    }
}