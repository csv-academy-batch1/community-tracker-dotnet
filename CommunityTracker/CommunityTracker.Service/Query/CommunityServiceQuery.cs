using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;

namespace CommunityTracker.Service.Query
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceQuery" />
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        /// <summary>
        /// The community repository query
        /// </summary>
        private readonly ICommunityRepositoryQuery _communityRepositoryQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityServiceQuery"/> class.
        /// </summary>
        /// <param name="communityRepositoryQuery">The community repository query.</param>
        public CommunityServiceQuery(ICommunityRepositoryQuery communityRepositoryQuery)
        {
            _communityRepositoryQuery = communityRepositoryQuery;
        }
    }
}