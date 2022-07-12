using CommunityTracker.API.TrackerApiDTO;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace CommunityTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityServiceCommands _communityServiceCommands;
        public CommunityController(ICommunityServiceCommands communityServiceCommands)
        {
            _communityServiceCommands = communityServiceCommands;
        }
        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] AddRequestDTO apiDTO)
        {
            var communityDTO = new CommunityDTO();
            communityDTO.communityname = apiDTO.communityname;
            communityDTO.communitymgrid = apiDTO.communitymgrid;
            communityDTO.communitydesc = apiDTO.communitydesc;
            _communityServiceCommands.Add(communityDTO);
            return Ok();
        }
    }
}