using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using System.Data.SqlClient;

namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public AddCommunityResponseDTO AddCommunityService(CommunityDTO communityDTO)
        {
            var getAllCommunities = new AddCommunityResponseDTO();
            bool communityExists = _communityRepositoryQuery.GetAllCommunities().Any(x => x.communityname == communityDTO.communityname);
            if (communityExists)
            {
                return null;
            }
            _communityRepositoryCommands.AddCommunityRepository(new Community()
            {
                communityid = communityDTO.communityid,
                communityname = communityDTO.communityname,
                communitydesc = communityDTO.communitydesc,
                communitymgrid = communityDTO.communitymgrid,
                communityicon = communityDTO.communityicon,
                isactive = communityDTO.isactive
            });
            getAllCommunities = AddCommunityResponse().Where(c => c.communityname == communityDTO.communityname).FirstOrDefault();
            if (getAllCommunities is null)
            {
                return null;
            }
            return getAllCommunities;
        }
        private IEnumerable<AddCommunityResponseDTO> AddCommunityResponse()
        {
            var getAllManagers = _communityRepositoryQuery.GetAllCommunityManagers();
            var getAllCommunities = _communityRepositoryQuery.GetAllCommunities().Select(x => new AddCommunityResponseDTO()
            {
                communityid = x.communityid,
                communityname = x.communityname,
                communitymanagername = getAllManagers.Where(m => m.communityadminandmanagerid == x.communitymgrid)
                .Select(x => x.communityadminandmanagername).FirstOrDefault(),
                communitydesc = x.communitydesc
            }).ToList();
            return getAllCommunities;
        }
    }
}