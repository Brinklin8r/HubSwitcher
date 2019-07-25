using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSwitcher.Data {
    public class Config {
        FSMaint _configFile = new FSMaint(@"C:\Program Files (x86)\Bluepoint Solutions\RDC\IP Admin\IP Admin.exe.config");

        public enum ConfigFields {
            Description,            // description
            ManagerURL,             // MURL
            SecondaryManagerURL,    // SURL
            UIN                     // UIN
        }

        private Dictionary<ConfigFields, string> _configSettings =
            new Dictionary<ConfigFields, string>();

        public Config() {
            createConfigSettings(_configFile.GetConfigSettings());
        }

        private void createConfigSettings(Configuration Config) {
            foreach (var _setting in Config.AppSettings.Settings.AllKeys) {
                if (Enum.TryParse(_setting, out ConfigFields validField)) {
                    _configSettings.Add(
                        validField,
                        Config.AppSettings.Settings[_setting].Value.ToString()
                    );
                }
            }
            _configSettings.Add(ConfigFields.Description, "Current");

            //_configSettings.Add(ConfigFields.Description, ex.ToString());
            //_configSettings.Add(ConfigFields.ManagerURL, "$hit");
            //_configSettings.Add(ConfigFields.SecondaryManagerURL, "$hit");
            //_configSettings.Add(ConfigFields.UIN, "$hit");
        }

        public string GetValue(ConfigFields KeyName) {
            string _value = "";
            if (_configSettings.TryGetValue(KeyName, out _value)) {
            } else {
                _value = "ERROR: Unable to find " + KeyName;
            }
            return _value;
        }

        public Dictionary<ConfigFields, string> GetSettings() {
            return _configSettings;
        }


    }
}
