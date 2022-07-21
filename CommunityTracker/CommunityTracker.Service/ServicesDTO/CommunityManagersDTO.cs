using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.Service.ServicesDTO
{
    /// <summary>
    ///
    /// </summary>
    public class CommunityManagersDTO
    {
        /// <summary>
        /// Gets or sets the communityadminandmanagerid.
        /// </summary>
        /// <value>
        /// The communityadminandmanagerid.
        /// </value>
        [Key]
        public int CommunityAdminAndManagerId { get; set; }

        /// <summary>
        /// Gets or sets the communityadminandmanagername.
        /// </summary>
        /// <value>
        /// The communityadminandmanagername.
        /// </value>
        public string CommunityAdminAndManagerName { get; set; }

        /// <summary>
        /// Gets or sets the csvemail.
        /// </summary>
        /// <value>
        /// The csvemail.
        /// </value>
        public string CsvEmail { get; set; }

        /// <summary>
        /// Gets or sets the passkey.
        /// </summary>
        /// <value>
        /// The passkey.
        /// </value>
        public string PassKey { get; set; }

        /// <summary>
        /// Gets or sets the roletype.
        /// </summary>
        /// <value>
        /// The roletype.
        /// </value>
        public string RoleType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="CommunityManagersDTO"/> is isactive.
        /// </summary>
        /// <value>
        ///   <c>true</c> if isactive; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; } = true;
    }
}