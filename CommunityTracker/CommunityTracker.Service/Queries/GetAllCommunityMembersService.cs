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
                    peopleid = item.PeopleId,
                    lastname = item.LastName,
                    firstname = item.FirstName,
                    middlename = item.MiddleName,
                    hireddate = item.HiredDate,
                    joblevelid = item.JobLevelId,
                    workstateid = item.WorkStateId,
                    isactive = item.IsActive
                });
            }

            return result;
        }

    }
}
