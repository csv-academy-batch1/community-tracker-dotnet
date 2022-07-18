using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityTracker.Test.Queries
{
    [TestClass]
    public class GetAllCommunityServiceTests : CommunityTrackerBaseTest
    {
        [TestMethod]
        public async Task HappyPath_GetAllCommunityServiceTests_SuccessAsync()
        {
            //Arrange
            var mockDatabase = CreateCommunityDatabaseAsync();

            //Act
            var communities = await _serviceQueries.GetAllCommunities();

            //Assert
            communities.Count().Should().Be(3);
        }
    }
}