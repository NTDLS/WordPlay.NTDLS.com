using Dapper;
using WordPlay.Shared.Models;
using WordPlay.Shared.Repository.VPS.Library.ADORepository;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WordPlay.Shared.Repository
{
    public static class ConfigurationRepository
    {
        public static List<ConfigurationEntry> GetConfigurationEntriesByGroup(string groupName)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<ConfigurationEntry>("GetConfigurationEntriesByGroup",
                    new { GroupName = groupName },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }
    }
}
