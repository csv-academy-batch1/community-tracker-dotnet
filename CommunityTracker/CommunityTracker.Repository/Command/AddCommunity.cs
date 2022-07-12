using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.Command
{
    public partial class CommunityRepositoryCommands : ICommunityRepositoryCommands
    {
        public void Save(Community community)
        {
            _appDataContext.community.Add(community);
            _appDataContext.SaveChanges();

        }
    }
}
