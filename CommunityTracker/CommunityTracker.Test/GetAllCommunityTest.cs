using CommunityTracker.API.Controllers;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.ServicesDTO;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityTracker.Test
{
    [TestClass]
    public class GetAllCommunityTest : CommunityTrackerBaseTest
    {
        [TestMethod]
        public void GetAllCommunityController_ReturnsAllCommunityIdAndName()
        {
            //Arrange
            var mockCommunityRepositoryCommands = new Mock<ICommunityRepositoryCommands>();
            var mockCommunityRepositoryQuery = new Mock<ICommunityRepositoryQuery>();
            var mockCommunityServiceCommands = new Mock<ICommunityServiceCommands>();
            var mockCommunityServiceQuery = new Mock<ICommunityServiceQuery>();
            var sut = new CommunityServiceCommands(mockCommunityRepositoryCommands.Object, mockCommunityRepositoryQuery.Object);
            var sut2 = new CommunityController(mockCommunityServiceCommands.Object, mockCommunityServiceQuery.Object);
            var mockData = GetAllCommunityFakeData();
            //Act
            var results = sut2.GetAll();
            var count = results.mockData;
            //Assert
            results.Should().NotBeNull();
            

        }
        //[TestMethod]
        public void SadPath_TestGetCommunityController()
        {
            //Arrange
            //Act
            //Assert
        }
        public IEnumerable<CommunityDTOResponse> GetAllCommunityFakeData()
        {
            var communities = new List<CommunityDTOResponse>()
            {
                new CommunityDTOResponse()
                {
                    communityid = 1,
                    communityname = "Enterprise .NET"
                },
                new CommunityDTOResponse()
                {
                    communityid = 2,
                    communityname = "JAVA"
                },
                new CommunityDTOResponse()
                {
                    communityid = 3,
                    communityname = "QE"
                },
                new CommunityDTOResponse()
                {
                    communityid = 4,
                    communityname = "Mobile"
                }
            };
            return communities;
        }
    }
}
