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
        public async Task UpdatingCommunity_Success()
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

            var afterUpdate = await _serviceQueries.GetAllCommunities();
            var updatedCommunity = afterUpdate.FirstOrDefault(x => x.CommunityId == 2);

            //Assert
            community.CommunityId.Should().Be(updatedCommunity.CommunityId);
            community.CommunityName.Should().Be(updatedCommunity.CommunityName);
            afterUpdate.Should().NotBeEmpty();
            afterUpdate.Count().Should().Be(3);
            afterUpdate.Should().OnlyHaveUniqueItems(i => i.CommunityName);
            community.CommunityName.Should().Be(updatedCommunity.CommunityName);
        }

        //Endpoint Validation
        [TestMethod]
        public async Task UpdatingCommunityWithNonExistingManagerId_ReturnFailedMessage()
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
            var updatedCommunity = communities.FirstOrDefault(x => x.CommunityId == 2);

            //Assert
            communities.Should().NotBeEmpty();
            communities.Count().Should().Be(3);
            communities.Should().OnlyHaveUniqueItems(i => i.CommunityName);
            updatedCommunity.CommunityName.Should().Be("TestCommunityName2");
        }
    }
}