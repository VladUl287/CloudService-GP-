using System;
using System.IO;
using System.Windows.Forms;
using Test.Forms;
using Test.Models;

namespace Test
{
    public partial class SettingsForm : CustomForm
    {
        private AppSettings newSettings = new AppSettings();

        public SettingsForm()
        {
            InitializeComponent();

            newSettings.Encryption = cbEncryption.Checked = Settings.Encryption;
            newSettings.DeleteInsert = cbDeleteInsert.Checked = Settings.DeleteInsert;
            newSettings.DeleteExtract = cbDeleteExtract.Checked = Settings.DeleteExtract;
            newSettings.ReplaceInsertLocal = cbReplaceInsertLocal.Checked = Settings.ReplaceInsertLocal;
            newSettings.ReplaceInsertCloud = cbReplaceInsertCloud.Checked = Settings.ReplaceInsertCloud;

            if (string.IsNullOrEmpty(Settings.PathStorage))
            {
                newSettings.PathStorage = lbStoragePath.Text = Directory.GetCurrentDirectory();
            }
            else
            {
                newSettings.PathStorage = lbStoragePath.Text = Settings.PathStorage;
            }
        }

        private void BtnSelectPath_Click(object sender, EventArgs e)
        {
            var dialog = folderBrowserDialog1.ShowDialog();

            if (dialog == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                newSettings.PathStorage = folderBrowserDialog1.SelectedPath;
                lbStoragePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void CbInsert_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;

            newSettings.DeleteInsert = check.Checked;
        }

        private void CbDeleteExtract_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;

            newSettings.DeleteExtract = check.Checked;
        }

        private void CbEncryption_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;

            newSettings.Encryption = check.Checked;
        }

        private void CbReplaceInsertLocal_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;

            newSettings.ReplaceInsertLocal = check.Checked;
        }

        private void CbReplaceInsertCloud_CheckedChanged(object sender, EventArgs e)
        {
            var check = (CheckBox)sender;

            newSettings.ReplaceInsertCloud = check.Checked;
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            Reflection.RefreshSettings(newSettings);
            Dispose();
            Close();
        }

        protected override void BtnExit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}