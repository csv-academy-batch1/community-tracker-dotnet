using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;

namespace CommunityTracker.Service.Commands
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceCommands" />
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        /// <summary>
        /// The community repository commands
        /// </summary>
        private readonly ICommunityRepositoryCommands _communityRepositoryCommands;

        /// <summary>
        /// The community repository query
        /// </summary>
        private readonly ICommunityRepositoryQuery _communityRepositoryQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityServiceCommands"/> class.
        /// </summary>
        /// <param name="communityRepositoryCommands">The community repository commands.</param>
        /// <param name="communityRepositoryQuery">The community repository query.</param>
        public CommunityServiceCommands(ICommunityRepositoryCommands communityRepositoryCommands,
            ICommunityRepositoryQuery communityRepositoryQuery)
        {
            _communityRepositoryCommands = communityRepositoryCommands;
            _communityRepositoryQuery = communityRepositoryQuery;
        }
    }
}