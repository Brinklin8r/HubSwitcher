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
            lblResults.Text = "Update button pressed.";
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            lblResults.Text = "Delete button pressed.";
        }

        private void DisplayConfig() {
            tbDescription.Text = _adminConfig.GetValue(Config.ConfigFields.Description);
            tbMURL.Text        = _adminConfig.GetValue(Config.ConfigFields.ManagerURL);
            tbSURL.Text        = _adminConfig.GetValue(Config.ConfigFields.SecondaryManagerURL);
            tbUIN.Text         = _adminConfig.GetValue(Config.ConfigFields.UIN);
        }
    }
}
