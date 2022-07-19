using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.Service.ServicesDTO
{
    /// <summary>
    /// 
    /// </summary>
    public class CommunityUpdateResponseDTO
    {
        /// <summary>
        /// Gets or sets the communityid.
        /// </summary>
        /// <value>
        /// The communityid.
        /// </value>
        [Key]
        public int communityid { get; set; }

        /// <summary>
        /// Gets or sets the communityname.
        /// </summary>
        /// <value>
        /// The communityname.
        /// </value>
        public string communityname { get; set; }

        /// <summary>
        /// Gets or sets the communitymanagername.
        /// </summary>
        /// <value>
        /// The communitymanagername.
        /// </value>
        public string communitymanagername { get; set; }

        /// <summary>
        /// Gets or sets the communitydesc.
        /// </summary>
        /// <value>
        /// The communitydesc.
        /// </value>
        public string? communitydesc { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        public bool isActive { get; set; } = true;
    }
}