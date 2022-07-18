using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class UpdateResponseDTO
    {
        [Required]
        public int communityid { get; set; }
        public string communityname { get; set; }
        public string? communitymanager { get; set; }
        public string communitydesc { get; set; }
    }
}
