using CommunityTracker.API.Controllers;
using CommunityTracker.Test.MockData;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityTracker.Test.Queries
{
    [TestClass]
    public class GetAllCommunitiesControllerTests : CommunityTrackerBaseTest
    {
        [TestMethod]
        public async Task HappyPath_GetAllCommunityController_SuccessAsync()
        {
            //Arrange
            var mockDb = CreateCommunityDatabaseAsync();
            //Act
            //Assert
        }
    }
}
