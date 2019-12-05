using HubSwitcher.Data;
using Security;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubSwitcher.DTO {
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

        public void UpdateConfig(string Description, string ManagerURL,
            string ManagerPort, string SecondaryManagerURL, string SecondaryManagerPort,
            string UIN) {

            SetValue(Config.ConfigFields.Description, Description);
            SetValue(Config.ConfigFields.ManagerURL, ManagerURL);
            SetValue(Config.ConfigFields.ManagerPort, ManagerPort);
            SetValue(Config.ConfigFields.SecondaryManagerURL, SecondaryManagerURL);
            SetValue(Config.ConfigFields.SecondaryManagerPort, SecondaryManagerPort);
            SetValue(Config.ConfigFields.UIN, UIN);
        }

        public void UpdateConfig(string Description, string ManagerURL,
            string ManagerPort, string UIN) {

            SetValue(Config.ConfigFields.Description, Description);
            SetValue(Config.ConfigFields.ManagerURL, ManagerURL);
            SetValue(Config.ConfigFields.ManagerPort, ManagerPort);
            SetValue(Config.ConfigFields.SecondaryManagerURL, "");
            SetValue(Config.ConfigFields.SecondaryManagerPort, "");
            SetValue(Config.ConfigFields.UIN, UIN);
        }

        public void SaveConfig() { 
            // build update config
            // https://yizeng.me/2013/08/31/update-appsettings-and-custom-configuration-sections-in-appconfig-at-runtime/
            // < appSettings >
            //  < add key = "UIN" value = "1" />
            //  < add key = "ManagerURL" value = "tcp://m.imagepointhosted.com:50669/MerchantCaptureCommObj.rem" />
            //  < add key = "SecondaryManagerURL" value = "tcp://cat-m2.alogentcloud.com:50669/MerchantCaptureCommObj.rem" />
            // </ appSettings >

            _configFile.GetConfigSettings().AppSettings.Settings["UIN"].Value =
                buildString(ConfigFields.UIN);
            _configFile.GetConfigSettings().AppSettings.Settings["ManagerURL"].Value =
                buildString(ConfigFields.ManagerURL);
            _configFile.GetConfigSettings().AppSettings.Settings["SecondaryManagerURL"].Value =
                buildString(ConfigFields.SecondaryManagerURL);

            _configFile.GetConfigSettings().Save(ConfigurationSaveMode.Modified);
        }

        private string buildString(ConfigFields key) {
            StringBuilder _sb = new StringBuilder();
            StringBuilder _sb2 = new StringBuilder();
            _sb.Append('~'); // Encrypted string identifier 

            switch (key) {
                case ConfigFields.ManagerURL:
                    _sb.Append(_encObj.EncryptValue(_sb2.Append("tcp://")
                        .Append(GetValue(key))
                        .Append(":")
                        .Append(GetValue(ConfigFields.ManagerPort))
                        .Append("/MerchantCaptureCommObj.rem")
                        .ToString()
                    ));
                break;
                case ConfigFields.SecondaryManagerURL:
                    _sb.Append(_encObj.EncryptValue(_sb2.Append("tcp://")
                        .Append(GetValue(key))
                        .Append(":")
                        .Append(GetValue(ConfigFields.SecondaryManagerPort))
                        .Append("/MerchantCaptureCommObj.rem")
                        .ToString()
                    ));
                break;
                case ConfigFields.UIN:
                    _sb.Append(_encObj.EncryptValue(GetValue(key)));
                break;
                default:
                    int STOP = 1;
                break;
            }
            return _sb.ToString();
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

        public void SetValue(ConfigFields KeyName, string Value) {
            try {
                _configSettings[KeyName] = Value;
            } catch (Exception ex) {

            }
        }

        public Dictionary<ConfigFields, string> GetSettings() {
            return _configSettings;
        }


    }
}
