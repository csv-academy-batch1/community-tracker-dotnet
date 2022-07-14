using System;
using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.Repository.Entities
{
    public class Community
    {
        [Key]
        public int communityid { get; set; }
        public string communityname { get; set; }
        public string? communityicon { get; set; }
        public int? communitymgrid { get; set; }
        public string? communitydesc { get; set; }
        public bool isactive { get; set; }
    }
}