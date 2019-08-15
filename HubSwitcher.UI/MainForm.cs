using System;
using System.Windows.Forms;
using HubSwitcher.Data;

namespace HubSwitcher.UI {
    public partial class MainForm : Form {
        Config _adminConfig = new Config();

        public MainForm() {
            InitializeComponent();
            DisplayConfig();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            lblResults.Text = "Add button pressed.";
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            //_adminConfig.SetValue(Config.ConfigFields.Description, tbDescription.Text);
            //_adminConfig.SetValue(Config.ConfigFields.ManagerURL, tbMURL.Text);
            //_adminConfig.SetValue(Config.ConfigFields.ManagerPort, tbMPort.Text);
            //_adminConfig.SetValue(Config.ConfigFields.SecondaryManagerURL, tbSURL.Text);
            //_adminConfig.SetValue(Config.ConfigFields.SecondaryManagerPort, tbSPort.Text);
            _adminConfig.SetValue(Config.ConfigFields.UIN, tbUIN.Text);



            _adminConfig.UpdateConfig();
            lblResults.Text = "Update button pressed.";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            lblResults.Text = "Delete button pressed.";
        }

        private void DisplayConfig() {
            tbDescription.Text = _adminConfig.GetValue(Config.ConfigFields.Description);
            tbMURL.Text        = _adminConfig.GetValue(Config.ConfigFields.ManagerURL);
            tbMPort.Text       = _adminConfig.GetValue(Config.ConfigFields.ManagerPort);
            tbSURL.Text        = _adminConfig.GetValue(Config.ConfigFields.SecondaryManagerURL);
            tbSPort.Text       = _adminConfig.GetValue(Config.ConfigFields.SecondaryManagerPort);
            tbUIN.Text         = _adminConfig.GetValue(Config.ConfigFields.UIN);
        }
    }
}
