using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Npgsql;

namespace CadastroProdutosCervantes.Data
{
    public static class Database
    {
        public static NpgsqlConnection GetConnection()
        {
            string connectionString =
                ConfigurationManager
                    .ConnectionStrings["PostgresConnection"]
                    .ConnectionString;

            return new NpgsqlConnection(connectionString);
        }
    }
}
