using CommunityTracker.Service.Interfaces;
using CommunityTracker.Repository.Interfaces;
namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        private readonly ICommunityRepositoryCommands _communityRepositoryCommands;
        private readonly ICommunityRepositoryQuery _communityRepositoryQuery;
        public CommunityServiceCommands(ICommunityRepositoryCommands communityRepositoryCommands, ICommunityRepositoryQuery communityRepositoryQuery)
        {
            _communityRepositoryCommands = communityRepositoryCommands;
            _communityRepositoryQuery = communityRepositoryQuery;
        }
    }
}