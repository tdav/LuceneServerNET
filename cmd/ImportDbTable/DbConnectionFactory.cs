﻿using Npgsql;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace ImportDbTable
{
    static class DbConnectionFactory
    {
        static public IDbConnection CreateInstance(DbTypes dbType, string connectionString)
        {
            switch(dbType)
            {
                case DbTypes.SqlServer:
                    return new SqlConnection(connectionString);
                case DbTypes.PostGres:
                    return new NpgsqlConnection(connectionString);
                case DbTypes.Oracle:
                    return new OracleConnection(connectionString);
                case DbTypes.Sqlite:
                    return new SQLiteConnection(connectionString);
                default:
                    throw new Exception($"Unknown DatabaseType: { dbType }");
            }
        }
    }
}
