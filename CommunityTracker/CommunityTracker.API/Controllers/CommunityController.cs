using CommunityTracker.API.Controllers.NewFolder;
using CommunityTracker.Service;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServiceDTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommunityTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly ICommunityServiceCommands _communityServiceCommands;
        public CommunityController(ICommunityServiceCommands communityServiceCommands)
        {
            this._communityServiceCommands = communityServiceCommands;

        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddRequestDTO addRequestDTO)
        {
            var itemDTO = new ServiceCommunityDTO();
            itemDTO.communityid = addRequestDTO.communityid;
            itemDTO.communityname = addRequestDTO.communityname;
            itemDTO.communityicon = addRequestDTO.communityicon;
            itemDTO.communitymgrid = addRequestDTO.communitymgrid;
            itemDTO.communitydesc = addRequestDTO.communitydesc;
            this._communityServiceCommands.Add(itemDTO);
            return Ok();

        }
    }
}
