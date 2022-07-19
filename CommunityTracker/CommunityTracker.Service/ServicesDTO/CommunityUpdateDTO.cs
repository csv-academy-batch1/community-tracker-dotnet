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
        /// Gets or sets the communityicon.
        /// </summary>
        /// <value>
        /// The communityicon.
        /// </value>
        public string? CommunityIcon { get; set; }

        /// <summary>
        /// Gets or sets the communitymgrid.
        /// </summary>
        /// <value>
        /// The communitymgrid.
        /// </value>
        public string? CommunityManager { get; set; }

        /// <summary>
        /// Gets or sets the communitydesc.
        /// </summary>
        /// <value>
        /// The communitydesc.
        /// </value>
        public string? CommunityDesc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CommunityDTO"/> is isactive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if isactive; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}