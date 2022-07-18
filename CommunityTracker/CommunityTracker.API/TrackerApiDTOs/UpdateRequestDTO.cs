using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class UpdateRequestDTO
    {
        [Required]
        public int CommunityID { get; set; }
        [Required]
        public string CommunityName { get; set; }
        [Required]
        public int? CommunityManager { get; set; }
        [Required]
        public string Description { get; set; }
    }
}