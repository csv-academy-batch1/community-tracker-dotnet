using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
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
        //TODO: Create constructor to initialize repository and pass the connectionString

        private readonly ICommunityRepositoryCommands _communityRepositoryCommands;

        public CommunityServiceCommands(ICommunityRepositoryCommands communityRepositoryCommands)
        {
            _communityRepositoryCommands = communityRepositoryCommands;
        }
        public void Add(ItemDTO itemDTO)
        {
            _communityRepositoryCommands.Save(new EntityTable()
            {
                Id = itemDTO.Id,
                CommunityName = itemDTO.CommunityName,
                CommunityManager = itemDTO.CommunityManager,
                CommunityDescription = itemDTO.CommunityDescription
            });
        }
    }
}
