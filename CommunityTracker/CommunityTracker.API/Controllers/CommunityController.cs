﻿using CommunityTracker.API.Exceptions;
using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.API.TrackerApiDTOs;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using Microsoft.AspNetCore.Mvc;
using CommunityTracker.Repository.RepositoryDTO;

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
            var response = new GetAllCommunitiesResponse();
            var communities = await _communityServiceQuery.GetAllCommunities();
            var res = new List<GetAllCommunitiesResponseDTO>();

            if (communities == null)
            {
                ObjectResult errorResponse = ServerErrorResponse();
                return errorResponse;
            }

            foreach (var community in communities)
            {
                res.Add(new GetAllCommunitiesResponseDTO()
                {
                    CommunityId = community.communityid,
                    CommunityName = community.communityname
                });
            }

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
        /// <param name="request">The request.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddCommunity([FromBody] AddRequestDTO request)
        {
            if (request == null)
            {
                return ClientErrorResponse();
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
                return ClientErrorResponse();
            }

            if (result.ResultMessage == "Server Error")
            {
                return ServerErrorResponse();
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

        private IActionResult ClientErrorResponse()
        {
            return BadRequest(new CustomErrors()
            {
                Result = new Result()
            });
        }

        private ObjectResult ServerErrorResponse()
        {
            return StatusCode(500, new CustomErrors
            {
                Result = new Result
                {
                    Message = "Internal Server Error."
                }
            });
        }

        /// <summary>Updates the community.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="updateRequestDTO">The update request dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [Route("{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateCommunity(int id, [FromBody] UpdateRequestDTO updateRequestDTO)
        {
            var community = new CommunityDTO();

            if (id != updateRequestDTO.CommunityId)
            {
                return ClientErrorResponse();
            }

            community.CommunityId = id;
            community.CommunityName = updateRequestDTO.CommunityName;
            community.CommunityMgrid = updateRequestDTO.CommunityMgrid;
            community.CommunityDesc = updateRequestDTO.Description;

            var result = await _communityServiceCommands.UpdateCommunity(community);

            if (result == null)
            {
                return ClientErrorResponse();
            }

            if (result.ResultMessage == "Server Error")
            {
                return ServerErrorResponse();
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

        /// <summary>Deletes the community.</summary>
        /// <param name="id">The identifier.</param>
        /// <param name="deleteRequestDTO">The delete request dto.</param>
        /// <returns>
        ///   <br />
        /// </returns>
        [Route("{id}")]
        [HttpDelete]
        public async Task<IActionResult> DeleteCommunity(int id, [FromBody] DeleteRequestDTO deleteRequestDTO)
        {
            var communityDTO = new CommunityDTO();

            if (id != deleteRequestDTO.CommunityId)
            {
                return ClientErrorResponse();
            }

            communityDTO.CommunityId = id;
            communityDTO.IsActive = deleteRequestDTO.IsActive;

            var result = await _communityServiceCommands.DeleteCommunity(communityDTO);

            if (result == null)
            {
                return ClientErrorResponse();
            }

            if (result.ResultMessage == "Server Error")
            {
                return ServerErrorResponse();
            }

            var response = new DeleteResponseDTO()
            {
                CommunityId = id,
                Active = deleteRequestDTO.IsActive
            };

            return Ok(response);
        }
    }
}