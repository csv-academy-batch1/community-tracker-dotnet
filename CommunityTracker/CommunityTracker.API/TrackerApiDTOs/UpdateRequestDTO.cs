using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class UpdateRequestDTO
    {
        [Required]
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        [Required]
        public int? CommunityMgrid { get; set; }
        public string CommunityDesc { get; set; }
    }
}