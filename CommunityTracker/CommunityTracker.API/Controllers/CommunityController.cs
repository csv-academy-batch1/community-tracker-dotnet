using CommunityTracker.API.Exceptions;
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
        
        private readonly ICommunityMembersService _communityMembersService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommunityController"/> class.
        /// </summary>
        /// <param name="communityServiceCommands">The community service commands.</param>
        /// <param name="communityServiceQuery">The community service query.</param>
        public CommunityController(ICommunityServiceCommands communityServiceCommands, ICommunityServiceQueries communityServiceQuery, ICommunityMembersService communityMembersService)
        {
            _communityServiceCommands = communityServiceCommands;
            _communityServiceQuery = communityServiceQuery;
            _communityMembersService = communityMembersService;
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


        [HttpGet("members")]
        public async Task<IActionResult> GetAllMembers()
        {
            var response = new GetAllMemberReponse();
            var members = await _communityMembersService.GetAllCommunityMembers();
            var respo = new List<GetAllMembersResponseDTO>();

            if (members == null)
            {
                ObjectResult errorResponsea = ServerErrorResponse();
                return errorResponsea;
            }

            foreach (var community in members)
            {
                respo.Add(new GetAllMembersResponseDTO()
                {
                    PeopleId = community.PeopleId,
                    CommunityId = community.CommunityId,
                    LastName = community.LastName,
                    FirstName = community.FirstName,
                    MiddleName = community.MiddleName,
                    HiredDate = community.HiredDate,
                    JobLevelId = community.JobLevelId,
                    WorkStateId = community.WorkStateId,
                    IsActive = community.IsActive
                });
            }

            response.CommunityMembers = respo;

            return Ok(members);
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

    }
}