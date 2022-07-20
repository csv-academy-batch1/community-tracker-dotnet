using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityTracker.Repository.RepositoryDTO
{
    /// <summary>
    ///
    /// </summary>
    [Table("communityadminandmanager")]
    public class CommunityManagers
    {
        /// <summary>
        /// Gets or sets the community admin and manager identifier.
        /// </summary>
        /// <value>
        /// The community admin and manager identifier.
        /// </value>
        [Key]
        [Column("communityadminandmanagerid")]
        public int CommunityAdminAndManagerId { get; set; }

        /// <summary>
        /// Gets or sets the name of the community admin and manager.
        /// </summary>
        /// <value>
        /// The name of the community admin and manager.
        /// </value>
        [Column("communityadminandmanagername")]
        public string CommunityAdminAndManagerName { get; set; }

        /// <summary>
        /// Gets or sets the CSV email.
        /// </summary>
        /// <value>
        /// The CSV email.
        /// </value>
        [Column("csvemail")]
        public string CSVEmail { get; set; }

        /// <summary>
        /// Gets or sets the pass key.
        /// </summary>
        /// <value>
        /// The pass key.
        /// </value>
        [Column("passkey")]
        public string PassKey { get; set; }

        /// <summary>
        /// Gets or sets the type of the role.
        /// </summary>
        /// <value>
        /// The type of the role.
        /// </value>
        [Column("roletype")]
        public string RoleType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>
        [Column("isactive")]
        public bool IsActive { get; set; } = true;
    }
}