using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class UpdateRequestDTO
    {
        [Required]
        [JsonProperty("communityId")]
        public int communityid { get; set; }
        [JsonProperty("communityName")]
        public string communityname { get; set; }
        [Required]
        [JsonProperty("communityMgrid")]
        public int? communitymgrid { get; set; }
        [JsonProperty("communityDesc")]
        public string communitydesc { get; set; }
    }
}
