using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    /// <summary>
    ///
    /// </summary>
    public class ResponseDTO
    {
        /// <summary>
        /// Gets or sets the community identifier.
        /// </summary>
        /// <value>
        /// The community identifier.
        /// </value>
        [Key]
        public int CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the community.
        /// </summary>
        /// <value>
        /// The name of the community.
        /// </value>
        public string? CommunityName { get; set; }

        /// <summary>
        /// Gets or sets the community manager.
        /// </summary>
        /// <value>
        /// The community manager.
        /// </value>
        public string? CommunityManager { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string? Description { get; set; }
        //public bool IsActive { get; set; }
    }
}