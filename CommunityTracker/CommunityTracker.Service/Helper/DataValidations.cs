using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.Queries;
using CommunityTracker.Service.Commands;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Helper
{
    public static class DataValidations
    {
        public static async Task<CommunityResponseDTO> RequestValidation(ICommunityRepositoryQueries communityRepositoryQuery, CommunityDTO communityDTO)
        {
            var community = new CommunityResponseDTO();

            var communities = await communityRepositoryQuery.GetAllCommunities();
            var managers = await communityRepositoryQuery.GetAllManagers();

            //checks if community is existing
            bool communityExists = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

            //checks if managerId is existing
            bool managerIdExists = managers.Any(x => x.CommunityAdminAndManagerId == communityDTO.CommunityMgrid);

            if (communityExists || !managerIdExists)
            {
                return null;
            }

            return community;
        }
    }
}
