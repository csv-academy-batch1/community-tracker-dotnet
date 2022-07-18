using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.DTO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityTracker.Test.Commands
{
    [TestClass]
    public class AddCommunityServiceTests : CommunityTrackerBaseTest
    {
        [TestMethod]
        public async Task HappyPath_TestAddCommunityService_AddingDuplicateValueInCommunityNameAsync()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.AddCommunityService(new CommunityDTO()
            {
                communityname = "Enterprise .Net",
                communitymgrid = 10,
                communitydesc = "Test Desc Happy Path"
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var communityName = communities.Where(x => x.communityid == 4).Select(y => y.communityname).FirstOrDefault();

            //Assert
            communities.Count().Should().Be(4);
            community.communityname.Should().Be(communityName);
        }

        [TestMethod]
        public async Task SadPath_TestAddCommunityService_AddingDuplicateValueInCommunityNameAsync()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.AddCommunityService(new CommunityDTO()
            {
                communityname = "TestCommunityName1",
                communitymgrid = 10,
                communitydesc = "Test Desc Sad Path"
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var communityName = communities.Where(x => x.communityid == 4).Select(y => y.communityname).FirstOrDefault();

            //Assert
            communities.Count().Should().Be(3);
        }
    }
}