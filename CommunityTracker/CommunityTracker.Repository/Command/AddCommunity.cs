using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public void AddCommunity(Community communityData)
        {
            _communityDbContext.Add(communityData);
            _communityDbContext.SaveChanges();
        }
    }
}