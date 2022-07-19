using CommunityTracker.API.Exceptions;
using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.Service.ServicesDTO;
using CommunityTracker.Service.Interfaces;
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
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _communityServiceQuery.GetAllCommunities();
            return Ok(items);
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
                CommunityMgrid = request.CommunityManager,
                CommunityDesc = request.Description
            };

            var result = await _communityServiceCommands.AddCommunity(communityDTO);
            
            if (result == null)
            {
                return BadRequest(new CustomErrors()
                {
                    result = new Result()
                });
            }

            var response = new ResponseDTO()
            {
                CommunityId = result.CommunityId,
                CommunityName = result.CommunityName,
                CommunityManager = result.CommunityManagerName,
                Description = result.CommunityDesc
            };

            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCommunity([FromBody] UpdateRequestDTO updateRequestDTO)
        {
            var community = new CommunityDTO();

            community.CommunityId = updateRequestDTO.communityid;
            community.CommunityName = updateRequestDTO.communityname;
            community.CommunityMgrid = updateRequestDTO.communitymgrid;
            community.CommunityDesc = updateRequestDTO.communitydesc;

            var result = await this._communityServiceCommands.UpdateCommunity(community);

            if (result == null)
            {
                return BadRequest(new CustomErrors()
                {
                    result = new Result()
                });
            }

            var response = new ResponseDTO()
            {
                CommunityId = result.CommunityId,
                CommunityName = result.CommunityName,
                CommunityManager = result.CommunityManagerName,
                Description = result.CommunityDesc,
                IsActive = result.IsActive
            };

            return Ok(response);
        }
    }
}