﻿using CommunityTracker.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceCommands
    {
        void Add(CommunityDTO communityDTO);
        IEnumerable<CommunityDTO> GetAllCommunities();
    }
}