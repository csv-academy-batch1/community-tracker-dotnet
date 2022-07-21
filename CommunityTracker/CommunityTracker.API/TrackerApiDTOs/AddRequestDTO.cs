using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.API.TrackerApiDTO
{
    /// <summary>
    ///
    /// </summary>
    public class AddRequestDTO
    {
        /// <summary>
        /// Gets or sets the name of the community.
        /// </summary>
        /// <value>
        /// The name of the community.
        /// </value>
        [Required]
        public string CommunityName { get; set; }

        /// <summary>
        /// Gets or sets the community manager.
        /// </summary>
        /// <value>
        /// The community manager.
        /// </value>
        [Required]
        public int? CommunityMgrid { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
    }
}