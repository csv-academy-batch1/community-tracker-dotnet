using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.ServicesDTO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityTracker.Test.Commands
{
    [TestClass]
    public class UpdateCommunityTests : CommunityTrackerBaseTest
    {
        [TestMethod]
        public async Task UpdatingCommunityName_Success()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.UpdateCommunity(new CommunityDTO()
            {
                CommunityId = 2,
                CommunityName = "Enterprise .Net",
                CommunityMgrid = 10,
                CommunityDesc = "Success - Should be able to update community details based on ID."
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var addedCommunity = communities.FirstOrDefault(x => x.communityid == 2);

            //Assert
            communities.Should().NotBeEmpty();
            communities.Count().Should().Be(3);
            communities.Should().OnlyHaveUniqueItems(i => i.communityname);
            community.CommunityName.Should().Be(addedCommunity.communityname);
        }

        //Endpoint Validation
        [TestMethod]
        public async Task UpdatingCommunityNameWithNonExistingManagerId_ReturnFailedMessage()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.UpdateCommunity(new CommunityDTO()
            {
                CommunityId = 2,
                CommunityName = "Update Community",
                CommunityMgrid = 15,
                CommunityDesc = "Return Failed Message - When I input a managerId that does not exist in the table and click submit."
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var addedCommunity = communities.FirstOrDefault(x => x.communityid == 2);

            //Assert
            communities.Should().NotBeEmpty();
            communities.Count().Should().Be(3);
            communities.Should().OnlyHaveUniqueItems(i => i.communityname);
            //community.CommunityName.Should().Be("TestCommunityName2");
            addedCommunity.communityname.Should().Be("TestCommunityName2");
        }
    }
}