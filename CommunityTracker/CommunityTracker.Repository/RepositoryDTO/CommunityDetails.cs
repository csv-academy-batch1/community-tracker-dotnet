namespace CommunityTracker.Repository.RepositoryDTO
{
    /// <summary>
    ///
    /// </summary>
    public class CommunityDetails
    {
        /// <summary>
        /// Gets or sets the community identifier.
        /// </summary>
        /// <value>
        /// The community identifier.
        /// </value>
        public int CommunityId { get; set; }

        /// <summary>
        /// Gets or sets the name of the community.
        /// </summary>
        /// <value>
        /// The name of the community.
        /// </value>
        public string? CommunityName { get; set; }

        /// <summary>
        /// Gets or sets the community mgrid.
        /// </summary>
        /// <value>
        /// The community mgrid.
        /// </value>
        public int? CommunityMgrid { get; set; }

        /// <summary>
        /// Gets or sets the community desc.
        /// </summary>
        /// <value>
        /// The community desc.
        /// </value>
        public string? CommunityDesc { get; set; }

        /// <summary>
        /// Gets or sets the name of the community admin and manager.
        /// </summary>
        /// <value>
        /// The name of the community admin and manager.
        /// </value>
        public string? CommunityAdminAndManagerName { get; set; }
    }
}