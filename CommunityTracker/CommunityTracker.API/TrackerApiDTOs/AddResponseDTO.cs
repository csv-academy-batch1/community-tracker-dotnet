using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class AddResponseDTO
    {
        [Key]
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string? CommunityManager { get; set; }
        public string Description { get; set; }
    }
}