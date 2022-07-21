using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
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

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is active; otherwise, <c>false</c>.
        /// </value>

        public bool Active { get; set; }
    }
}