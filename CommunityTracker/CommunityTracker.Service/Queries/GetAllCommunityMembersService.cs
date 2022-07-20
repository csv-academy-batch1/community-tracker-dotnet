using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Queries
{
    public partial class CommunityServiceQueries : ICommunityServiceQueries
    {
        public async Task<List<CommunityMembersResponseDTO>> GetAllCommunityMembers()
        {
            var members = await _communityRepositoryQuery.GetAllMembers();
            List<CommunityMembersResponseDTO> result = new List<CommunityMembersResponseDTO>();

            foreach (var item in members)
            {
                result.Add(new CommunityMembersResponseDTO()
                {
                    PeopleId = item.PeopleId,
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    MiddleName = item.MiddleName,
                    HiredDate = item.HiredDate,
                    JobLevelId = item.JobLevelId,
                    WorkStateId = item.WorkStateId,
                    IsActive = item.IsActive
                });
            }

            return result;
        }

    }
}
