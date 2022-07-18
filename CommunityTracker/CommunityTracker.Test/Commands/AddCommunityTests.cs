using CommunityTracker.Repository.Entities;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.DTO;
using CommunityTracker.Service.Interfaces;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace CommunityTracker.Test.Commands
{
    [TestClass]
    public class AddCommunityServiceTests : CommunityTrackerBaseTest
    {
        [TestMethod]
        public void HappyPath_TestAddCommunityService_AddingDuplicateValueInCommunityName()
        {
            //Arrange
            var mockDataBase = CreateCommunityDatabaseAsync();

            //Act
            var community = _serviceCommands.AddCommunityService(new CommunityDTO()
            {
                communityname = "Enterprise .NET",
                communitymgrid = 10,
                communitydesc = "Description"
            });

            var community2 = _serviceQueries.GetAllCommunities();
            //Assert
            community2.Count().Should().Be(4);
            
        }

        [TestMethod]
        public void SadPath_TestAddCommunityService_AddingDuplicateValueInCommunityName()
        {
            // Arrange
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
        }
    }
}