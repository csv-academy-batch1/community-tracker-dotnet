using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTOs
{
    public class DeleteResponseDTO
    {
        /// <summary>Gets or sets the community identifier.</summary>
        /// <value>The community identifier.</value>
        [Key]
        public int CommunityId { get; set; }

        /// <summary>Gets or sets a value indicating whether this <see cref="DeleteResponseDTO" /> is active.</summary>
        /// <value>
        ///   <c>true</c> if active; otherwise, <c>false</c>.</value>
        public bool Active { get; set; }
    }
}
