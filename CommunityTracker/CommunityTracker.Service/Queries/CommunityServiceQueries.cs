using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;

namespace CommunityTracker.Service.Queries
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceQueries" />
    public partial class CommunityServiceQueries : ICommunityServiceQueries
    {
        /// <summary>
        /// The community repository query
        /// </summary>
        private readonly ICommunityRepositoryQueries _communityRepositoryQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityServiceQueries"/> class.
        /// </summary>
        /// <param name="communityRepositoryQuery">The community repository query.</param>
        public CommunityServiceQueries(ICommunityRepositoryQueries communityRepositoryQuery)
        {
            _communityRepositoryQuery = communityRepositoryQuery;
        }

    }
}