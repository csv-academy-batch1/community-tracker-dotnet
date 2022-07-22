using CommunityTracker.Repository.RepositoryDTO;


namespace CommunityTracker.Repository.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICommunityRepositoryMembers
    {
        /// <summary>
        /// Gets all members.
        /// </summary>
        /// <returns></returns>
        Task<List<CommunityMembers>> GetAllMembers();
    }
}
