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
                CommunityDesc = "Update Desc"
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var addedCommunity = communities.FirstOrDefault(x => x.communityid == 2);

            //Assert
            communities.Should().NotBeEmpty();
            communities.Count().Should().Be(3);
            communities.Should().OnlyHaveUniqueItems(i => i.communityname);
            community.CommunityName.Should().Be(addedCommunity.communityname);
        }
    }
}