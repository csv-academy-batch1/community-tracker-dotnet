using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class DeleteRequest
    {
        public int communityid { get; set; }
        public bool isactive { get; set; } 
    }
}
