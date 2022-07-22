using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;

namespace CommunityTracker.Service.Queries
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityMembersService" />
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceQueries" />
    public partial class CommunityMembersService : ICommunityMembersService
    {

        /// <summary>
        /// The community repository members
        /// </summary>
        private readonly ICommunityRepositoryMembers _communityRepositoryMembers;


        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityMembersService"/> class.
        /// </summary>
        /// <param name="communityRepositoryMembers">The community repository members.</param>
        public CommunityMembersService(ICommunityRepositoryMembers communityRepositoryMembers)
        {
            _communityRepositoryMembers = communityRepositoryMembers;
        }

    }
}