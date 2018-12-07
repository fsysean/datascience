using System;
using System.Collections.Generic;
using System.Text;
using Npgsql.Logging;

namespace Sean.DataScience.Data.NpgSQL
{
    public class PostgreSQLOptions
    {
        public string ConnectionString { get; set; }
        public NpgsqlLogLevel LogLevel { get; set; }
    }
}
