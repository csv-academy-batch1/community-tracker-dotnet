using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CommunityTracker.API.TrackerApiDTO
{
    public class AddResponseDTO
    {
        [Key]
        public int CommunityId { get; set; }
        [JsonPropertyName("Community Name")]
        public string CommunityName { get; set; }
        [JsonPropertyName("Community Manager")]
        public string? CommunityManager { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}