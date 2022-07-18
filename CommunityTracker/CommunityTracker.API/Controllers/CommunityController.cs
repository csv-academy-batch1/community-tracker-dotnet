using CommunityTracker.API.Exceptions;
using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.API.TrackerApiDTOs;
using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using Microsoft.AspNetCore.Mvc;

namespace CommunityTracker.API.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityServiceCommands _communityServiceCommands;
        private readonly ICommunityServiceQuery _communityServiceQuery;

        public CommunityController(ICommunityServiceCommands communityServiceCommands, ICommunityServiceQuery communityServiceQuery)
        {
            _communityServiceCommands = communityServiceCommands;
            _communityServiceQuery = communityServiceQuery;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _communityServiceQuery.GetAllCommunities();
            return Ok(items);
        }

        [HttpGet("managers")]
        public async Task<IActionResult> GetAllManagers()
        {
            var items = await _communityServiceQuery.GetAllCommunityManagers();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> AddCommunity([FromBody] AddRequestDTO apiDTO)
        {
            var communityDTO = new CommunityDTO();
            communityDTO.communityname = apiDTO.CommunityName;
            communityDTO.communitymgrid = apiDTO.CommunityManager;
            communityDTO.communitydesc = apiDTO.Description;
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
                CommunityId = result.communityid,
                CommunityName = result.communityname,
                CommunityManager = result.communitymanagername,
                Description = result.communitydesc
            };
            return Ok(response);
        }

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