using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.Entities
{
    public class Community
    {
        [Key]
        public int communityid { get; set; }
        public string communityname { get; set; }
        public string communityicon { get; set; }
        public int communitymgrid { get; set; }
        public string communitydesc { get; set; }
        public bool isactive { get; set; }
    }
}
