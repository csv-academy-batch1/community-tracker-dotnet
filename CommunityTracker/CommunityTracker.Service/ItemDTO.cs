﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service
{
    public class ItemDTO
    {
        public int Id { get; set; }
        public string CommunityName { get; set; }
        public string CommunityManager { get; set; }
        public string CommunityDescription { get; set; }
    }
}
