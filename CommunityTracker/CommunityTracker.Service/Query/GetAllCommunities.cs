using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
namespace CommunityTracker.Service.Query
{
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        public IEnumerable<CommunityDTO> GetAllCommunities()
        {
            var displayAllCommunities = _communityRepositoryQuery.GetAllCommunities();
            List<CommunityDTO> result = new List<CommunityDTO>();
            foreach (var item in displayAllCommunities)
            {
                result.Add(new CommunityDTO()
                {
                    communityid = item.CommunityId,
                    communitydesc = item.CommunityDesc,
                    communityicon = item.CommunityIcon,
                    communitymgrid = item.CommunityMgrid,
                    communityname = item.CommunityName,
                    isactive = item.IsActive
                });
            }
            return result;
        }
    }
}
