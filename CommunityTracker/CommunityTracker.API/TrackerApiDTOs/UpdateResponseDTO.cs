using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class UpdateResponseDTO
    {
        [Key]
        
        public int CommunityId { get; set; }
        
        public string CommunityName { get; set; }
        
        public string? CommunityManager { get; set; }
       
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}