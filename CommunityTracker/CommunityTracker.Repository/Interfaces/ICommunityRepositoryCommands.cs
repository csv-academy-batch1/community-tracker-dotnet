﻿using CommunityTracker.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Repository.Interfaces
{
    public interface ICommunityRepositoryCommands
    {
        void AddCommunity(Community communityData);
        IQueryable<Community> GetAllCommunities();
    }
}