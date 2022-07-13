﻿using System.ComponentModel.DataAnnotations;

namespace CommunityTracker.Service.ServicesDTO
{
    public class AddCommunityResponseDTO
    {
        [Key]
        public int communityid { get; set; }
        public string communityname { get; set; }
        public string communitymanagername { get; set; }
        public string communitydesc { get; set; }
    }
}