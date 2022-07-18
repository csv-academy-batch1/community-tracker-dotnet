using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityUpdateResponseDTO> UpdateCommunityService(Community community)
        {
            var coms = new CommunityUpdateResponseDTO();
            coms.communityid = community.CommunityId;
            coms.communityname = community.CommunityName;
            coms.communitymanagername = community.CommunityName;
            coms.communitydesc = community.CommunityDesc;
            await _communityRepositoryCommands.UpdateCommunityRepository(community);
            return coms;
        }
    }
}
