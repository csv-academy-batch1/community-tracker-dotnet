using CommunityTracker.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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