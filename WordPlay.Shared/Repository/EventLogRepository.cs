using Dapper;
using WordPlay.Shared.Repository.VPS.Library.ADORepository;
using System.Data;

namespace WordPlay.Shared.Repository
{
    public static class EventLogRepository
    {
        public static void WriteEventLog(string text)
        {
            using (var handler = new SqlConnectionHandler())
            {
                handler.Connection.Execute("WriteEventLog",
                    new { Text = text },
                    null, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure);
            }
        }
    }
}
