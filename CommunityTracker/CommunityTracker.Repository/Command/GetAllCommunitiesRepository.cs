using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public IQueryable<Community> GetAllCommunities()
        {
            return _communityDbContext.community.AsQueryable();
        }
    }
}
