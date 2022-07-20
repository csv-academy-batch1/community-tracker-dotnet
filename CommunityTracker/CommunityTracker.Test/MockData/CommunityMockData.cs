using CommunityTracker.Repository.DataContext;
using CommunityTracker.Repository.RepositoryDTO;
using System.Threading.Tasks;

namespace CommunityTracker.Test.MockData
{
    public static class CommunityMockData
    {
        public static async Task PopulateCommunityAsync(CommunityDbContext context)
        {
            int index = 1;

            while (index <= 3)
            {
                var communityData = new Community
                {
                    CommunityId = index,
                    CommunityName = $"TestCommunityName{index}",
                    CommunityMgrid = 6,
                    CommunityDesc = "Enterprise .NET Community leverages the combined community knowledge using " +
                        ".NET Core and .NET 5, as well as tools and frameworks to deliver excellent quality for our partners."
                };

                index++;
                await context.community.AddAsync(communityData);
            }

            await context.SaveChangesAsync();
        }
        public static async Task PopulateCommunityManagersAsync(CommunityDbContext context)
        {
            int index = 1;

            while (index <= 10)
            {
                var communityManager = new CommunityManagers
                {
                    CommunityAdminAndManagerId = index,
                    CommunityAdminAndManagerName = $"TestCommunityManager{index}",
                    CSVEmail = $"manager@{index}",
                    PassKey = "Passkey",
                    RoleType = "TestType",
                    IsActive = true,
                };

                index++;
                await context.communityadminandmanager.AddAsync(communityManager);
            }

            await context.SaveChangesAsync();
        }
    }
}