using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.ServicesDTO
{
    public class CommunityMembersResponseDTO
    {

        public int peopleid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public int hireddate { get; set; }
        public int joblevelid { get; set; }
        public int workstateid { get; set; }
        //public string otherdetails { get; set; }
        public bool isactive { get; set; } = true;
    }
}
