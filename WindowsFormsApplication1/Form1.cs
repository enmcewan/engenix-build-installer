using Ionic.Zip;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;


namespace EngenixUpdateInstallerFTP
{
    public partial class AppMainForm : Form
    {
        string SelectedItem = "";

        //private Form2 settingsform = new Form2();

        public AppMainForm()
        {
            InitializeComponent();

            bgwGetFileFromFTP.WorkerReportsProgress = true;
            bgwGetFileFromFTP.DoWork += new DoWorkEventHandler(bgwGetFileFromFTP_DoWork);
            bgwGetFileFromFTP.ProgressChanged += new ProgressChangedEventHandler(bgwGetFileFromFTP_ProgressChanged);
            bgwGetFileFromFTP.WorkerSupportsCancellation = true;
            bgwGetFileFromFTP.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgwGetFileFromFTP_RunWorkerCompleted);


            // When settings have not been edited, assign static variables to default values
            EUISettings.uRootFolder = @"C:\Engenix\";
            EUISettings.uFolder401 = @"C:\Engenix\400\";
            EUISettings.uFolder410 = @"C:\Engenix\410\";
            EUISettings.uFolder411 = @"C:\Engenix\411\";
            EUISettings.uFolder420 = @"C:\Engenix\411\";
            EUISettings.uFolder500 = @"C:\Engenix\500\";
            EUISettings.uFolder510 = @"C:\Engenix\510\";
            EUISettings.uFolder520 = @"C:\Engenix\520\";
            EUISettings.uFTPUser = "3epcbcom";
            EUISettings.uFTPPassword = "";  // Keep blank for security purposes
            EUISettings.uFTP401URL = "ftp://www.3epcb.com/DailyBuild/Engenix%204.0.0/";
            EUISettings.uFTP410URL = "ftp://www.3epcb.com/DailyBuild/Engenix%204.1.0/";
            EUISettings.uFTP411URL = "ftp://www.3epcb.com/DailyBuild/Engenix%204.1.1/";
            EUISettings.uFTP420URL = "ftp://www.3epcb.com/DailyBuild/Engenix%204.2.0/";
            EUISettings.uFTP500URL = "ftp://www.3epcb.com/DailyBuild/Engenix%205.0.0/";
            EUISettings.uFTP510URL = "ftp://www.3epcb.com/DailyBuild/Engenix%205.1.0/";
            EUISettings.uFTP520URL = "ftp://www.3epcb.com/DailyBuild/Engenix%205.2.0/";
            EUISettings.pFTPRoot = "ftp://www.3epcb.com/";
            EUISettings.pFTPInternal = "ftp://www.3epcb.com/internal/";
            EUISettings.pDestFolder = EUISettings.uRootFolder;
            EUISettings.pSourceFolder = EUISettings.uRootFolder;

            EUISettings getSettings = new EUISettings();
            getSettings.ReadFromAppSettings();

            // Get values from settings if they exist. Else default tbx values are used
            if (getSettings.RootFolder != "")
                EUISettings.uRootFolder = getSettings.RootFolder;

            if (getSettings.Folder401 != "")
                EUISettings.uFolder401 = getSettings.Folder401;

            if (getSettings.Folder410 != "")
                EUISettings.uFolder410 = getSettings.Folder410;

            if (getSettings.Folder411 != "")
                EUISettings.uFolder411 = getSettings.Folder411;

            if (getSettings.Folder420 != "")
                EUISettings.uFolder420 = getSettings.Folder420;

            if (getSettings.Folder500 != "")
                EUISettings.uFolder500 = getSettings.Folder500;

            if (getSettings.Folder510 != "")
                EUISettings.uFolder510 = getSettings.Folder510;

            if (getSettings.Folder520 != "")
                EUISettings.uFolder520 = getSettings.Folder520;

            if (getSettings.FTPUser != "")
                EUISettings.uFTPUser = getSettings.FTPUser;

            if (getSettings.FTPPassword != "")
                EUISettings.uFTPPassword = getSettings.FTPPassword;

