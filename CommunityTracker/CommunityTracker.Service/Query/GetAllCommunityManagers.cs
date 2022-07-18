using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
namespace CommunityTracker.Service.Query
{
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        public async Task<IEnumerable<CommunityManagersDTO>> GetAllCommunityManagers()
        {
            var displayAllCommunityManagers = _communityRepositoryQuery.GetAllCommunityManagers();
            List<CommunityManagersDTO> result = new List<CommunityManagersDTO>();
            foreach (var item in displayAllCommunityManagers)
            {
                result.Add(new CommunityManagersDTO()
                {
                    communityadminandmanagerid = item.CommunityAdminAndManagerId,
                    communityadminandmanagername = item.CommunityAdminAndManagerName,
                    csvemail = item.CSVEmail,
                    passkey = item.PassKey,
                    roletype = item.RoleType,
                    isactive = item.IsActive
                });
            }
            return result;
        }
    }
}
