using Dapper;
using WordPlay.Shared.Models;
using WordPlay.Shared.Repository.VPS.Library.ADORepository;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace WordPlay.Shared.Repository
{
    public static class WordRepository
    {
        public static List<Translate> Translate(string word)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<Translate>("Translate",
                    new { Word = word },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }

        public static List<BasicWord> BrowseWords(string word)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<BasicWord>("BrowseWords",
                    new { Word = word },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }

        public static List<BasicWord> SoundsLikeDoubleMetaphone(string word)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<BasicWord>("SoundsLike_DoubleMetaphone",
                    new { Word = word },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }
        public static List<BasicWord> SoundsLikeMetaphone(string word)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<BasicWord>("SoundsLike_Metaphone",
                    new { Word = word },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }
        public static List<BasicWord> SoundsLikeSoundEx(string word)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<BasicWord>("SoundsLike_SoundEx",
                    new { Word = word },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }

        public static List<Synonym> Synonyms(string word)
        {
            using (var handler = new SqlConnectionHandler())
            {
                return handler.Connection.Query<Synonym>("Synonyms",
                    new { Word = word },
                    null, true, RepositorySingletons.CommandTimeout, CommandType.StoredProcedure).ToList();
            }
        }
    }
}
