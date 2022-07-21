﻿using CommunityTracker.API.Exceptions;
using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.API.TrackerApiDTOs;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using Microsoft.AspNetCore.Mvc;

namespace CommunityTracker.API.Controllers
{
    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        /// <summary>
        /// The community service commands
        /// </summary>
        private readonly ICommunityServiceCommands _communityServiceCommands;

        /// <summary>
        /// The community service query
        /// </summary>
        private readonly ICommunityServiceQueries _communityServiceQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityController"/> class.
        /// </summary>
        /// <param name="communityServiceCommands">The community service commands.</param>
        /// <param name="communityServiceQuery">The community service query.</param>
        public CommunityController(ICommunityServiceCommands communityServiceCommands, ICommunityServiceQueries communityServiceQuery)
        {
            _communityServiceCommands = communityServiceCommands;
            _communityServiceQuery = communityServiceQuery;
        }

        /// <summary>
        /// Gets all communities.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllCommunities()
        {
            var communities = await _communityServiceQuery.GetAllCommunities();
            List<GetAllCommunitiesResponseDTO> res = new List<GetAllCommunitiesResponseDTO>();
            foreach (var community in communities)
            {
                res.Add(new GetAllCommunitiesResponseDTO()
                {
                    CommunityId = community.communityid,
                    CommunityName = community.communityname
                });
            }

            GetAllCommunitiesResponse response = new GetAllCommunitiesResponse();
            response.Communities = res;

            return Ok(response);
        }

        /// <summary>
        /// Gets all managers.
        /// </summary>
        /// <returns></returns>
        [HttpGet("managers")]
        public async Task<IActionResult> GetAllManagers()
        {
            var items = await _communityServiceQuery.GetAllCommunityManagers();
            return Ok(items);
        }

        /// <summary>
        /// Adds the community.
        /// </summary>
        /// <param name="request">The API dto.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddCommunity([FromBody] AddRequestDTO request)
        {
            if (request == null)
            {
                return null;
            }

            var communityDTO = new CommunityDTO
            {
                CommunityName = request.CommunityName,
                CommunityMgrid = request.CommunityMgrid,
                CommunityDesc = request.Description
            };

            var result = await _communityServiceCommands.AddCommunity(communityDTO);

            if (result == null)
            {
                return BadRequest(new CustomErrors()
                {
                    Result = new Result()
                });
            }

            var response = new ResponseDTO()
            {
                CommunityId = result.CommunityId,
                CommunityName = result.CommunityName,
                CommunityManager = result.CommunityManagerName,
                Description = result.CommunityDesc,
                Active = result.isActive
            };

            return Ok(response);
        }
    }
}