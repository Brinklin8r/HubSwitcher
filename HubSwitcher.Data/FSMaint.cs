using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSwitcher.Data {
    public class FSMaint {
         private Configuration _config;

        // Create
        // Read
        // Update
        // Delete

        public FSMaint(string Location) {
            ReadConfig(Location);
        }

        public void ReadConfig(string Location) {
            try {
                ExeConfigurationFileMap map = new ExeConfigurationFileMap {
                    ExeConfigFilename = Location
                };
                _config = ConfigurationManager.OpenMappedExeConfiguration(
                    map,
                    ConfigurationUserLevel.None
                );
             } catch (Exception ex) {
                int Stop = 1; 
             }
        }

        public Configuration GetConfigSettings() {
            return _config;
        }
    }
}
