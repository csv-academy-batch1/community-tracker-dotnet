﻿using CommunityTracker.Service.ServiceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Interfaces
{
    public interface ICommunityServiceCommands
    {
        public void Add(ServiceCommunityDTO itemDTO);

    }
}
