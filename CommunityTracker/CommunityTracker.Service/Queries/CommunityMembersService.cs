using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;

namespace CommunityTracker.Service.Queries
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="CommunityTracker.Service.Interfaces.ICommunityServiceQueries" />
    public partial class CommunityMembersService : ICommunityMembersService
    {
    
        private readonly ICommunityRepositoryMembers _communityRepositoryMembers;

      
        public CommunityMembersService(ICommunityRepositoryMembers communityRepositoryMembers)
        {
            _communityRepositoryMembers = communityRepositoryMembers;
        }

    }
}