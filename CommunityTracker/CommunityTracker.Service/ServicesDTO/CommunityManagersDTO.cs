﻿using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.Service.ServicesDTO
{
    public class CommunityManagersDTO
    {
        [Key]
        public int communityadminandmanagerid { get; set; }
        public string communityadminandmanagername { get; set; }
        public string csvemail { get; set; }
        public string passkey { get; set; }
        public string roletype { get; set; }
        public bool isactive { get; set; }
    }
}