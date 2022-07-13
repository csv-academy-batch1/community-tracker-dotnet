using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.ServicesDTO
{
    public class AddCommunityResponseDTO
    {
        [Key]
        public int communityid { get; set; }
        public string communityname { get; set; }
        public string communitymanagername { get; set; }
        public string communitydesc { get; set; }
    }
}
