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
            bool isCommunityNameExist = communities.Any(x => x.CommunityName.ToLower() == communityDTO.CommunityName.ToLower());

            //checks if managerId is existing
            bool isManagerIdExist = managers.Any(x => x.CommunityAdminAndManagerId == communityDTO.CommunityMgrid);

            if (isCommunityNameExist || !isManagerIdExist)
            {
                return null;
            }

            return community;
        }

        public static async Task<CommunityResponseDTO> ActiveStatusValidation(ICommunityRepositoryQueries communityRepositoryQuery, CommunityDTO communityDTO)
        {
            var community = new CommunityResponseDTO();

            var communities = await communityRepositoryQuery.GetAllCommunities();

            bool activeStatus = communities.Where(x => x.CommunityId == communityDTO.CommunityId).Select(x => x.IsActive).FirstOrDefault();

            if (activeStatus == false)
            {
                return null;
            };

            return community;
        }
    }   
}
