using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace WindowsFormsApp3.domain
{
    public class SqliteConnectionFactory : ConnectionFactory
    {
        public override IDbConnection createConnection(IDictionary<string, string> props)
        {
            var connectionString = props["ConnectionString"];
            return new SQLiteConnection(connectionString);
        }
    }
}