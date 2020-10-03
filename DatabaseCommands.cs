using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lister {
    class DatabaseCommands {
        //Data
        private static string path = "Data Source=Database_Lister.db;Version=3;";
        private string table = InitGetTable();

        //Works Classes
        public static void Add(string name, string status) {
            DatabaseCommands databaseCommands = new DatabaseCommands();
            var cmd = databaseCommands.Connection().CreateCommand();
            cmd.CommandText = $"Insert into {databaseCommands.table} (WorkName, Status) Values (@name, @status)";
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.ExecuteNonQuery();
            databaseCommands.Connection().Close();
        }
        public void Edit(int key, string name, string status) {
            var cmd = Connection().CreateCommand();
            cmd.CommandText = $"Update {table} Set WorkName='{name}', Status='{status}' where Key='{key}'";
            cmd.ExecuteNonQuery();
            Connection().Close();
        }
        public DataTable SearchInDatabase(string command) {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, Connection());
            adapter.Fill(dataTable);
            Connection().Close();
            return dataTable;
        }
        //Tables Classes
        public bool AddTable(string name) {
            var cmd = Connection().CreateCommand();
            cmd.CommandText = $"Create Table {name} ([Key] INTEGER PRIMARY KEY AUTOINCREMENT, WorkName VARCHAR,Status VARCHAR);";
            try {
                cmd.ExecuteNonQuery(); Connection().Close(); return true;
            }
            catch {
                return false;
            }
        }
        public void RemoveTable(string name) {
            var cmd = Connection().CreateCommand();
            cmd.CommandText = $"Drop Table {name}";
            cmd.ExecuteNonQuery();
            Connection().Close();
            if (table == name) {
                DataTable dataTable = new DataTable();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * from sqlite_master;", Connection());
                adapter.Fill(dataTable);
                foreach (DataRow i in dataTable.Rows) {
                    if (i.Field<string>("name")!="Options" & i.Field<string>("name") != "sqlite_sequence") {
                        cmd.CommandText = $"Update Options Set Value='{dataTable.Rows.IndexOf(i)}' where Name='LastTable';";
                        cmd.ExecuteNonQuery();
                        table = InitGetTable();
                        break;
                    }
                }
            }
        }
        public void EditTable(string name, string newName) {
            var cmd = Connection().CreateCommand();
            cmd.CommandText = $"Alter Table {name} Rename to {newName};";
            cmd.ExecuteNonQuery();
            Connection().Close();
        }
        public void DefineAsMainTable(string name) {
            DataTable dataTable = new DataTable();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * from sqlite_master", Connection());
            adapter.Fill(dataTable);
            foreach (DataRow i in dataTable.Rows) {
                if (i.Field<string>("name")==name) {
                    var cmd = Connection().CreateCommand();
                    cmd.CommandText = $"Update Options Set Value='{dataTable.Rows.IndexOf(i)}' where Name='LastTable';";
                    cmd.ExecuteNonQuery();
                    table = name;
                }
            }
            Connection().Close();
        }
        public string GetTable() {
            return table;
        }
        //Private Classes
        private SQLiteConnection Connection() {
            SQLiteConnection sQLiteConnection = new SQLiteConnection(path);
            sQLiteConnection.Open();
            return sQLiteConnection;
        }
        private static string InitGetTable() {
        init:
            if (System.IO.File.Exists("Database_Lister.db")) {
                SQLiteConnection sQLiteConnection = new SQLiteConnection(path);
                DataTable dataTable = new DataTable();
                sQLiteConnection.Open();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * from Options where name = 'LastTable'", sQLiteConnection);
                adapter.Fill(dataTable);
                int a = int.Parse(dataTable.Rows[0].Field<string>("Value").ToString());
                dataTable = new DataTable();
                adapter = new SQLiteDataAdapter("Select * from sqlite_master", sQLiteConnection);
                adapter.Fill(dataTable);
                sQLiteConnection.Close();
                return dataTable.Rows[a].Field<string>("name").ToString();
            }
            else {
                SQLiteConnection.CreateFile("Database_Lister.db");
                SQLiteConnection connection = new SQLiteConnection(path);
                connection.Open();
                var cmd = connection.CreateCommand();
                cmd.CommandText = "Create Table Séries ([Key] INTEGER PRIMARY KEY AUTOINCREMENT, WorkName VARCHAR,Status VARCHAR);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Create Table Options (Name varchar, Value varchar);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Insert into Options (Name, Value) values (@Name, @Value);";
                cmd.Parameters.AddWithValue("@Name", "LastTable");
                cmd.Parameters.AddWithValue("@Value", 0);
                cmd.ExecuteNonQuery();
                connection.Close();
                goto init;
            }
        }
    }
}