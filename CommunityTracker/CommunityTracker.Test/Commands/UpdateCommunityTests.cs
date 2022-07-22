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
           
//            //Act
//            var community = await _serviceCommands.UpdateCommunity(new CommunityDTO()
//            {
//                CommunityId = 2,
//                CommunityName = "Enterprise .Net",
//                CommunityMgrid = 10,
//                CommunityDesc = "Update Desc"
//            });

            //Act
            var community = await _serviceCommands.UpdateCommunity(new CommunityDTO()
            {
                CommunityId = 2,
                CommunityName = "Enterprise .Net",
                CommunityMgrid = 10,
                CommunityDesc = "Update Desc"
            });

            var afterUpdate = await _serviceQueries.GetAllCommunities();
            var updatedCommunity = afterUpdate.FirstOrDefault(x => x.communityid == 2);

            //Assert
            community.CommunityId.Should().Be(updatedCommunity.communityid);
            community.CommunityName.Should().Be(updatedCommunity.communityname);
            afterUpdate.Should().NotBeEmpty();
            afterUpdate.Count().Should().Be(3);
            afterUpdate.Should().OnlyHaveUniqueItems(i => i.communityname);
            community.CommunityName.Should().Be(updatedCommunity.communityname);
        }

        [TestMethod]
        public async Task UpdatingCommunityName_Fail()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();


            //Act
            int id = 2;
            var community = await _serviceCommands.UpdateCommunity(new CommunityDTO()
            {
                CommunityId = 2,
                CommunityName = $"TestCommunityName{id}",
                CommunityMgrid = 10,
                CommunityDesc = "Update Desc"
            });

            var afterUpdate = await _serviceQueries.GetAllCommunities();
            var updatedCommunity = afterUpdate.FirstOrDefault(x => x.communityid == 2);

            //Assert
            afterUpdate.Should().NotBeEmpty();
            afterUpdate.Count().Should().Be(3);
            afterUpdate.Should().OnlyHaveUniqueItems(i => i.communityname);
        }
    }
}