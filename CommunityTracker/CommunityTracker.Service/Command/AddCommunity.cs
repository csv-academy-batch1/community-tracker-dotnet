using CommunityTracker.Repository.Entities;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServiceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Service.Command
{
    public partial class CommunityServiceCommands : ICommunityServiceCommands
    {
        //TODO: Create implementation to call the repository

            public void Add(ServiceCommunityDTO serviceCommunityDTO)
            {
                _communityRepositoryCommands.Save(new Community()
                {
                    communityid = serviceCommunityDTO.communityid,
                    communityname = serviceCommunityDTO.communityname,
                    communityicon = serviceCommunityDTO.communityicon,
                    communitymgrid = serviceCommunityDTO.communitymgrid,
                    communitydesc = serviceCommunityDTO.communitydesc,
                    isactive = serviceCommunityDTO.isactive
                });
            }
        
    }
}
