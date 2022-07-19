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
        /// Gets all communities.
        /// </summary>
        /// <returns></returns>
        public async Task<List<CommunityDTOResponse>> GetAllCommunities()
        {
            var displayAllCommunities = await _communityRepositoryQuery.GetAllCommunities();
            List<CommunityDTOResponse> result = new List<CommunityDTOResponse>();
            foreach (var item in displayAllCommunities)
            {
                result.Add(new CommunityDTOResponse()
                {
                    communityid = item.CommunityId,
                    communityname = item.CommunityName
                });
            }
            return result;
        }

    }
}