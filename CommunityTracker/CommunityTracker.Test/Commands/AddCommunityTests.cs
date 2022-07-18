using CommunityTracker.Service.ServicesDTO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                CommunityName = "Enterprise .Net",
                CommunityMgrid = 10,
                CommunityDesc = "Test Desc Happy Path"
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var communityName = communities.Where(x => x.communityid == 4).Select(y => y.communityname).FirstOrDefault();

            //Assert
            communities.Count().Should().Be(4);
            community.CommunityName.Should().Be(communityName);
        }

        [TestMethod]
        public async Task SadPath_TestAddCommunityService_AddingDuplicateValueInCommunityNameAsync()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.AddCommunityService(new CommunityDTO()
            {
                CommunityName = "TestCommunityName1",
                CommunityMgrid = 10,
                CommunityDesc = "Test Desc Sad Path"
            });

            var communities = await _serviceQueries.GetAllCommunities();

            //Assert
            communities.Count().Should().Be(3);
        }
    }
}