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
        public async Task AddingUniqueCommunityName_Success()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.AddCommunity(new CommunityDTO()
            {
                CommunityName = "Enterprise .Net",
                CommunityMgrid = 10,
                CommunityDesc = "Test_Success"
            });

            var communities = await _serviceQueries.GetAllCommunities();
            var addedCommunity = communities
                .Where(x => x.communityid == 4).First();
            
            //Assert
            community.isActive.Should().BeTrue();
            addedCommunity.communityname.Should().Be(community.CommunityName);
            addedCommunity.communityid.Should().Be(community.CommunityId);
            addedCommunity.communityid.Should().Be(4);
            addedCommunity.communitydescription.Should().Be(community.CommunityDesc);
            communities.Should().NotBeEmpty();
            communities.Count().Should().Be(4);
            communities.Should().OnlyHaveUniqueItems(i => i.communityname);
        }

        [TestMethod]
        public async Task AddingDuplicateCommunityName_ShouldReturnFailedMessage()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var community = await _serviceCommands.AddCommunity(new CommunityDTO()
            {
                CommunityName = "TestCommunityName1",
                CommunityMgrid = 10,
                CommunityDesc = "Return Failed Message"
            });

            var communities = await _serviceQueries.GetAllCommunities();

            //Assert
            communities.Count().Should().Be(3);
        }
    }
}