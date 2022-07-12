using CommunityTracker.Service.Interfaces;
using CommunityTracker.Repository.Interfaces;
namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        private readonly ICommunityRepositoryCommands _communityRepositoryCommands;
        public CommunityServiceCommands(ICommunityRepositoryCommands communityRepositoryCommands)
        {
            _communityRepositoryCommands = communityRepositoryCommands;
        }
    }
}