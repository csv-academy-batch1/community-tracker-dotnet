using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.RepositoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryQuery
    {
        IQueryable<Community> GetAllCommunities();
        IQueryable<CommunityManagers> GetAllCommunityManagers();
    }
}
