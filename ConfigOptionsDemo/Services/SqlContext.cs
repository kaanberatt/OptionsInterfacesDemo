using ConfigOptionsDemo.Models;
using Microsoft.Extensions.Options;

namespace ConfigOptionsDemo.Services
{
    public class SqlContext
    {
        private SqlSettings _sqlSettings;
        public SqlContext(IOptions<SqlSettings> options)
        {
            _sqlSettings = options.Value;
        }

        public void InsertSql()
        {
            Console.WriteLine("Sql settings: " + _sqlSettings.SqlServer);
        }
    }
}
