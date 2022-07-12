using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.Entities;

namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        private readonly ICommunityRepositoryCommands _communityRepositoryCommands;

        //TODO: Create constructor to initialize repository and pass the connectionString

        public CommunityServiceCommands(ICommunityRepositoryCommands communityRepositoryCommands)
        {
            _communityRepositoryCommands = communityRepositoryCommands;
        }
        public void Add(CommunityDTO communityDTO)
        {
            _communityRepositoryCommands.AddCommunity(new CommunityData()
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
