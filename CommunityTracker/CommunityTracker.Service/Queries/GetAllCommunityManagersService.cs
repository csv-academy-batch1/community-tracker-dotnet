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
                    CommunityAdminAndManagerId = manager.CommunityAdminAndManagerId,
                    CommunityAdminAndManagerName = manager.CommunityAdminAndManagerName,
                    CsvEmail = manager.CSVEmail,
                    PassKey = manager.PassKey,
                    RoleType = manager.RoleType,
                    IsActive = manager.IsActive
                });
            }

            return result;
        }
    }
}