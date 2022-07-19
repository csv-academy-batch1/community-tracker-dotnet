using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class UpdateRequestDTO
    {
        [Required]
        public int communityid { get; set; }
        public string communityname { get; set; }
        [Required]
        public int? communitymgrid { get; set; }
        public string communitydesc { get; set; }
    }
}