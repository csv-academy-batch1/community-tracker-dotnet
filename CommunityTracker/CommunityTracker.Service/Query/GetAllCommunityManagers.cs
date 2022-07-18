using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Query
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceQuery" />
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        /// <summary>
        /// Gets all community managers.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CommunityManagersDTO>> GetAllCommunityManagers()
        {
            var displayAllCommunityManagers = await _communityRepositoryQuery.GetAllManagers();
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