using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommunityTracker.Service.ServicesDTO
{
    public class CommunityDTOResponse
    {
        [Key]
        [JsonPropertyName("Community ID")]
        public int communityid { get; set; }
        [JsonPropertyName("Community Name")]
        public string communityname { get; set; }
    }
}