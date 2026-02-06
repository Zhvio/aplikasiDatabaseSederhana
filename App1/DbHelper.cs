using FastReport.Table;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace App1
{
    public static class DbHelper
    {
        public static string Username = "USER1";
        public static string Password = "123";
        public static string Location = @"D:\Data\TEST.FDB";
        public static string Role = "KARYAWAN";
        public static string BackupFolder = @"D:\Data\Backup\";
        public static string SelectedTable = "";
        public static FbConnection GetConnection()
        {
            string connString =
               $"User={Username};" +
               $"Password={Password};" +
               $"Database={Location};" +
               $"Role={Role};" +
               "DataSource=localhost;" +
               "Port=3050;" +
               "Dialect=3;" +
               "Charset=UTF8;";

            return new FbConnection(connString);
        }

        public static async Task<bool> IsTableExists(string tableName)
        {
            if (string.IsNullOrEmpty(tableName)) { return false; }

            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                string sql = "SELECT COUNT(*) FROM RDB$RELATIONS WHERE RDB$RELATION_NAME = @name";
                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", tableName.ToUpper());
                    int count = Convert.ToInt32(await cmd.ExecuteScalarAsync());
                    return count > 0;
                }
            }
        }

        public static async Task<List<string>> GetAllTables()
        {
            List<string> tables = new List<string>();
            using (var conn = GetConnection())
            {
                await conn.OpenAsync();
                string sql = "SELECT RDB$RELATION_NAME FROM RDB$RELATIONS WHERE RDB$SYSTEM_FLAG = 0";
                using (var cmd = new FbCommand(sql, conn))
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        tables.Add(reader["RDB$RELATION_NAME"].ToString().Trim());
                    }
                }
            }
            return tables;
        }

        public static async Task<DataTable> GetDataTableAsync()
        {
            DataTable dt = new DataTable();
            string sql = $"SELECT * FROM {SelectedTable}";
            using (FbConnection conn = GetConnection())
            {
                await conn.OpenAsync();

                using (var da = new FbDataAdapter(sql, conn))
                {
                    await Task.Run(() => da.Fill(dt));
                }
            }
            return dt;
        }

        public static void CreateNewDatabase(string fullPath)
        {
            FbConnectionStringBuilder csb = new FbConnectionStringBuilder();
            csb.Database = fullPath;
            csb.UserID = Username;
            csb.Password = Password;
            csb.ServerType = FbServerType.Default;
            csb.DataSource = "localhost";
            csb.Port = 3050;
            FbConnection.CreateDatabase(csb.ToString(), pageSize: 8192, forcedWrites: true, overwrite: false);
        }

        public static void CreateTable(string TableName)
        {
            using (FbConnection conn = GetConnection())
            {
                conn.Open();
                string sql = $"CREATE TABLE {TableName} (ID INTEGER PRIMARY KEY, NAMA VARCHAR(50), JUMLAH INTEGER, HARGA INTEGER)";

                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteTableFromDatabase()
        {
            using (FbConnection conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = $"DROP TABLE {SelectedTable}";

                using (FbCommand cmd = new FbCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static async Task<bool> TryLoginAsync(string user, string pass)
        {
            string connectionString = 
               $"User={user};" +
               $"Password={pass};" +
               $"Database={Location};" +
               $"Role={Role};" +
               "DataSource=localhost;" +
               "Port=3050;" +
               "Dialect=3;" +
               "Charset=UTF8;";
               
            using (var conn = new FbConnection(connectionString))
            {
                try
                {
                    await conn.OpenAsync();

                    Username = user;
                    Password = pass;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
