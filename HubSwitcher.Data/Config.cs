using Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSwitcher.Data {
    public class Config {
        readonly FSMaint _configFile = new FSMaint(@"C:\Program Files (x86)\Bluepoint Solutions\RDC\IP Admin\IP Admin.exe.config");
        private readonly Encrypt _encObj = new Encrypt();

        public enum ConfigFields {
            Description,            // Description
            ManagerURL,             // MURL
            ManagerPort,            // MPort
            SecondaryManagerURL,    // SURL
            SecondaryManagerPort,   // SPort
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
                    // Is it a valid Key?
                    string _tempValue = Config.AppSettings.Settings[_setting].Value.ToString();
                    if (_tempValue.StartsWith("~") && _tempValue.Length > 1) {
                        // Is the Key Encrypted
                        _tempValue = _encObj.DecryptValue(_tempValue);
                    }
                    if (_tempValue.StartsWith("tcp://") && _tempValue.Length > 6) {
                        // Is the Key a URL
                        _tempValue = _tempValue.Substring(6, _tempValue.LastIndexOf("/") - 6);
                        _configSettings.Add(
                            // Save the URL
                            validField,
                            _tempValue.Substring(0, _tempValue.IndexOf(":"))
                        );
                        _configSettings.Add(
                            // Save the Port, the next ENUM after the URL
                            validField + 1,
                            _tempValue.Substring(_tempValue.IndexOf(":") + 1)
                        );
                    } else {
                        // If the key was not a URL save the info.
                        _configSettings.Add(
                            validField,
                            _tempValue
                        );
                    }
                }
            }
            _configSettings.Add(ConfigFields.Description, "Current");
        }

        public string GetValue(ConfigFields KeyName) {
            if (_configSettings.TryGetValue(KeyName, out string _value)) {

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
