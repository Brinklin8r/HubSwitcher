using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSwitcher.Data {
    public class DBMaint {
        private readonly SqlConnection _sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HubSwitcher.mdf;Integrated Security = True;");
        private SqlCommand _sqlCommand;
        private SqlDataAdapter _sqlDataAdapter;

        // Create
        public void InsertIntoDB(string[] values) {
            string _queryString = 
                "insert into Connections(ConnectionName,ManagerURL,ManagerPort,SecondaryURL,SecondaryPort,UIN)" +
                " values(@ConnectionName,@ManagerURL,@ManagerPort,@SecondaryURL,@SecondaryPort,@UIN)";

            _sqlCommand = new SqlCommand(_queryString, _sqlConnection);
            _sqlConnection.Open();

            _sqlCommand.Parameters.AddWithValue("@ConnectionName", values[0]);
            _sqlCommand.Parameters.AddWithValue("@ManagerURL", values[1]);
            _sqlCommand.Parameters.AddWithValue("@ManagerPort", values[2]);
            _sqlCommand.Parameters.AddWithValue("@SecondaryURL", values[3]);
            _sqlCommand.Parameters.AddWithValue("@SecondaryPort", values[4]);
            _sqlCommand.Parameters.AddWithValue("@UIN", values[5]);

            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public bool DupeCheck(string[] values) {
            string _queryString = "SELECT count (*) FROM Connections WHERE "+
                "ConnectionName=@ConnectionName AND " +
                "ManagerURL=@ManagerURL AND ManagerPort=@ManagerPort AND " +
                "SecondaryURL=@SecondaryURL AND SecondaryPort=@SecondaryPort AND " +
                "UIN=@UIN ";

            _sqlCommand = new SqlCommand(_queryString, _sqlConnection);
            _sqlConnection.Open();

            _sqlCommand.Parameters.AddWithValue("@ConnectionName", values[0]);
            _sqlCommand.Parameters.AddWithValue("@ManagerURL", values[1]);
            _sqlCommand.Parameters.AddWithValue("@ManagerPort", values[2]);
            _sqlCommand.Parameters.AddWithValue("@SecondaryURL", values[3]);
            _sqlCommand.Parameters.AddWithValue("@SecondaryPort", values[4]);
            _sqlCommand.Parameters.AddWithValue("@UIN", values[5]);

            int _res = Convert.ToInt32(_sqlCommand.ExecuteScalar());
            _sqlConnection.Close();

            if (_res != 0) {
                return true;
            } else {
                return false;
            }
            
        }

        // Read
        public DataTable ReadFromDB() {
            DataTable dt = new DataTable();
            string _queryString = "select * from Connections";

            _sqlConnection.Open();
            _sqlDataAdapter = new SqlDataAdapter(_queryString, _sqlConnection);
            _sqlDataAdapter.Fill(dt);
            _sqlConnection.Close();

            return dt;
        }

        // Update
        public void UpdateDB(int ID, string[] values) {
            string _queryString = "update Connections set " +
                "ConnectionName=@ConnectionName," +
                "ManagerURL=@ManagerURL,ManagerPort=@ManagerPort," +
                "SecondaryURL=@SecondaryURL,SecondaryPort=@SecondaryPort," +
                "UIN=@UIN " +
                "where ConnectionID=@id";

            _sqlCommand = new SqlCommand(_queryString, _sqlConnection);
            _sqlConnection.Open();

            _sqlCommand.Parameters.AddWithValue("@ConnectionName", values[0]);
            _sqlCommand.Parameters.AddWithValue("@ManagerURL", values[1]);
            _sqlCommand.Parameters.AddWithValue("@ManagerPort", values[2]);
            _sqlCommand.Parameters.AddWithValue("@SecondaryURL", values[3]);
            _sqlCommand.Parameters.AddWithValue("@SecondaryPort", values[4]);
            _sqlCommand.Parameters.AddWithValue("@UIN", values[5]);

            _sqlCommand.Parameters.AddWithValue("@id", ID);

            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        // Delete
        public void DeleteFromDB(int ID) {
            string _queryString = "delete Connections where ConnectionID=@id";

            _sqlCommand = new SqlCommand(_queryString, _sqlConnection);
            _sqlConnection.Open();
            _sqlCommand.Parameters.AddWithValue("@id", ID);
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
