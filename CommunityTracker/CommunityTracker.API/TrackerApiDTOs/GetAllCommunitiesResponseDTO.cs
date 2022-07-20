namespace CommunityTracker.API.TrackerApiDTOs
{
    public class GetAllCommunitiesResponse
    {
        public GetAllCommunitiesResponseDTO Communities { get; set; }
    }

    public class GetAllCommunitiesResponseDTO
    {
        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string CommunityDesc { get; set; }
    }
}
