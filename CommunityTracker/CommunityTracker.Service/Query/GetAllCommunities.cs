﻿using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;

namespace CommunityTracker.Service.Query
{
    public partial class CommunityServiceQuery : ICommunityServiceQuery
    {
        public async Task<List<CommunityDTOResponse>> GetAllCommunities()
        {
            var displayAllCommunities = await _communityRepositoryQuery.GetAllCommunities();
            List<CommunityDTOResponse> result = new List<CommunityDTOResponse>();
            foreach (var item in displayAllCommunities)
            {
                result.Add(new CommunityDTOResponse()
                {
                    communityid = item.CommunityId,
                    communityname = item.CommunityName
                });
            }
            return result;
        }
    }
}
