namespace CommunityTracker.API.TrackerApiDTOs
{
    public class GetAllCommunitiesResponse
    {
        public List<GetAllCommunitiesResponseDTO> Communities { get; set; }
    }

    public class GetAllCommunitiesResponseDTO
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
    }
}
