﻿using CommunityTracker.Repository.DataContext;
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
        private readonly CommunityDbContext _communityDbContext;

        public CommunityRepositoryCommands(CommunityDbContext communityDbContext)
        {
            _communityDbContext = communityDbContext;
        }
        public void AddCommunity(CommunityData communityData)
        {
            _communityDbContext.Add(communityData);
            _communityDbContext.SaveChanges();
        }
    }
}
