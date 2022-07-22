using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Queries
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityMembersService" />
    public partial class CommunityMembersService : ICommunityMembersService
    {
        /// <summary>
        /// Gets all community members.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CommunityMembersDTO>> GetAllCommunityMembers()
        {
            var members = await _communityRepositoryMembers.GetAllMembers();          
            List<CommunityMembersDTO> result = new List<CommunityMembersDTO>();

            //if (members == null)
            //{
            //    return null;
            //}

            foreach (var item in members)
            {
                result.Add(new CommunityMembersDTO()
                {
                    PeopleId = item.PeopleId,
                    CommunityId = item.CommunityId,
                    LastName = item.LastName,
                    FirstName = item.FirstName,
                    MiddleName = item.MiddleName,
                    HiredDate = item.HiredDate.Date.ToString("MM/dd/yyyy"),
                    JobLevelId = item.JobLevelId,
                    WorkStateId = item.WorkStateId,
                    IsActive = item.IsActive
                }) ;
            }
            return result;
        }

    }
}
