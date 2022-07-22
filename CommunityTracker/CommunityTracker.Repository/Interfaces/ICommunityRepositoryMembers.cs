using CommunityTracker.Repository.RepositoryDTO;


namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryMembers
    {
        Task<List<CommunityMembers>> GetAllMembers();
    }
}
