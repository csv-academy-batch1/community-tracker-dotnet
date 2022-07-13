using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
namespace CommunityTracker.Service.Query
{
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        public IEnumerable<CommunityManagersDTO> GetAllCommunityManagers()
        {
            var displayAllCommunityManagers = _communityRepositoryQuery.GetAllCommunityManagers();
            List<CommunityManagersDTO> result = new List<CommunityManagersDTO>();
            foreach (var item in displayAllCommunityManagers)
            {
                result.Add(new CommunityManagersDTO()
                {
                    communityadminandmanagerid = item.communityadminandmanagerid,
                    communityadminandmanagername = item.communityadminandmanagername,
                    csvemail = item.csvemail,
                    passkey = item.passkey,
                    roletype = item.roletype,
                    isactive = item.isactive
                });
            }
            return result;
        }
    }
}