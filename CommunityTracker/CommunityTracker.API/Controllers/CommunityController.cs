using CommunityTracker.API.Exceptions;
using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.Repository.RepositoryDTO;
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
        private readonly ICommunityServiceQuery _communityServiceQuery;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityController"/> class.
        /// </summary>
        /// <param name="communityServiceCommands">The community service commands.</param>
        /// <param name="communityServiceQuery">The community service query.</param>
        public CommunityController(ICommunityServiceCommands communityServiceCommands, ICommunityServiceQuery communityServiceQuery)
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
        /// <param name="apiDTO">The API dto.</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddCommunity([FromBody] AddRequestDTO apiDTO)
        {
            var communityDTO = new CommunityDTO();
            communityDTO.CommunityName = apiDTO.CommunityName;
            communityDTO.CommunityMgrid = apiDTO.CommunityManager;
            communityDTO.CommunityDesc = apiDTO.Description;
            var result = await _communityServiceCommands.AddCommunityService(communityDTO);
            if (result is null)
            {
                return BadRequest(new CustomErrors()
                {
                    result = new Result()
                });
            }
            var response = new AddResponseDTO()
            {
                CommunityId = result.CommunityId,
                CommunityName = result.CommunityName,
                CommunityManager = result.CommunityManagerName,
                Description = result.CommunityDesc
            };
            return Ok(response);
        }

        /// <summary>
        /// Updates the community.
        /// </summary>
        /// <param name="updateRequestDTO">The update request dto.</param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateCommunity([FromBody] UpdateRequestDTO updateRequestDTO)
        {
            var communityDTO = new Community();
            communityDTO.CommunityId = updateRequestDTO.communityid;
            communityDTO.CommunityName = updateRequestDTO.communityname;
            communityDTO.CommunityMgrid = updateRequestDTO.communitymgrid;
            communityDTO.CommunityDesc = updateRequestDTO.communitydesc;
            var result = await _communityServiceCommands.UpdateCommunityService(communityDTO);
            if (result is null)
            {
                return BadRequest(new CustomErrors()
                {
                    result = new Result()
                });
            }
            var response = new UpdateResponseDTO()
            {
                communityid = result.communityid,
                communityname = result.communityname,
                communitymanager = result.communitymanagername,
                communitydesc = result.communitydesc
            };
            return Ok(response);
        }
    }
}