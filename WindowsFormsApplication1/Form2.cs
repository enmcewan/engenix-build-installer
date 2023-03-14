using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngenixUpdateInstallerFTP
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            EUISettings getSettings = new EUISettings();
            getSettings.ReadFromAppSettings();

            // Get values from settings if they exist. Else default tbx values are used
            if (getSettings.RootFolder != "")
                tbxRootFolder.Text = getSettings.RootFolder;

            if (getSettings.Folder401 != "")
                tbx401Folder.Text = getSettings.Folder401;

            if (getSettings.Folder410 != "")
                tbx410Folder.Text = getSettings.Folder410;

            if (getSettings.Folder411 != "")
                tbx411Folder.Text = getSettings.Folder411;

            if (getSettings.Folder420 != "")
                tbx420Folder.Text = getSettings.Folder420;

            if (getSettings.Folder500 != "")
                tbx500Folder.Text = getSettings.Folder500;

            if (getSettings.Folder510 != "")
                tbx510Folder.Text = getSettings.Folder510;

            if (getSettings.Folder520 != "")
                tbx520Folder.Text = getSettings.Folder520;

            if (getSettings.FTPUser != "")
                tbxFTPUser.Text = getSettings.FTPUser;

            if (getSettings.FTPPassword != "")
                tbxFTPPass.Text = getSettings.FTPPassword;

            if (getSettings.FTP401URL != "")
                tbx401Url.Text = getSettings.FTP401URL;

            if (getSettings.FTP410URL != "")
                tbx410Url.Text = getSettings.FTP410URL;

            if (getSettings.FTP411URL != "")
                tbx411Url.Text = getSettings.FTP411URL;

            if (getSettings.FTP420URL != "")
                tbx420Url.Text = getSettings.FTP420URL;

            if (getSettings.FTP500URL != "")
                tbx500Url.Text = getSettings.FTP500URL;

            if (getSettings.FTP510URL != "")
                tbx510Url.Text = getSettings.FTP510URL;

            if (getSettings.FTP520URL != "")
                tbx520Url.Text = getSettings.FTP520URL;

        }

        //EngenixUpdateInstallerSettings _settings;
        //public void SetSettings(EngenixUpdateInstallerSettings settings)
        //{
        //    _settings = settings;
        //    if (_settings != null)
        //    {
        //        tbxRootFolder.Text = _settings.RootFolder;
        //        tbx401Folder.Text = _settings.Folder401;
        //        tbx410Folder.Text = _settings.Folder410;
        //    }
        //    else
        //    {
        //        tbxRootFolder.Text = string.Empty;
        //        tbx401Folder.Text = string.Empty;
        //        tbx410Folder.Text = string.Empty;
        //    }
        //}

        private void btnOpenExplorerSource_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbxRootFolder.Text = folderBrowserDialog1.SelectedPath + "\\";
                tbx401Folder.Text = tbxRootFolder.Text;
                tbx410Folder.Text = tbxRootFolder.Text;
                tbx411Folder.Text = tbxRootFolder.Text;
                tbx420Folder.Text = tbxRootFolder.Text;
                tbx500Folder.Text = tbxRootFolder.Text;
                tbx510Folder.Text = tbxRootFolder.Text;
                tbx520Folder.Text = tbxRootFolder.Text;
            }
        }

        private void btnOpenExplorer401_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx401Folder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btnOpenExplorer410_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx410Folder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btnOpenExplorer420_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx420Folder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btnOpenExplorer500_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx500Folder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btnOpenExplorer510_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx510Folder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void btnOpenExplorer520_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx520Folder.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void tbx401Url_TextChanged(object sender, EventArgs e)
        {
            if (!validURL(tbx401Url.Text))
                tbx401Url.ForeColor = Color.Red;
            else
                tbx401Url.ForeColor = Color.Black;
        }

        private void tbx410Url_TextChanged(object sender, EventArgs e)
        {
            if (!validURL(tbx410Url.Text))
                tbx410Url.ForeColor = Color.Red;
            else
                tbx410Url.ForeColor = Color.Black;
        }

        private void tbx411Url_TextChanged(object sender, EventArgs e)
        {
            if (!validURL(tbx411Url.Text))
                tbx411Url.ForeColor = Color.Red;
            else
                tbx411Url.ForeColor = Color.Black;
        }

        bool validURL(string strURL)
        {
            Uri uriResult;
            bool urlOK = Uri.TryCreate(strURL, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeFtp);

            if (urlOK)
                return true;
            else
                return false;
        }
        
        // Save text box values to settings
        private void btnOK_Click(object sender, EventArgs e)
        {

            EUISettings.uRootFolder = tbxRootFolder.Text;
            EUISettings.uFolder401 = tbx401Folder.Text;
            EUISettings.uFolder410 = tbx410Folder.Text;
            EUISettings.uFolder411 = tbx411Folder.Text;
            EUISettings.uFolder420 = tbx420Folder.Text;
            EUISettings.uFolder500 = tbx500Folder.Text;
            EUISettings.uFolder510 = tbx510Folder.Text;
            EUISettings.uFolder520 = tbx520Folder.Text;
            EUISettings.uFTPUser = tbxFTPUser.Text;
            EUISettings.uFTPPassword = tbxFTPPass.Text;
            EUISettings.uFTP401URL = tbx401Url.Text;
            EUISettings.uFTP410URL = tbx410Url.Text;
            EUISettings.uFTP411URL = tbx411Url.Text;
            EUISettings.uFTP420URL = tbx420Url.Text;
            EUISettings.uFTP500URL = tbx500Url.Text;
            EUISettings.uFTP510URL = tbx510Url.Text;
            EUISettings.uFTP520URL = tbx520Url.Text;

            EUISettings settings = new EUISettings();
            settings.RootFolder = tbxRootFolder.Text;
            settings.Folder401 = tbx401Folder.Text;
            settings.Folder410 = tbx410Folder.Text;
            settings.Folder411 = tbx411Folder.Text;
            settings.Folder420 = tbx420Folder.Text;
            settings.Folder500 = tbx500Folder.Text;
            settings.Folder510 = tbx510Folder.Text;
            settings.Folder520 = tbx520Folder.Text;
            settings.FTPUser = tbxFTPUser.Text;
            settings.FTPPassword = tbxFTPPass.Text;
            settings.FTP401URL = tbx401Url.Text;
            settings.FTP410URL = tbx410Url.Text;
            settings.FTP411URL = tbx411Url.Text;
            settings.FTP420URL = tbx420Url.Text;
            settings.FTP500URL = tbx500Url.Text;
            settings.FTP510URL = tbx510Url.Text;
            settings.FTP520URL = tbx520Url.Text;

            settings.SaveToAppSettings();

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenExplorer411_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxRootFolder.Text;
            DialogResult dlgResult = folderBrowserDialog1.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                tbx411Url.Text = folderBrowserDialog1.SelectedPath + "\\";
            }
        }

        private void tbxFTPPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx510Folder_TextChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

    }
}
