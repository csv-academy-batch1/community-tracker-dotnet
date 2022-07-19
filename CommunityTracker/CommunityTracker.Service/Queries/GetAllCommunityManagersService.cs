using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Queries
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceQueries" />
    public partial class CommunityServiceQueries : ICommunityServiceQueries
    {
        /// <summary>
        /// Gets all community managers.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CommunityManagersDTO>> GetAllCommunityManagers()
        {
            var managers = await _communityRepositoryQuery.GetAllManagers();
            List<CommunityManagersDTO> result = new List<CommunityManagersDTO>();
            
            foreach (var manager in managers)
            {
                result.Add(new CommunityManagersDTO()
                {
                    communityadminandmanagerid = manager.CommunityAdminAndManagerId,
                    communityadminandmanagername = manager.CommunityAdminAndManagerName,
                    csvemail = manager.CSVEmail,
                    passkey = manager.PassKey,
                    roletype = manager.RoleType,
                    isactive = manager.IsActive
                });
            }

            return result;
        }
    }
}