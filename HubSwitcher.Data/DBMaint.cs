using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSwitcher.Data {
    public class DBMaint {
        private readonly SqlConnection _con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\HubSwitcher.mdf;Integrated Security = True;");
        private SqlCommand _cmd;
        private SqlDataAdapter _adapt;

        // Create
        public void InsertIntoDB(string[] values) {
            string _command = 
                "insert into Connections(ConnectionName,ManagerURL,ManagerPort,SecondaryURL,SecondaryPort,UIN)" +
                " values(@ConnectionName,@ManagerURL,@ManagerPort,@SecondaryURL,@SecondaryPort,@UIN)";

            _cmd = new SqlCommand(_command, _con);
            _con.Open();

            _cmd.Parameters.AddWithValue("@ConnectionName", values[0]);
            _cmd.Parameters.AddWithValue("@ManagerURL", values[1]);
            _cmd.Parameters.AddWithValue("@ManagerPort", values[2]);
            _cmd.Parameters.AddWithValue("@SecondaryURL", values[3]);
            _cmd.Parameters.AddWithValue("@SecondaryPort", values[4]);
            _cmd.Parameters.AddWithValue("@UIN", values[5]);

            _cmd.ExecuteNonQuery();
            _con.Close();
        }

        // Read
        public DataTable ReadFromDB() {
            DataTable dt = new DataTable();
            string _command = "select * from Connections";

            _con.Open();
            _adapt = new SqlDataAdapter(_command, _con);
            _adapt.Fill(dt);
            _con.Close();

            return dt;
        }

        // Update
        public void UpdateDB(int ID, string[] values) {
            string _command = "update Connections set " +
                "ConnectionName=@ConnectionName,ManagerURL=@ManagerURL," +
                "ManagerPort=@ManagerPort,SecondaryURL=@SecondaryURL," +
                "SecondaryPort=@SecondaryPort,UIN=@UIN " +
                "where ID=@id";

            _cmd = new SqlCommand(_command, _con);
            _con.Open();

            _cmd.Parameters.AddWithValue("@ConnectionName", values[0]);
            _cmd.Parameters.AddWithValue("@ManagerURL", values[1]);
            _cmd.Parameters.AddWithValue("@ManagerPort", values[2]);
            _cmd.Parameters.AddWithValue("@SecondaryURL", values[3]);
            _cmd.Parameters.AddWithValue("@SecondaryPort", values[4]);
            _cmd.Parameters.AddWithValue("@UIN", values[5]);

            _cmd.ExecuteNonQuery();
            _con.Close();
        }

        // Delete
        public void DeleteFromDB(int ID) {
            string _command = "delete Connections where ID=@id";

            _cmd = new SqlCommand(_command, _con);
            _con.Open();
            _cmd.Parameters.AddWithValue("@id", ID);
            _cmd.ExecuteNonQuery();
            _con.Close();
        }
    }
}
