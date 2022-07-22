using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityTracker.Repository.RepositoryDTO
{
    /// <summary>
    ///
    /// </summary>
    [Table("community")]
    public class Community
    {
        /// <summary>
        /// Gets or sets the community identifier.
        /// </summary>
        /// <value>
        /// The community identifier.
        /// </value>
        [Key]
        [Column("communityid")]
        public int CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the community.
        /// </summary>
        /// <value>
        /// The name of the community.
        /// </value>
        [Column("communityname")]
        public string CommunityName { get; set; }

        /// <summary>
        /// Gets or sets the community icon.
        /// </summary>
        /// <value>
        /// The community icon.
        /// </value>
        [Column("communityicon")]
        public string? CommunityIcon { get; set; }

        /// <summary>
        /// Gets or sets the community mgrid.
        /// </summary>
        /// <value>
        /// The community mgrid.
        /// </value>
        [Column("communitymgrid")]
        public int? CommunityMgrid { get; set; }

        /// <summary>
        /// Gets or sets the community desc.
        /// </summary>
        /// <value>
        /// The community desc.
        /// </value>
        [Column("communitydesc")]
        public string? CommunityDesc { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [Column("isactive")]
        public bool IsActive { get; set; }
    }
}