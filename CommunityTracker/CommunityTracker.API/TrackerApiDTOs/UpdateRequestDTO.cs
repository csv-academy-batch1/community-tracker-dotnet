using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class UpdateRequestDTO
    {
        [Required]
        public int communityid { get; set; }
        public string communityname { get; set; }
        public int? communitymgrid { get; set; }
        public string communitydesc { get; set; }
    }
}
