using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.Service.DTO
{
    /// <summary>
    ///
    /// </summary>
    public class CommunityDTO
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
        /// Gets or sets the communityicon.
        /// </summary>
        /// <value>
        /// The communityicon.
        /// </value>
        public string? communityicon { get; set; }

        /// <summary>
        /// Gets or sets the communitymgrid.
        /// </summary>
        /// <value>
        /// The communitymgrid.
        /// </value>
        public int? communitymgrid { get; set; }

        /// <summary>
        /// Gets or sets the communitydesc.
        /// </summary>
        /// <value>
        /// The communitydesc.
        /// </value>
        public string? communitydesc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CommunityDTO"/> is isactive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if isactive; otherwise, <c>false</c>.
        /// </value>
        public bool isactive { get; set; }
    }
}