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
        public async Task UpdateCommunityService_HappyPath()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var expected = new CommunityDTO()
            {
                CommunityId = 1,
                CommunityName = "Java",
                CommunityMgrid = 9,
                CommunityDesc = "Update Desc Happy Path"
            };
            var community = await _serviceCommands.UpdateCommunity(expected);

            //Assert
            var actualCommunities = await _serviceQueries.GetAllCommunities();
            var actual = actualCommunities.Where(x => x.communityid == 1).FirstOrDefault();
            actual.communityname.Should().Be(expected.CommunityName);
        }

    }
}