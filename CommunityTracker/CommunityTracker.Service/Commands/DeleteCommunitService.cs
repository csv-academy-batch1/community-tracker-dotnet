using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Commands
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public async Task<CommunityResponseDTO> DeleteCommunity(CommunityDTO communityDTO)
        {
            var communityResponseDTO = new CommunityResponseDTO();
            var communities = await _communityRepositoryQuery.GetAllCommunities();

            //check if ID is existing
            var communityIdExists = communities.First(x => x.CommunityId == communityDTO.CommunityId);

            if (communityIdExists == null)
            {
                return null;
            }
            await _communityRepositoryCommands.DeleteCommunity(new Community()
            {
                CommunityId = communityDTO.CommunityId,
                IsActive = communityDTO.IsActive,
            });
            return communityResponseDTO;
        }
    }
}
