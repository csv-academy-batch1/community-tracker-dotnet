using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace CommunityTracker.API.TrackerApiDTO
{
    public class UpdateRequestDTO
    {
        /// <summary>Gets or sets the community identifier.</summary>
        /// <value>The community identifier.</value>
        public int CommunityId { get; set; }
        /// <summary>Gets or sets the name of the community.</summary>
        /// <value>The name of the community.</value>
        public string CommunityName { get; set; }
        /// <summary>Gets or sets the community mgrid.</summary>
        /// <value>The community mgrid.</value>
        public int? CommunityMgrid { get; set; }
        /// <summary>Gets or sets the community desc.</summary>
        /// <value>The community desc.</value>
        public string CommunityDesc { get; set; }
    }
}