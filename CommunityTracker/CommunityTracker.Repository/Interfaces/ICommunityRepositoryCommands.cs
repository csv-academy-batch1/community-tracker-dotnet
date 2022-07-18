using CommunityTracker.Repository.Entities;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryCommands
    {
        Task AddCommunityRepository(Community communityData);
        Task UpdateCommunityRepository(Community communityData);
    }
}