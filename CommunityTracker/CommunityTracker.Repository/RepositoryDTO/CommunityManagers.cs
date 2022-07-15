using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommunityTracker.Repository.RepositoryDTO
{
    [Table("communityadminandmanager")]
    public class CommunityManagers
    {
        [Key]
        [Column("communityadminandmanagerid")]
        public int CommunityAdminAndManagerId { get; set; }
        [Column("communityadminandmanagername")]
        public string CommunityAdminAndManagerName { get; set; }
        [Column("csvemail")]
        public string CSVEmail { get; set; }
        [Column("passkey")]
        public string PassKey { get; set; }
        [Column("roletype")]
        public string RoleType { get; set; }
        [Column("isactive")]
        public bool IsActive { get; set; }
    }
}
