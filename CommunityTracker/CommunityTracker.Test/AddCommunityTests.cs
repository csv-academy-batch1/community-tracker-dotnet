using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.RepositoryDTO;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace CommunityTracker.Test
{
    [TestClass]
    public class AddCommunityServiceTests : CommunityTrackerBaseTest
    {
        [TestMethod]
        public void HappyPath_TestAddCommunityService_AddingDuplicateValueInCommunityName()
        {
            //Arrange
            var mockCommunityRepositoryCommands = new Mock<ICommunityRepositoryCommands>();
            var mockCommunityRepositoryQuery = new Mock<ICommunityRepositoryQuery>();
            var sut = new CommunityServiceCommands(mockCommunityRepositoryCommands.Object, mockCommunityRepositoryQuery.Object);
            var communityDTO = new CommunityDTO();
            var mocklistCommunity= new List<CommunityDTO>();
            mocklistCommunity.Add(new CommunityDTO
            {
                communityname = "Enterprise .NET",
                communitymgrid = 10,
                communitydesc = "TestDec"
            });;

            //Act
            var mockAddCommunityService = sut.AddCommunityService(mocklistCommunity.FirstOrDefault());
            //Assert
            //Assert.AreEqual(1, mocklistCommunity.Count());
            Assert.IsNotNull(mockAddCommunityService);
        }
        [TestMethod]
        public void SadPath_TestAddCommunityService_AddingDuplicateValueInCommunityName()
        {
            //Arrange
            var mockCommunityRepositoryCommands = new Mock<ICommunityRepositoryCommands>();
            var mockCommunityRepositoryQuery = new Mock<ICommunityRepositoryQuery>();
            var sut = new CommunityServiceCommands(mockCommunityRepositoryCommands.Object, mockCommunityRepositoryQuery.Object);
            var communityDTO = new CommunityDTO();
            var mocklistCommunity = new List<CommunityDTO>();
            mocklistCommunity.Add(new CommunityDTO
            {
                communityname = null
            });
            //Act
            sut.AddCommunityService(communityDTO);
            //Assert
            Assert.AreEqual(0, mocklistCommunity.Count());
        }
    }
}