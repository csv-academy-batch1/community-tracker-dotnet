using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    public class UpdateRequestDTO
    {
 
        [Required]
        public int communityId { get; set; }

        public string communityName { get; set; }

  
        public int? communityMgrid { get; set; }

        public string communityDesc { get; set; }
    }
}
