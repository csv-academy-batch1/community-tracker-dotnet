using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Query
{
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        private readonly ICommunityRepositoryQuery _communityRepositoryQuery;

        public CommunityServiceQuery(ICommunityRepositoryQuery communityRepositoryQuery)
        {
            _communityRepositoryQuery = communityRepositoryQuery;
        }
    }
}
