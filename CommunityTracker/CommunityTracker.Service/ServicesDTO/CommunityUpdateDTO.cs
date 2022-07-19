using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.Service.ServicesDTO
{
    /// <summary>
    ///
    /// </summary>
    public class CommunityUpdateDTO
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

        /// <summary>
        /// Gets or sets the communitymanagername.
        /// </summary>
        /// <value>
        /// The communitymanagername.
        /// </value>
        public string CommunityManagerName { get; set; }

        /// <summary>
        /// Gets or sets the communitydesc.
        /// </summary>
        /// <value>
        /// The communitydesc.
        /// </value>
        public string? CommunityDesc { get; set; }
    }
}