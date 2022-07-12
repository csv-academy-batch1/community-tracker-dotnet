using CommunityTracker.Model;
using CommunityTracker.Service;
using CommunityTracker.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CommunityTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
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
        
        //public void Post([FromBody] string value)
        //{
        //}

        private readonly ICommunityServiceCommands _communityServiceCommands;
        public CommunityController(ICommunityServiceCommands communityService)
        {
            this._communityServiceCommands = communityService;

        }
        [HttpPost]
        public IActionResult Post([FromBody] CommunityTrackerModel communityTrackerModel)
        {
            var itemDTO = new ItemDTO();
            itemDTO.Id = communityTrackerModel.Id;
            itemDTO.CommunityName = communityTrackerModel.CommunityName;
            itemDTO.CommunityManager = communityTrackerModel.CommunityManager;
            itemDTO.CommunityDescription = communityTrackerModel.CommunityDescription;
            this._communityServiceCommands.Add(itemDTO);
            return Ok();

        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
