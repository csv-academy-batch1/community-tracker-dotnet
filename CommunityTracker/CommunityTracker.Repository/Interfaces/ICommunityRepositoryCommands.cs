using CommunityTracker.Repository.Entities;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryCommands
    {
        void AddCommunityRepository(Community communityData);
    }
}