using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;

namespace CommunityTracker.Service.Query
{
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        private readonly ICommunityRepositoryQuery _communityRepositoryQuery;
        public CommunityServiceQuery(ICommunityRepositoryQuery communityRepositoryQuery)
        {
            _communityRepositoryQuery = communityRepositoryQuery;
        }
    }
}
