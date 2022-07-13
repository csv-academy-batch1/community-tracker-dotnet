using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryCommands
    {
        void AddCommunityRepository(Community communityData);
    }
}