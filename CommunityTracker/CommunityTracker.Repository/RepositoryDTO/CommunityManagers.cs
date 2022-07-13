using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.RepositoryDTO
{
    public class CommunityManagers
    {
        [Key]
        public int communityadminandmanagerid { get; set; }
        public string communityadminandmanagername { get; set; }
        public string csvemail { get; set; }
        public string passkey { get; set; }
        public string roletype { get; set; }
        public bool isactive { get; set; }
    }
}
