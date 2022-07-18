using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class AddRequestDTO
    {
        [Required]
        public string CommunityName { get; set; }
        [Required]
        public int? CommunityManager { get; set; }
        public string Description { get; set; }
    }
}