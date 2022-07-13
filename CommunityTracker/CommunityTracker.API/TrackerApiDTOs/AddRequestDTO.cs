using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class AddRequestDTO
    {
        [Required]
        public string communityname { get; set; }
        [Required]
        public int? communitymgrid { get; set; }
        [Required]
        public string communitydesc { get; set; }
    }
}