using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class DeleteRequestDTO
    {
        /// <summary>Gets or sets the community identifier.</summary>
        /// <value>The community identifier.</value>
        [Key]
        public int CommunityId { get; set; }

        /// <summary>Gets or sets a value indicating whether this instance is active.</summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.</value>
        public bool IsActive { get; set; }
    }
}
