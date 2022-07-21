using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class UpdateRequestDTO
    {
        [Required]
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        [Required]
        public int? CommunityMgrId { get; set; }
        public string CommunityDesc { get; set; }
    }
}
