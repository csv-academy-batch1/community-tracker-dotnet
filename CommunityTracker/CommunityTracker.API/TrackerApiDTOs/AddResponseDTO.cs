using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    public class AddResponseDTO
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