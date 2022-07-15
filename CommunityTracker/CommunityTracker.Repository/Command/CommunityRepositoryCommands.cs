using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;

namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        private readonly CommunityDbContext _communityDbContext;

        public CommunityRepositoryCommands(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}