            if (getSettings.FTP401URL != "")
                EUISettings.uFTP401URL = getSettings.FTP401URL;

            if (getSettings.FTP410URL != "")
                EUISettings.uFTP410URL = getSettings.FTP410URL;

            if (getSettings.FTP411URL != "")
                EUISettings.uFTP411URL = getSettings.FTP411URL;

            // Init textboxes with settings
            tbxSourceFolder.Text = EUISettings.pSourceFolder;
            tbxDestinationFolder.Text = EUISettings.pSourceFolder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FolderExplorer(string FolderType)
        {
            //Generic Folder Browser with options and actions depending if it's for the Source folder or Destination folder
            FolderBrowserDialog folderBrowserDlg = new FolderBrowserDialog();

            // Only show add new folder if Folder Type is Destination
            if (FolderType == "Source")
                folderBrowserDlg.ShowNewFolderButton = false;
            else
                folderBrowserDlg.ShowNewFolderButton = true;

            // Start in existing path
            if (FolderType == "Source")
            {
                if (!tbxSourceFolder.Text.Equals(String.Empty))
                    folderBrowserDlg.SelectedPath = tbxSourceFolder.Text;
            }
            else
            {
                if (!tbxDestinationFolder.Text.Equals(String.Empty))
                    folderBrowserDlg.SelectedPath = tbxDestinationFolder.Text;
            }

            //Show FolderBrowserDialog
            DialogResult dlgResult = folderBrowserDlg.ShowDialog();

            if (dlgResult.Equals(DialogResult.OK))
            {
                if (FolderType == "Source")
                {
                    //Show selected folder path in textbox1.
                    tbxSourceFolder.Text = folderBrowserDlg.SelectedPath + @"\";
                    tbxDestinationFolder.Text = tbxSourceFolder.Text;
                    EUISettings.pDestFolder = folderBrowserDlg.SelectedPath + @"\";
                    EUISettings.pSourceFolder = folderBrowserDlg.SelectedPath + @"\";
                    //Browsing start from root folder.
                    GetZipFiles();
                }
                else
                {
                    //Show selected folder path in textbox1.
                    tbxDestinationFolder.Text = folderBrowserDlg.SelectedPath + @"\";
                    EUISettings.pDestFolder = folderBrowserDlg.SelectedPath + @"\";
                    //Browsing start from root folder.                   
                }

                Environment.SpecialFolder rootFolder = folderBrowserDlg.RootFolder;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderExplorer("Source");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // textBox1.Text = "C:\\Engenix\\400";
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SetDefaultDestinationPath();
            EUISettings.pDestFolder = tbxSourceFolder.Text;
            tbxDestinationFolder.Text = tbxSourceFolder.Text;
            GetZipFiles();
        }

        public void GetZipFiles()
        {
            if (!EUISettings.pSourceFolder.Equals(String.Empty))
            {
                lbxZipFileList.Items.Clear();

                if (System.IO.Directory.GetFiles(EUISettings.pSourceFolder, "*.zip").Length > 0)
                {
                    foreach (string file in System.IO.Directory.GetFiles(EUISettings.pSourceFolder))
                    {
                        //Add .zip files in ListBox.
                        if (file.EndsWith(".zip"))
                        {
                            lbxZipFileList.Items.Add(file);
                        }
                    }

                    //SelectFileInListBox;
                    lbxZipFileList.SelectedIndex = lbxZipFileList.FindString(EUISettings.pSourceFolder + tbxFTPFileName.Text);
                }
                else
                {
                    lbxZipFileList.Items.Add(String.Format("No .zip files Found at location : {0}", EUISettings.pSourceFolder));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbxSourceFolder.Text = EUISettings.uRootFolder;
            SetDefaultDestinationPath();
        }

        public void SetDefaultDestinationPath()
        {
            tbxDestinationFolder.Text = tbxSourceFolder.Text;
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = lbxZipFileList.SelectedItem.ToString();
        }

        public string SetSubfolder(string filename)
        {
            string subfolder = "";

            if (filename.EndsWith("sql"))
                subfolder = (@"Upgrade\SQL Scripts\");


            switch (filename)
            {
                case FileNameConstants.EgxPro:
                case FileNameConstants.EgxEnt:
                case FileNameConstants.EgxST:
                case FileNameConstants.EgxQT:
                case FileNameConstants.ConfigPro:
                case FileNameConstants.ConfigEnt:
                case FileNameConstants.AdvQuery:
                case FileNameConstants.ECN:
                case FileNameConstants.dbrtl120:
                case FileNameConstants.rbIDE1112:
                case FileNameConstants.rbRCL1112:
                case FileNameConstants.rbTC1112:
                case FileNameConstants.rbTCUI1112:
                case FileNameConstants.rbTDBC1112:
                case FileNameConstants.rtl120:
                case FileNameConstants.tee8120:
                case FileNameConstants.teedb8120:
                case FileNameConstants.teeui8120:
                case FileNameConstants.vcl120:
                case FileNameConstants.vcldb120:
                case FileNameConstants.vclimg120:
                case FileNameConstants.vclx120:
                    subfolder = (@"Applications\");
                    break;

                case FileNameConstants.AstaPDM:
                case FileNameConstants.AstaPD_B:
                case FileNameConstants.AstaSAP:
                case FileNameConstants.AstaATS:
                case FileNameConstants.AstaMon:
                case FileNameConstants.AstaSX3:
                case FileNameConstants.AstaSCH:
                case FileNameConstants.AstaBCN:
                    subfolder = (@"Asta Server\");
                    break;

                case FileNameConstants.SQLUpdate:
                case FileNameConstants.SQLFiles:
                    subfolder = (@"Upgrade\SQL Scripts\");
                    break;

                case FileNameConstants.WebPtlPro:
                case FileNameConstants.WebPtlEnt:
                    subfolder = (@"Web Portal\");
                    break;

                case FileNameConstants.WebSvsDll:
                case FileNameConstants.WebSvsClt:
                    subfolder = (@"Web Services\");
                    break;

                case FileNameConstants.DBSwitch:
                    subfolder = (@"Utilities\");
                    break;
            }
            return subfolder;
        }

        /// <summary>
        /// This is cool!
        /// </summary>
        /// <param name="filename">talk about me</param>
        private void ExtractFileFromZip(string filename)
        {
            //ZipUtility.ExtractFilesFromZip("", "");

            //Check File exists in zip
            //Extract Files Using Ionic Zip Library
            string zipPath = SelectedItem;
            string RootPath = EUISettings.pDestFolder;
            string subfolder = SetSubfolder(filename);
            string extractPath = Path.Combine(RootPath + subfolder);

            try
            {
                using (var zip = ZipFile.Read(SelectedItem))
                {
                    var filefound = false;

                    foreach (ZipEntry e in zip)
                    {
                        //if (e.FileName.EndsWith("sql"))
                        //{
                        //    if (e.FileName.Contains("Oracle"))
                        //    { }
                        //    else
                        //     {
                        //         //filefound = true;
                        //         filename = e.FileName;
                        //     }
                        // }
                        if (filename.Equals("Engenix_update.sql"))
                        {

                            if (e.FileName.EndsWith("sql"))
                            {
                                if (e.FileName.Contains("Oracle"))
                                {
                                }
                                else
                                {
                                    filename = e.FileName;
                                }
                            }

                        }

                        if (e.FileName.Equals(filename))
                        {
                            filefound = true;
                        }
                        else
                        {
                            filefound = false;
                        }

                        if (filefound)
                        {
                            zip[filename].ExtractWithPassword(extractPath, "eng123");
                            // Post Process Web Portal zip files
                            if ((filename == FileNameConstants.WebPtlPro) || (filename == FileNameConstants.WebPtlEnt))
                            {
                                using (ZipFile zip2 = ZipFile.Read(extractPath + filename))
                                {
                                    foreach (ZipEntry e2 in zip2)
                                    {
                                        e2.Extract(extractPath);
                                    }
                                }
                            }
                            UpdateStatusStrip("zip file extraction succeeded");
                            break;
                        }
                    }
                    if (filefound == false)
                        MessageBox.Show("Requested file not found in zip");
                }
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(ex.Message);
            }
        }

        // TODO: Alex changed the capitalization of the method arguments. They follow the same convention of variables
        public void FileMover(string newFileName, string oldFileName)
        {
            if (File.Exists(newFileName))
            {
                MessageBox.Show("Old file already exists: " + newFileName);

                //Since backup already exists, delete current files so Zip Extract won't fail
                File.Delete(oldFileName);

            }
            else
            {
                File.Move(oldFileName, newFileName);
            }
        }

        private void RenameExistingFiles(string filename)
        {
            //Set Sub Folder per file
            string subfolder = SetSubfolder(filename);
            string rootfolder = tbxDestinationFolder.Text;
            string filepath = Path.Combine(rootfolder, subfolder, filename);

            if (File.Exists(filepath)) try
                {
                    string fname = Path.GetFileNameWithoutExtension(filepath);
                    DateTime dt = File.GetLastWriteTime(filepath);
                    string dts = string.Format("{0:yyMMdd}", dt);
                    string ext = Path.GetExtension(filepath);
                    string NewFilePath = Path.Combine(rootfolder, subfolder, fname + "." + dts + ext);

                    FileMover(NewFilePath, filepath);

                    //Post-Processing for Web Files stored in embedded zip
                    if ((filename == FileNameConstants.WebPtlPro) || (filename == FileNameConstants.WebPtlEnt))
                    {
                        string oldWebdllPath = Path.Combine(rootfolder, subfolder, "WebEngenixLib.dll");
                        string oldWebexePath = Path.Combine(rootfolder, subfolder, "WebEngenix.exe");
                        string newWebdllPath = Path.Combine(rootfolder, subfolder, "WebEngenixLib" + "." + dts + ".dll");
                        string newWebexePath = Path.Combine(rootfolder, subfolder, "WebEngenix" + "." + dts + ".exe");

                        FileMover(newWebdllPath, oldWebdllPath);
                        FileMover(newWebexePath, oldWebexePath);
                    }

                    UpdateStatusStrip("Existing files renamed successfully");
                    statusStrip1.BackColor = Color.Green;
                    statusStrip1.ForeColor = Color.WhiteSmoke;

                }
                catch (Exception ex)
                {
                    UpdateStatusStrip(ex.Message);
                }
        }

        public void BPLFileHandler()
        {
            // Can I get an automated list of theese items - all constants that end with .bpl...for example
            var bplList = new List<string>
            {
                FileNameConstants.dbrtl120,
                FileNameConstants.rbIDE1112,
                FileNameConstants.rbRCL1112,
                FileNameConstants.rbTC1112,
                FileNameConstants.rbTCUI1112,
                FileNameConstants.rbTDBC1112,
                FileNameConstants.rtl120,
                FileNameConstants.tee8120,
                FileNameConstants.teedb8120,
                FileNameConstants.teeui8120,
                FileNameConstants.vcl120,
                FileNameConstants.vcldb120,
                FileNameConstants.vclimg120,
                FileNameConstants.vclx120,
            };
            foreach (var bplfile in bplList)
            {
                RenameExistingFiles(bplfile);
                ExtractFileFromZip(bplfile);
            }
        }

        public void RenameAstaServer(string filename)
        {
            //Set Sub Folder per file
            string subfolder = SetSubfolder(filename);
            string rootfolder = tbxDestinationFolder.Text;
            string filepath = Path.Combine(rootfolder, subfolder, filename);

            if (File.Exists(filepath)) try
                {
                    string fname = Path.GetFileNameWithoutExtension(filepath);
                    string ext = Path.GetExtension(filepath);
                    string ver = rootfolder.Substring(11, 3);
                    string NewFile = Path.Combine(fname + "_" + ver + "." + ext);

                    File.Move(filepath, rootfolder + subfolder + NewFile);

                }
                catch (Exception ex)
                {
                    UpdateStatusStrip(ex.Message);
                };
        }

        private void doThisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Process Selected Checkbox Items
            if (lbxZipFileList.SelectedIndex < 0)
            {
                //Do nothing if no file selected
                MessageBox.Show("Select a zip file first");
                return;
            }

            var filetypesSelected = 0;

            foreach (CheckBox c in groupBox1.Controls)
            {
                if (c.Checked)
                {
                    filetypesSelected = filetypesSelected + 1;
                    string t = c.Tag as string;
                    if (t != null)
                    {
                        if (t != "*.BPL")
                        {
                            RenameExistingFiles(t);
                            ExtractFileFromZip(t);

                            if (t == "E2P_Paradigm.exe")
                            {
                                RenameAstaServer(t);
                            }
                        }
                        else
                            BPLFileHandler();
                    }
                }

            }
            if (filetypesSelected < 1)
            {
                MessageBox.Show("Select a file type first");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderExplorer("Destination");
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
                checkBox21.Checked = false;
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
                checkBox20.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string version;

            if (checkBox1.Checked)
            {
                checkBox4.Checked = true;
                checkBox3.Checked = false;
                checkBox2.Checked = true;

                if (tbxFTPFileName.Text.Length > 13)
                    version = tbxFTPFileName.Text.Substring(9, 1);
                else
                    version = "";

                if (version == "5")
                {
                    checkBox33.Checked = true;
                }
                else
                {
                    checkBox33.Checked = false;
                }
            }
            else
            {
                checkBox4.Checked = false;
                checkBox3.Checked = false;
                checkBox2.Checked = false;
                checkBox33.Checked = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox5.Checked = true;
                checkBox6.Checked = false;
            }
            else
            {
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                checkBox7.Checked = true;
                checkBox9.Checked = true;
            }
            else
            {
                checkBox7.Checked = false;
                checkBox9.Checked = false;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                checkBox11.Checked = true;
                checkBox12.Checked = true;
            }
            else
            {
                checkBox11.Checked = false;
                checkBox12.Checked = false;
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                checkBox14.Checked = true;
            }
            else
            {
                checkBox14.Checked = false;
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                checkBox18.Checked = true;
            }
            else
            {
                checkBox18.Checked = false;
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                checkBox20.Checked = true;
            }
            else
            {
                checkBox20.Checked = false;
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                checkBox23.Checked = true;
                checkBox24.Checked = true;
            }
            else
            {
                checkBox23.Checked = false;
                checkBox24.Checked = false;
            }
        }

        private void bplForceCheckboxes(bool b)
        {
            if (b == true)
            {
                checkBox27.Checked = true;
            }
            else
            {
                checkBox27.Checked = false;
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                bplForceCheckboxes(true);
            }
            else
            {
                bplForceCheckboxes(false);
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                bplForceCheckboxes(true);
            }
            else
            {
                bplForceCheckboxes(false);
            }
        }

        string DownloadFileName()
        {
            return tbxFTPFileName.Text.Trim();
        }

        private void GetFileFTP_Click(object sender, EventArgs e)
        {
            if (!DownloadFileName().Equals(""))
            {
                btnGetFileFTP.Enabled = false;
                bgwGetFileFromFTP.RunWorkerAsync();
                UpdateStatusStrip("Downloading " + DownloadFileName());
                btnCancelFTP.Enabled = true;
                cBxDest.Enabled = true;
                EUISettings.pSourceFolder = EUISettings.pDestFolder;
                tbxSourceFolder.Text = EUISettings.pSourceFolder;
            }
        }

        //Background Worker
        void bgwGetFileFromFTP_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = GetUpdateFile(DownloadFileName());
        }

        void bgwGetFileFromFTP_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // The progress percentage is a property of e
            progressBar1.Value = e.ProgressPercentage;
        }

        void bgwGetFileFromFTP_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            string s = e.Result.ToString();
            UpdateStatusStrip(s);

            if (s.StartsWith("The remote server returned an error"))
            {
                tbxFTPFileName.ForeColor = Color.Red;
                statusStrip1.BackColor = Color.OrangeRed;
                btnCancelFTP.Enabled = false;
                btnRefreshFTP.Enabled = true;
            }

            else if (s.EndsWith("cancelled"))
            {
                btnRefreshFTP.Enabled = true;
                btnCancelFTP.Enabled = false;
                tbxFTPFileName.ForeColor = Color.Black;
                tbxFTPFileName.Enabled = false;
                bgwGetFileFromFTP.CancelAsync();
            }

            else if (s.EndsWith("downloaded successfully"))
            {
                btnGetFileFTP.Enabled = true;
                btnCancelFTP.Enabled = false;
                btnRefreshFTP.Enabled = true;
                btnGetFileFTP.Enabled = false;
                GetZipFiles();
            }

        }
        // End of Background workers

        private void tbxFTPFileName_TextChanged(object sender, EventArgs e)
        {
            tbxFTPFileName.ForeColor = Color.Black;

            // Get static folder values
            string destFldr401 = EUISettings.uFolder401;
            string destFldr410 = EUISettings.uFolder410;
            string destFldr411 = EUISettings.uFolder411;
            string destFldr420 = EUISettings.uFolder420;
            string destFldr500 = EUISettings.uFolder500;
            string destFldr510 = EUISettings.uFolder510;
            string destFldr520 = EUISettings.uFolder520;
            string destFolder = EUISettings.uRootFolder;
            string version;

            try
            {
                if (tbxFTPFileName.Text.Length > 13)
                    version = tbxFTPFileName.Text.Substring(9, 5);
                else
                    version = "";

                if (version == "4.0.1")
                {
                    destFolder = destFldr401;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("4.0.1");
                    cBxDest.Enabled = false;
                }

                else if (version == "4.1.0")
                {
                    destFolder = destFldr410;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("4.1.0");
                    cBxDest.Enabled = false;
                }

                else if (version == "4.1.1")
                {
                    destFolder = destFldr411;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("4.1.1");
                    cBxDest.Enabled = false;
                }

                else if (version == "4.2.0")
                {
                    destFolder = destFldr420;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("4.2.0");
                    cBxDest.Enabled = false;
                }

                else if (version == "5.0.0")
                {
                    destFolder = destFldr500;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("5.0.0");
                    cBxDest.Enabled = false;
                }

                else if (version == "5.1.0")
                {
                    destFolder = destFldr510;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("5.1.0");
                    cBxDest.Enabled = false;
                }

                else if (version == "5.2.0")
                {
                    destFolder = destFldr520;
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("5.2.0");
                    cBxDest.Enabled = false;
                }

                else
                {
                    cBxDest.SelectedIndex = cBxDest.FindStringExact("Root");
                    cBxDest.Enabled = true;
                }

                tbxSourceFolder.Text = destFolder;
                tbxDestinationFolder.Text = destFolder;
                EUISettings.pSourceFolder = destFolder;
                EUISettings.pDestFolder = destFolder;
                btnGetFileFTP.Enabled = true;
            }
            catch (Exception ex)
            {
                UpdateStatusStrip(ex.Message);
            }

        }

        private void btnCancelFTP_Click(object sender, EventArgs e)
        {
            bgwGetFileFromFTP.CancelAsync();

            // Moved UI refresh to bgw Run Worker Completed because bgw can still be in wrong part of loop
            // where it checks the file size from the textbox
        }

        private void btnRefeshFTP_Click(object sender, EventArgs e)
        {
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Refresh();
            progressBar1.Value = 0;
            tbxFTPFileName.Clear();
            lbxZipFileList.Items.Clear();
            btnRefreshFTP.Enabled = false;
            tbxFTPFileName.Enabled = true;
            UpdateStatusStrip("Idle...");
        }

        private void UpdateStatusStrip(string message)
        {
            toolStripStatusLabel2.Text = message;
            statusStrip1.Refresh();
        }

        // FTP Stuff
        public string GetUpdateFile(string ZipFileName)
        {
            string fileURL = EUISettings.pFTPSourceFolder + ZipFileName;
            FtpWebRequest reqFTP;
            try
            {
                //Get the total file size on the ftp site
                long fs = GetFTPFileSize(ZipFileName);

                reqFTP = (FtpWebRequest)FtpWebRequest.Create(fileURL);
                reqFTP.Method = WebRequestMethods.Ftp.DownloadFile;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(EUISettings.uFTPUser, EUISettings.uFTPPassword);

                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                Stream ftpStream = response.GetResponseStream();

                //Create filestream after FTP requests in case an exception occurs (file doesn't exist for example)
                // Check destination folder exists, if not create it
                string DestFolder = @EUISettings.pDestFolder;
                if (!Directory.Exists(DestFolder))
                {
                    DirectoryInfo di = Directory.CreateDirectory(DestFolder);
                }

                FileStream outputStream = new FileStream(EUISettings.pDestFolder + ZipFileName, FileMode.Create);

                int bufferSize = 16384; //4096;
                int readCount;
                int prog = 0;
                byte[] buffer = new byte[bufferSize];

                readCount = ftpStream.Read(buffer, 0, bufferSize);
                while (readCount > 0)
                {
                    if (bgwGetFileFromFTP.CancellationPending)
                    {
                        reqFTP.Abort();
                        outputStream.Close();
                        return ZipFileName + " download cancelled";
                    }
                    else
                    {
                        outputStream.Write(buffer, 0, readCount);
                        long ops = outputStream.Length;
                        readCount = ftpStream.Read(buffer, 0, bufferSize);

                        float flops = (float)ops;
                        float flfs = (float)fs;
                        float fl = ((flops / flfs) * 100);
                        prog = (int)Math.Ceiling(fl);

                        bgwGetFileFromFTP.ReportProgress((prog));
                    }
                }

                ftpStream.Close();
                outputStream.Close();
                response.Close();

                bgwGetFileFromFTP.ReportProgress(100);
                return ZipFileName + " downloaded successfully";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public long GetFTPFileSize(string ZipFileName)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(EUISettings.pFTPSourceFolder + ZipFileName);
                request.Method = WebRequestMethods.Ftp.GetFileSize;
                request.Credentials = new NetworkCredential(EUISettings.uFTPUser, EUISettings.uFTPPassword);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                long size = response.ContentLength;

                response.Close();
                return size;
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                //UpdateStatusStrip(ex.Message);
                return 0;
            }
        }

        private void pathsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pathsForm = new Form2();
            pathsForm.ShowDialog();

        }

        private void fTPSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var settingsFTP = new Form2();
            settingsFTP.tabControl1.SelectedIndex = 1;
            settingsFTP.ShowDialog();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cBxDest_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = cBxDest.SelectedItem.ToString();

            switch (s)
            {
                case "4.0.1":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP401URL;
                    EUISettings.pDestFolder = EUISettings.uFolder401;
                    break;

                case "4.1.0":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP410URL;
                    EUISettings.pDestFolder = EUISettings.uFolder410;
                    break;

                case "4.1.1":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP411URL;
                    EUISettings.pDestFolder = EUISettings.uFolder411;
                    break;

                case "4.2.0":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP420URL;
                    EUISettings.pDestFolder = EUISettings.uFolder420;
                    break;

                case "5.0.0":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP500URL;
                    EUISettings.pDestFolder = EUISettings.uFolder500;
                    break;

                case "5.1.0":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP510URL;
                    EUISettings.pDestFolder = EUISettings.uFolder510;
                    break;

                case "5.2.0":
                    EUISettings.pFTPSourceFolder = EUISettings.uFTP520URL;
                    EUISettings.pDestFolder = EUISettings.uFolder520;
                    break;

                case "Root":
                    EUISettings.pFTPSourceFolder = EUISettings.pFTPRoot;
                    EUISettings.pDestFolder = EUISettings.uRootFolder;
                    break;

                case "Internal":
                    EUISettings.pFTPSourceFolder = EUISettings.pFTPInternal;
                    EUISettings.pDestFolder = EUISettings.uRootFolder;
                    break;
            }

            // Set the testbox values to the selected folder
            tbxSourceFolder.Text = EUISettings.pDestFolder;
            tbxDestinationFolder.Text = EUISettings.pDestFolder;

        }



    }
}
