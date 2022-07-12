using CommunityTracker.Model;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
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
            _communityServiceCommands = communityServiceCommands;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost("ValuesController")]
        public IActionResult Post([FromBody] CreateCommunityBindingModel createCommunityBindingModel)
        {
            var communityDTO = new CommunityDTO();
            communityDTO.communityid = createCommunityBindingModel.communityid;
            communityDTO.communityname = createCommunityBindingModel.communityname;
            communityDTO.communityicon = createCommunityBindingModel.communityicon;
            communityDTO.communitymgrid = createCommunityBindingModel.communitymgrid;
            communityDTO.communitydesc = createCommunityBindingModel.communitydesc;
            communityDTO.isactive = createCommunityBindingModel.isactive;
            _communityServiceCommands.Add(communityDTO);
            return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
