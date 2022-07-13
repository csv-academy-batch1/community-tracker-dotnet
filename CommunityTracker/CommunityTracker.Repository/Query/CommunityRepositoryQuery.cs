using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.Query
{
    public partial class CommunityRepositoryQuery : ICommunityRepositoryQuery
    {
        private readonly CommunityDbContext _communityDbContext;
        public CommunityRepositoryQuery(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
    }
}