using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.ServicesDTO
{
    public class CommunityMembersDTO
    {

        public int PeopleId { get; set; }
        public int CommunityId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string HiredDate { get; set; }
        public int JobLevelId { get; set; }
        public int WorkStateId { get; set; }
        public bool IsActive { get; set; } 
    }
}
