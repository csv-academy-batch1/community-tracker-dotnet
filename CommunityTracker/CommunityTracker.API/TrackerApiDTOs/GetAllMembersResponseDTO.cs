namespace CommunityTracker.API.TrackerApiDTOs
{
    public class GetAllMemberReponse
    {
        /// <summary>
        /// Gets or sets the communities.
        /// </summary>
        /// <value>
        /// The communities.
        /// </value>
        public List<GetAllMembersResponseDTO> CommunityMembers { get; set; }
    }

    public class GetAllMembersResponseDTO
    {
        public int PeopleId { get; set; }
        public int CommunityId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string HiredDate { get; set; }
        public int JobLevelId { get; set; }
        public int WorkStateId { get; set; }
        public bool IsActive { get; set; }
    }
}