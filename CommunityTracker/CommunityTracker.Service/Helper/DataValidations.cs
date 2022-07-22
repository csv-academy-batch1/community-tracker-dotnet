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
        /// <summary>Requests the validation.</summary>
        /// <param name="communityRepositoryQuery">The community repository query.</param>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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

        /// <summary>Actives the status validation.</summary>
        /// <param name="communityRepositoryQuery">The community repository query.</param>
        /// <param name="communityDTO">The community dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
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

        /// <summary>Communities the identifier status validation.</summary>
        /// <param name="communityRepositoryQueries">The community repository queries.</param>
        /// <param name="request">The request.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        public static async Task<CommunityResponseDTO> CommunityIdStatusValidation(ICommunityRepositoryQueries communityRepositoryQueries, CommunityDTO request)
        {
            var communityResponse = new CommunityResponseDTO();

            var getAllCommunities = await communityRepositoryQueries.GetAllCommunities();

            var communityDataExists = getAllCommunities.FirstOrDefault(x => x.CommunityId == request.CommunityId && x.IsActive == true);

            if (communityDataExists == null)
            {
                return null;
            }
            return communityResponse;
        }
    }   
}
