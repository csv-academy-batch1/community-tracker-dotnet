using CommunityTracker.API.Exceptions;
using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
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
        public IActionResult GetAll()
        {
            var items = this._communityServiceQuery.GetAllCommunities();
            return Ok(items);
        }
        [HttpGet("managers")]
        public IActionResult GetAllManagers()
        {
            var items = this._communityServiceQuery.GetAllCommunityManagers();
            return Ok(items);
        }
        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult AddCommunity([FromBody] AddRequestDTO apiDTO)
        {
            var communityDTO = new CommunityDTO();
            communityDTO.communityname = apiDTO.communityname;
            communityDTO.communitymgrid = apiDTO.communitymgrid;
            communityDTO.communitydesc = apiDTO.communitydesc;
            var response = _communityServiceCommands.AddCommunityService(communityDTO);
            if (response is null)
            {
                return BadRequest(new CustomErrors() {
                    result = new Result()
                });
            } 
            var res = new AddResponseDTO()
            {
                CommunityId = response.communityid,
                CommunityName = response.communityname,
                CommunityManager = response.communitymanagername,
                Description = response.communitydesc
            };
            return Ok(res);
        }
    }
}