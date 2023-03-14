using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngenixUpdateInstallerFTP
{
    public class EUISettings
    {
        public EUISettings()
        {

        }

        public void ReadFromAppSettings()
        {
            RootFolder = Properties.Settings.Default.FolderRoot;
            Folder401 = Properties.Settings.Default.Folder401;
            Folder410 = Properties.Settings.Default.Folder410;
            Folder411 = Properties.Settings.Default.Folder411;
            Folder420 = Properties.Settings.Default.Folder420;
            Folder500 = Properties.Settings.Default.Folder500;
            Folder510 = Properties.Settings.Default.Folder510;
            Folder520 = Properties.Settings.Default.Folder520;
            FTPUser = Properties.Settings.Default.FTPUser;
            FTPPassword = Properties.Settings.Default.FTPPassword;
            FTP401URL = Properties.Settings.Default.FTP401URL;
            FTP410URL = Properties.Settings.Default.FTP410URL;
            FTP411URL = Properties.Settings.Default.FTP411URL;
            FTP420URL = Properties.Settings.Default.FTP420URL;
            FTP500URL = Properties.Settings.Default.FTP500URL;
            FTP510URL = Properties.Settings.Default.FTP510URL;
            FTP520URL = Properties.Settings.Default.FTP520URL;
        }

        public void SaveToAppSettings()
        {
            Properties.Settings.Default.FolderRoot = RootFolder;
            Properties.Settings.Default.Folder401 = Folder401;
            Properties.Settings.Default.Folder410 = Folder410;
            Properties.Settings.Default.Folder411 = Folder411;
            Properties.Settings.Default.Folder420 = Folder420;
            Properties.Settings.Default.Folder500 = Folder500;
            Properties.Settings.Default.Folder510 = Folder510;
            Properties.Settings.Default.Folder520 = Folder520;
            Properties.Settings.Default.FTPUser = FTPUser;
            Properties.Settings.Default.FTPPassword = FTPPassword;
            Properties.Settings.Default.FTP401URL = FTP401URL;
            Properties.Settings.Default.FTP410URL = FTP410URL;
            Properties.Settings.Default.FTP411URL = FTP411URL;
            Properties.Settings.Default.FTP420URL = FTP420URL;
            Properties.Settings.Default.FTP500URL = FTP500URL;
            Properties.Settings.Default.FTP510URL = FTP510URL;
            Properties.Settings.Default.FTP520URL = FTP520URL;

            Properties.Settings.Default.Save();
        }

        public string RootFolder { get; set; }
        public string Folder401 { get; set; }
        public string Folder410 { get; set; }
        public string Folder411 { get; set; }
        public string Folder420 { get; set; }
        public string Folder500 { get; set; }
        public string Folder510 { get; set; }
        public string Folder520 { get; set; }
        public string FTPUser { get; set; }
        public string FTPPassword { get; set; }
        public string FTP401URL { get; set; }
        public string FTP410URL { get; set; }
        public string FTP411URL { get; set; }
        public string FTP420URL { get; set; }
        public string FTP500URL { get; set; }
        public string FTP510URL { get; set; }
        public string FTP520URL { get; set; }

        // Static variables for run time usage
        public static string uRootFolder { get; set; }
        public static string uFolder401 { get; set; }
        public static string uFolder410 { get; set; }
        public static string uFolder411 { get; set; }
        public static string uFolder420 { get; set; }
        public static string uFolder500 { get; set; }
        public static string uFolder510 { get; set; }
        public static string uFolder520 { get; set; }
        public static string uFTPUser { get; set; }
        public static string uFTPPassword { get; set; }
        public static string uFTP401URL { get; set; }
        public static string uFTP410URL { get; set; }
        public static string uFTP411URL { get; set; }
        public static string uFTP420URL { get; set; }
        public static string uFTP500URL { get; set; }
        public static string uFTP510URL { get; set; }
        public static string uFTP520URL { get; set; }
        public static string pFTPSourceFolder { get; set; }
        public static string pDestFolder { get; set; }
        public static string pSourceFolder { get; set; }
        public static string pFTPRoot { get; set; }
        public static string pFTPInternal { get; set; }
    }
}
