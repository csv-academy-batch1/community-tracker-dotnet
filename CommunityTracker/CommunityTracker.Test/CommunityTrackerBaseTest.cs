using CommunityTracker.Repository.Command;
using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.Interfaces;
using CommunityTracker.Repository.Query;
using CommunityTracker.Service.Command;
using CommunityTracker.Service.Interfaces;
using CommunityTracker.Service.Query;
using CommunityTracker.Test.MockData;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace CommunityTracker.Test
{
    [TestClass]
    public class CommunityTrackerBaseTest
    {
        public ICommunityRepositoryCommands _repoCommands;
        public ICommunityRepositoryQuery _repoQueries;
        public ICommunityServiceCommands _serviceCommands;
        public ICommunityServiceQuery _serviceQueries;
        public DbContextOptions<CommunityDbContext> _dbContextOptions;
        public string dbName;

        [TestInitialize]
        public void TestInitialize()
        {
            dbName = $"CommunityTrackerPostsDb_{DateTime.Now.ToFileTimeUtc()}";
            _dbContextOptions = new DbContextOptionsBuilder<CommunityDbContext>()
                .UseInMemoryDatabase(dbName)
                .Options;

            var communityContext = new CommunityDbContext(_dbContextOptions);

            _repoCommands = new CommunityRepositoryCommands(communityContext);
            _repoQueries = new CommunityRepositoryQuery(communityContext);

            _serviceCommands = new CommunityServiceCommands(_repoCommands, _repoQueries);
            _serviceQueries = new CommunityServiceQuery(_repoQueries);
        }

        public async Task<CommunityRepositoryCommands> CreateCommunityDatabaseAsync()
        {
            CommunityDbContext context = new CommunityDbContext(_dbContextOptions);
            await CommunityMockData.PopulateCommunityAsync(context);
            return new CommunityRepositoryCommands(context);
        }
    }
}