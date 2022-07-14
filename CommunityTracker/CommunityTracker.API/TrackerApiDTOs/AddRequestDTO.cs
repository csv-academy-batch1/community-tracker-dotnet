using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    public class AddRequestDTO
    {
        [Required]
        public string CommunityName { get; set; }
        [Required]
        public int CommunityMgrId { get; set; }
        [Required]
        public string CommunityDesc { get; set; }
    }
}