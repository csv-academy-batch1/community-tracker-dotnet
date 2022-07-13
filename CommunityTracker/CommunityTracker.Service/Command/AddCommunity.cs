using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        public void Add(CommunityDTO communityDTO)
        {
            _communityRepositoryCommands.AddCommunity(new Community()
            {
                communityid = communityDTO.communityid,
                communityname = communityDTO.communityname,
                communitydesc = communityDTO.communitydesc,
                communitymgrid = communityDTO.communitymgrid,
                communityicon = communityDTO.communityicon,
                isactive = communityDTO.isactive
            });
        }
    }
}