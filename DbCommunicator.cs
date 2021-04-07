using System;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace WishList
{
    class DbCommunicator
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
                       System.IO.Path.GetFullPath("DbItemsFromSheet.mdf") + ";Integrated Security=True;MultipleActiveResultSets=True";
        private SqlConnection sqlConnection;

        public static readonly DbCommunicator Communicator = new DbCommunicator(connectionString);

        private DbCommunicator(string _connectionString) 
        {
            sqlConnection = new SqlConnection(_connectionString);
        }
        
        public void OpenConnection() 
        {
            sqlConnection.Open();
        }

        private SqlCommand createCommand(string procedureName)
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                return null;
            }
            SqlCommand command = new SqlCommand(procedureName, sqlConnection);
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        public async Task<List<DataItem>> ReadAllItems()
        {
            var items = new List<DataItem>();
            var command = createCommand("SelectAllItems");
            if (command == null)
            {
                return items;
            }

            SqlDataReader reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                items.Add(new DataItem()
                {
                    Id = Int32.Parse(reader["Id"].ToString()),
                    Name = reader["Name"].ToString(),
                    MinPrice = Double.Parse(reader["MinPrice"].ToString()),
                    MaxPrice = Double.Parse(reader["MaxPrice"].ToString()),
                    Realization = Convert.ToBoolean(reader["Realization"])
                });
            }

            reader.Close();
            return items;
        }


        public async Task<bool> AddItem(DataItem newItem) 
        {
            var command = createCommand("AddItem");
            if (command == null)
            {
                return false;
            }

            command.Parameters.Add(new SqlParameter("@Name", newItem.Name));
            command.Parameters.Add(new SqlParameter("@MinPrice", newItem.MinPrice));
            command.Parameters.Add(new SqlParameter("@MaxPrice", newItem.MaxPrice));
            SqlDataReader reader = await command.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                newItem.Id = Int32.Parse(reader["Id"].ToString());
            }

            reader.Close();
            return true;
        }
    
        public async void ChangeItemRealization(int id) 
        {
            var command = createCommand("RealizationChange");
            if (command == null)
            {
                return;
            }

            command.Parameters.Add(new SqlParameter("@Id", id));
            SqlDataReader reader = await command.ExecuteReaderAsync();
            reader.Close();   
        }
        
        public async void SubtractItem(int id) 
        {
            var command = createCommand("SubtractItem");
            if (command == null)
            {
                return;
            }

            command.Parameters.Add(new SqlParameter("@Id", id));
            await command.ExecuteNonQueryAsync();
        }
    }
}
