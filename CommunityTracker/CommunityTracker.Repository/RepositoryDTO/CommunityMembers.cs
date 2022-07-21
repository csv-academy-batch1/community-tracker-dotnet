using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.RepositoryDTO
{
    public class CommunityMembers
    {
        [Key]
        
        [Column("peopleid")]
        public int PeopleId { get; set; }

        [Column("communityid")]
        public int CommunityId { get; set; }

        [Column("lastname")]
        public string LastName { get; set; }    
        
        [Column("firstname")]
        public string FirstName { get; set; }   
        
        [Column("middlename")]
        public string MiddleName { get; set; }

        [Column("hireddate")]
        public DateTime HiredDate { get; set; }
        
        [Column("joblevelid")]
        public int JobLevelId { get; set; }

        //TODO: Skills: 1(Key value pair id & skillname)
        
        [Column("joblevelid")]
        public int WorkStateId { get; set; }
        
        [Column("isactive")]
        public bool IsActive { get; set; } = true;

    }
}
