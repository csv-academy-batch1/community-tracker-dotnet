namespace CommunityTracker.API.TrackerApiDTOs
{
    public class GetAllCommunitiesResponse
    {
        /// <summary>
        /// Gets or sets the communities.
        /// </summary>
        /// <value>
        /// The communities.
        /// </value>
        public List<GetAllCommunitiesResponseDTO> Communities { get; set; }
    }

    public class GetAllCommunitiesResponseDTO
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
        public string CommunityName { get; set; }
    }
}