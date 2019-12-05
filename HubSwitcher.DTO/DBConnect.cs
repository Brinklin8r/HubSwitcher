using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HubSwitcher.Data;

namespace HubSwitcher.DTO {
    public class DBConnect {
        private readonly DBMaint _dbconn = new DBMaint();

        public DataTable ReadFromDB() {
            return _dbconn.ReadFromDB();
        }

        public void AddConfig(Config ConfigurationObject) {
            _dbconn.InsertIntoDB(createValueString(ConfigurationObject));
        }

        public void DeleteFromDB(int RowID) {
            _dbconn.DeleteFromDB(RowID);
        }

        public void UpdateDB(int RowID, Config ConfigurationObject) {
            _dbconn.UpdateDB(RowID, createValueString(ConfigurationObject));
        }

        public bool DupeCheck(Config ConfigurationObject) {
           return _dbconn.DupeCheck(createValueString(ConfigurationObject));
        }

        private string[] createValueString(Config _confObj) {
            string[] _configValues = new string[]{
                _confObj.GetValue(Config.ConfigFields.Description),
                _confObj.GetValue(Config.ConfigFields.ManagerURL),
                _confObj.GetValue(Config.ConfigFields.ManagerPort),
                _confObj.GetValue(Config.ConfigFields.SecondaryManagerURL),
                _confObj.GetValue(Config.ConfigFields.SecondaryManagerPort),
                _confObj.GetValue(Config.ConfigFields.UIN)
            };
            return _configValues;
        }
    }
}
