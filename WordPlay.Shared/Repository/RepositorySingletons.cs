using System.Configuration;

namespace WordPlay.Shared.Repository
{
    public static class RepositorySingletons
    {
        public static int CommandTimeout { get; private set; } = 60;

        private static string connectionString = null;
        public static string ConnectionString
        {
            get
            {
                if (connectionString == null)
                {
                    connectionString = ConfigurationManager.ConnectionStrings["WordPlaySyncServiceADO"].ConnectionString;
                }
                return connectionString;
            }
        }
    }
}
