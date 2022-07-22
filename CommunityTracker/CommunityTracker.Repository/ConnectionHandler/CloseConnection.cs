using Npgsql;

namespace CommunityTracker.Repository.ConnectionHandler
{
    /// <summary>
    ///
    /// </summary>
    public static class CloseConnection
    {
        /// <summary>
        /// Disposes the connection.
        /// </summary>
        public static void DisposeConnection()
        {
            NpgsqlConnection.ClearAllPools();
        }
    }
}