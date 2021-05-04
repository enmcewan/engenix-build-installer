namespace EngenixUpdateInstallerFTP
{
    partial class AppMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
            this.tbxSourceFolder = new System.Windows.Forms.TextBox();
            this.btnOpenExplorerSource = new System.Windows.Forms.Button();
            this.lbxZipFileList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.btnResetSourceFolder = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbxDestinationFolder = new System.Windows.Forms.TextBox();
            this.btnOpenExplorerDesination = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox32 = new System.Windows.Forms.CheckBox();
            this.checkBox31 = new System.Windows.Forms.CheckBox();
            this.checkBox30 = new System.Windows.Forms.CheckBox();
            this.checkBox29 = new System.Windows.Forms.CheckBox();
            this.checkBox28 = new System.Windows.Forms.CheckBox();
            this.checkBox27 = new System.Windows.Forms.CheckBox();
            this.checkBox23 = new System.Windows.Forms.CheckBox();
            this.checkBox24 = new System.Windows.Forms.CheckBox();
            this.checkBox20 = new System.Windows.Forms.CheckBox();
            this.checkBox21 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox25 = new System.Windows.Forms.CheckBox();
            this.checkBox22 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxFTPFileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetFileFTP = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bgwGetFileFromFTP = new System.ComponentModel.BackgroundWorker();
            this.bgwCheckFileSize = new System.ComponentModel.BackgroundWorker();
            this.btnCancelFTP = new System.Windows.Forms.Button();
            this.btnRefreshFTP = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox26 = new System.Windows.Forms.CheckBox();
            this.cBxDest = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fTPSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox33 = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSourceFolder
            // 
            this.tbxSourceFolder.Enabled = false;
            this.tbxSourceFolder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbxSourceFolder.Location = new System.Drawing.Point(87, 402);
            this.tbxSourceFolder.Name = "tbxSourceFolder";
            this.tbxSourceFolder.Size = new System.Drawing.Size(284, 20);
            this.tbxSourceFolder.TabIndex = 0;
            this.tbxSourceFolder.TabStop = false;
            this.tbxSourceFolder.Text = "C:\\Engenix\\410\\";
            this.tbxSourceFolder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOpenExplorerSource
            // 
            this.btnOpenExplorerSource.FlatAppearance.BorderSize = 0;
            this.btnOpenExplorerSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExplorerSource.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenExplorerSource.Image")));
            this.btnOpenExplorerSource.Location = new System.Drawing.Point(413, 399);
            this.btnOpenExplorerSource.Name = "btnOpenExplorerSource";
            this.btnOpenExplorerSource.Size = new System.Drawing.Size(23, 23);
            this.btnOpenExplorerSource.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnOpenExplorerSource, "Search for a new Source Folder");
            this.btnOpenExplorerSource.UseVisualStyleBackColor = true;
            this.btnOpenExplorerSource.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbxZipFileList
            // 
            this.lbxZipFileList.ContextMenuStrip = this.contextMenuStrip1;
            this.lbxZipFileList.FormattingEnabled = true;
            this.lbxZipFileList.Location = new System.Drawing.Point(88, 459);
            this.lbxZipFileList.Name = "lbxZipFileList";
            this.lbxZipFileList.Size = new System.Drawing.Size(381, 212);
            this.lbxZipFileList.TabIndex = 32;
            this.lbxZipFileList.TabStop = false;
            this.toolTip1.SetToolTip(this.lbxZipFileList, "Select a zip file then right-click  to extract");
            this.lbxZipFileList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doThisToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(235, 26);
            // 
            // doThisToolStripMenuItem
            // 
            this.doThisToolStripMenuItem.Name = "doThisToolStripMenuItem";
            this.doThisToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.doThisToolStripMenuItem.Text = "Install New Apps from this .zip";
            this.doThisToolStripMenuItem.Click += new System.EventHandler(this.doThisToolStripMenuItem_Click);
            // 
            // btnSelectSourceFolder
            // 
            this.btnSelectSourceFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSourceFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectSourceFolder.Image")));
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(384, 399);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(23, 23);
            this.btnSelectSourceFolder.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnSelectSourceFolder, "List current zip files from this folder");
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResetSourceFolder
            // 
            this.btnResetSourceFolder.FlatAppearance.BorderSize = 0;
            this.btnResetSourceFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetSourceFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnResetSourceFolder.Image")));
            this.btnResetSourceFolder.Location = new System.Drawing.Point(442, 399);
            this.btnResetSourceFolder.Name = "btnResetSourceFolder";
            this.btnResetSourceFolder.Size = new System.Drawing.Size(23, 23);
            this.btnResetSourceFolder.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnResetSourceFolder, "Reset Source Folder");
            this.btnResetSourceFolder.UseVisualStyleBackColor = true;
            this.btnResetSourceFolder.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 23);
            // 
            // tbxDestinationFolder
            // 
            this.tbxDestinationFolder.Enabled = false;
            this.tbxDestinationFolder.Location = new System.Drawing.Point(87, 428);
            this.tbxDestinationFolder.Name = "tbxDestinationFolder";
            this.tbxDestinationFolder.Size = new System.Drawing.Size(284, 20);
            this.tbxDestinationFolder.TabIndex = 4;
            this.tbxDestinationFolder.TabStop = false;
            this.tbxDestinationFolder.Text = "C:\\Engenix\\410";
            this.tbxDestinationFolder.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnOpenExplorerDesination
            // 
            this.btnOpenExplorerDesination.FlatAppearance.BorderSize = 0;
            this.btnOpenExplorerDesination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenExplorerDesination.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenExplorerDesination.Image")));
            this.btnOpenExplorerDesination.Location = new System.Drawing.Point(384, 425);
            this.btnOpenExplorerDesination.Name = "btnOpenExplorerDesination";
            this.btnOpenExplorerDesination.Size = new System.Drawing.Size(23, 23);
            this.btnOpenExplorerDesination.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnOpenExplorerDesination, "Search for a new Destination Folder");
            this.btnOpenExplorerDesination.UseVisualStyleBackColor = true;
            this.btnOpenExplorerDesination.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Source Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Zip Files";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox33);
            this.groupBox1.Controls.Add(this.checkBox32);
            this.groupBox1.Controls.Add(this.checkBox31);
            this.groupBox1.Controls.Add(this.checkBox30);
            this.groupBox1.Controls.Add(this.checkBox29);
            this.groupBox1.Controls.Add(this.checkBox28);
            this.groupBox1.Controls.Add(this.checkBox27);
            this.groupBox1.Controls.Add(this.checkBox23);
            this.groupBox1.Controls.Add(this.checkBox24);
            this.groupBox1.Controls.Add(this.checkBox20);
            this.groupBox1.Controls.Add(this.checkBox21);
            this.groupBox1.Controls.Add(this.checkBox18);
            this.groupBox1.Controls.Add(this.checkBox14);
            this.groupBox1.Controls.Add(this.checkBox15);
            this.groupBox1.Controls.Add(this.checkBox16);
            this.groupBox1.Controls.Add(this.checkBox11);
            this.groupBox1.Controls.Add(this.checkBox12);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(187, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 303);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Types";
            // 
            // checkBox32
            // 
            this.checkBox32.AutoSize = true;
            this.checkBox32.Location = new System.Drawing.Point(26, 200);
            this.checkBox32.Name = "checkBox32";
            this.checkBox32.Size = new System.Drawing.Size(73, 17);
            this.checkBox32.TabIndex = 33;
            this.checkBox32.TabStop = false;
            this.checkBox32.Tag = "E2B_Bacon.exe";
            this.checkBox32.Text = "E2 Bacon";
            this.toolTip1.SetToolTip(this.checkBox32, "Select  File Type");
            this.checkBox32.UseVisualStyleBackColor = true;
            // 
            // checkBox31
            // 
            this.checkBox31.AutoSize = true;
            this.checkBox31.Location = new System.Drawing.Point(102, 200);
            this.checkBox31.Name = "checkBox31";
            this.checkBox31.Size = new System.Drawing.Size(100, 17);
            this.checkBox31.TabIndex = 32;
            this.checkBox31.TabStop = false;
            this.checkBox31.Tag = "EngenixServiceMonitor.exe";
            this.checkBox31.Text = "Service Monitor";
            this.toolTip1.SetToolTip(this.checkBox31, "Select  File Type");
            this.checkBox31.UseVisualStyleBackColor = true;
            // 
            // checkBox30
            // 
            this.checkBox30.AutoSize = true;
            this.checkBox30.Location = new System.Drawing.Point(102, 177);
            this.checkBox30.Name = "checkBox30";
            this.checkBox30.Size = new System.Drawing.Size(86, 17);
            this.checkBox30.TabIndex = 31;
            this.checkBox30.TabStop = false;
            this.checkBox30.Tag = "E2S_Schoeller.exe";
            this.checkBox30.Text = "E2 Schoeller";
            this.toolTip1.SetToolTip(this.checkBox30, "Select  File Type");
            this.checkBox30.UseVisualStyleBackColor = true;
            // 
            // checkBox29
            // 
            this.checkBox29.AutoSize = true;
            this.checkBox29.Location = new System.Drawing.Point(26, 177);
            this.checkBox29.Name = "checkBox29";
            this.checkBox29.Size = new System.Drawing.Size(62, 17);
            this.checkBox29.TabIndex = 30;
            this.checkBox29.TabStop = false;
            this.checkBox29.Tag = "E2S_SageX3.exe";
            this.checkBox29.Text = "E2 SX3";
            this.toolTip1.SetToolTip(this.checkBox29, "Select  File Type");
            this.checkBox29.UseVisualStyleBackColor = true;
            // 
            // checkBox28
            // 
            this.checkBox28.AutoSize = true;
            this.checkBox28.Location = new System.Drawing.Point(102, 131);
            this.checkBox28.Name = "checkBox28";
            this.checkBox28.Size = new System.Drawing.Size(93, 17);
            this.checkBox28.TabIndex = 29;
            this.checkBox28.TabStop = false;
            this.checkBox28.Tag = "E2P_Paradigm_BOM.exe";
            this.checkBox28.Text = "E2 PDM BOM";
            this.toolTip1.SetToolTip(this.checkBox28, "Select  File Type");
            this.checkBox28.UseVisualStyleBackColor = true;
            // 
            // checkBox27
            // 
            this.checkBox27.AutoSize = true;
            this.checkBox27.Location = new System.Drawing.Point(26, 85);
            this.checkBox27.Name = "checkBox27";
            this.checkBox27.Size = new System.Drawing.Size(46, 17);
            this.checkBox27.TabIndex = 28;
            this.checkBox27.TabStop = false;
            this.checkBox27.Tag = "*.BPL";
            this.checkBox27.Text = "BPL";
            this.toolTip1.SetToolTip(this.checkBox27, "Toggle File Types (All apps must also be checked)");
            this.checkBox27.UseVisualStyleBackColor = true;
            this.checkBox27.CheckedChanged += new System.EventHandler(this.checkBox27_CheckedChanged);
            // 
            // checkBox23
            // 
            this.checkBox23.AutoSize = true;
            this.checkBox23.Location = new System.Drawing.Point(26, 272);
            this.checkBox23.Name = "checkBox23";
            this.checkBox23.Size = new System.Drawing.Size(46, 17);
            this.checkBox23.TabIndex = 26;
            this.checkBox23.TabStop = false;
            this.checkBox23.Tag = "EngenixWS.dll";
            this.checkBox23.Text = "DLL";
            this.toolTip1.SetToolTip(this.checkBox23, "Select  File Type");
            this.checkBox23.UseVisualStyleBackColor = true;
            // 
            // checkBox24
            // 
            this.checkBox24.AutoSize = true;
            this.checkBox24.Location = new System.Drawing.Point(102, 272);
            this.checkBox24.Name = "checkBox24";
            this.checkBox24.Size = new System.Drawing.Size(47, 17);
            this.checkBox24.TabIndex = 27;
            this.checkBox24.TabStop = false;
            this.checkBox24.Tag = "EngenixWSClient.exe";
            this.checkBox24.Text = "EXE";
            this.toolTip1.SetToolTip(this.checkBox24, "Select  File Type");
            this.checkBox24.UseVisualStyleBackColor = true;
            // 
            // checkBox20
            // 
            this.checkBox20.AutoSize = true;
            this.checkBox20.Location = new System.Drawing.Point(26, 249);
            this.checkBox20.Name = "checkBox20";
            this.checkBox20.Size = new System.Drawing.Size(42, 17);
            this.checkBox20.TabIndex = 23;
            this.checkBox20.TabStop = false;
            this.checkBox20.Tag = "WebEngenix_Pro.zip";
            this.checkBox20.Text = "Pro";
            this.toolTip1.SetToolTip(this.checkBox20, "Select  File Type");
            this.checkBox20.UseVisualStyleBackColor = true;
            this.checkBox20.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // checkBox21
            // 
            this.checkBox21.AutoSize = true;
            this.checkBox21.Location = new System.Drawing.Point(102, 249);
            this.checkBox21.Name = "checkBox21";
            this.checkBox21.Size = new System.Drawing.Size(70, 17);
            this.checkBox21.TabIndex = 24;
            this.checkBox21.TabStop = false;
            this.checkBox21.Tag = "WebEngenix_Ent.zip";
            this.checkBox21.Text = "Enteprise";
            this.toolTip1.SetToolTip(this.checkBox21, "Select  File Type");
            this.checkBox21.UseVisualStyleBackColor = true;
            this.checkBox21.CheckedChanged += new System.EventHandler(this.checkBox21_CheckedChanged);
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.Location = new System.Drawing.Point(26, 226);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(76, 17);
            this.checkBox18.TabIndex = 21;
            this.checkBox18.TabStop = false;
            this.checkBox18.Tag = "DBSwitch.exe";
            this.checkBox18.Text = "DB Switch";
            this.toolTip1.SetToolTip(this.checkBox18, "Select  File Type");
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(26, 131);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(66, 17);
            this.checkBox14.TabIndex = 17;
            this.checkBox14.TabStop = false;
            this.checkBox14.Tag = "E2P_Paradigm.exe";
            this.checkBox14.Text = "E2 PDM";
            this.toolTip1.SetToolTip(this.checkBox14, "Select  File Type");
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(26, 154);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(63, 17);
            this.checkBox15.TabIndex = 18;
            this.checkBox15.TabStop = false;
            this.checkBox15.Tag = "E2S_ATS.exe";
            this.checkBox15.Text = "E2 ATS";
            this.toolTip1.SetToolTip(this.checkBox15, "Select  File Type");
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(102, 154);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(97, 17);
            this.checkBox16.TabIndex = 19;
            this.checkBox16.TabStop = false;
            this.checkBox16.Tag = "Engenix2ATSServer.exe";
            this.checkBox16.Text = "E2 ATS Server";
            this.toolTip1.SetToolTip(this.checkBox16, "Select  File Type");
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(26, 62);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(48, 17);
            this.checkBox11.TabIndex = 14;
            this.checkBox11.TabStop = false;
            this.checkBox11.Tag = "EngenixECN.exe";
            this.checkBox11.Text = "ECN";
            this.toolTip1.SetToolTip(this.checkBox11, "Select  File Type");
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(102, 62);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(64, 17);
            this.checkBox12.TabIndex = 15;
            this.checkBox12.TabStop = false;
            this.checkBox12.Tag = "AdvancedQuery.exe";
            this.checkBox12.Text = "Adv Qry";
            this.toolTip1.SetToolTip(this.checkBox12, "Select  File Type");
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(26, 108);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(47, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.TabStop = false;
            this.checkBox7.Tag = "Engenix_update.sql";
            this.checkBox7.Text = "SQL";
            this.toolTip1.SetToolTip(this.checkBox7, "Select  File Type");
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(102, 108);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(68, 17);
            this.checkBox9.TabIndex = 12;
            this.checkBox9.TabStop = false;
            this.checkBox9.Tag = "DBScriptExternalFiles.zip";
            this.checkBox9.Text = "Ext. Files";
            this.toolTip1.SetToolTip(this.checkBox9, "Select  File Type");
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(26, 39);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(42, 17);
            this.checkBox5.TabIndex = 8;
            this.checkBox5.TabStop = false;
            this.checkBox5.Tag = "ConfigurationManager.exe";
            this.checkBox5.Text = "Pro";
            this.toolTip1.SetToolTip(this.checkBox5, "Select  File Type");
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(102, 39);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 17);
            this.checkBox6.TabIndex = 9;
            this.checkBox6.TabStop = false;
            this.checkBox6.Tag = "ConfigurationManagerEnterprise.exe";
            this.checkBox6.Text = "Enterprise";
            this.toolTip1.SetToolTip(this.checkBox6, "Select  File Type");
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(26, 16);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(42, 17);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.TabStop = false;
            this.checkBox4.Tag = "Engenix.exe";
            this.checkBox4.Text = "Pro";
            this.toolTip1.SetToolTip(this.checkBox4, "Select  File Type");
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(102, 16);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(73, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.TabStop = false;
            this.checkBox3.Tag = "EngenixEnterprise.exe";
            this.checkBox3.Text = "Enterprise";
            this.toolTip1.SetToolTip(this.checkBox3, "Select  File Type");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(180, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(40, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.TabStop = false;
            this.checkBox2.Tag = "EngenixST.exe";
            this.checkBox2.Text = "ST";
            this.toolTip1.SetToolTip(this.checkBox2, "Select  File Type");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox25
            // 
            this.checkBox25.AutoSize = true;
            this.checkBox25.Location = new System.Drawing.Point(88, 358);
            this.checkBox25.Name = "checkBox25";
            this.checkBox25.Size = new System.Drawing.Size(93, 17);
            this.checkBox25.TabIndex = 25;
            this.checkBox25.TabStop = false;
            this.checkBox25.Text = "Web Services";
            this.toolTip1.SetToolTip(this.checkBox25, "Toggle File Types");
            this.checkBox25.UseVisualStyleBackColor = true;
            this.checkBox25.CheckedChanged += new System.EventHandler(this.checkBox25_CheckedChanged);
            // 
            // checkBox22
            // 
            this.checkBox22.AutoSize = true;
            this.checkBox22.Location = new System.Drawing.Point(88, 335);
            this.checkBox22.Name = "checkBox22";
            this.checkBox22.Size = new System.Drawing.Size(79, 17);
            this.checkBox22.TabIndex = 22;
            this.checkBox22.TabStop = false;
            this.checkBox22.Text = "Web Portal";
            this.toolTip1.SetToolTip(this.checkBox22, "Toggle File Types");
            this.checkBox22.UseVisualStyleBackColor = true;
            this.checkBox22.CheckedChanged += new System.EventHandler(this.checkBox22_CheckedChanged);
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.Location = new System.Drawing.Point(88, 312);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(59, 17);
            this.checkBox19.TabIndex = 20;
            this.checkBox19.TabStop = false;
            this.checkBox19.Text = "Utilities";
            this.toolTip1.SetToolTip(this.checkBox19, "Toggle File Types");
            this.checkBox19.UseVisualStyleBackColor = true;
            this.checkBox19.CheckedChanged += new System.EventHandler(this.checkBox19_CheckedChanged);
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.Location = new System.Drawing.Point(88, 217);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(47, 17);
            this.checkBox17.TabIndex = 16;
            this.checkBox17.TabStop = false;
            this.checkBox17.Text = "Asta";
            this.toolTip1.SetToolTip(this.checkBox17, "Toggle File Types");
            this.checkBox17.UseVisualStyleBackColor = true;
            this.checkBox17.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(88, 148);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(51, 17);
            this.checkBox13.TabIndex = 13;
            this.checkBox13.TabStop = false;
            this.checkBox13.Text = "Misc.";
            this.toolTip1.SetToolTip(this.checkBox13, "Toggle File Types");
            this.checkBox13.UseVisualStyleBackColor = true;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(88, 194);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(71, 17);
            this.checkBox10.TabIndex = 10;
            this.checkBox10.TabStop = false;
            this.checkBox10.Text = "SQL Files";
            this.toolTip1.SetToolTip(this.checkBox10, "Toggle File Types");
            this.checkBox10.UseVisualStyleBackColor = true;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(88, 125);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.TabStop = false;
            this.checkBox8.Text = "Config Mgr.";
            this.toolTip1.SetToolTip(this.checkBox8, "Toggle File Types");
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(88, 102);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Engenix";
            this.toolTip1.SetToolTip(this.checkBox1, "Toggle File Types");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Select Files";
            // 
            // tbxFTPFileName
            // 
            this.tbxFTPFileName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxFTPFileName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tbxFTPFileName.Location = new System.Drawing.Point(88, 32);
            this.tbxFTPFileName.Name = "tbxFTPFileName";
            this.tbxFTPFileName.Size = new System.Drawing.Size(212, 20);
            this.tbxFTPFileName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbxFTPFileName, "Enter a valid Engenix Update .zip file");
            this.tbxFTPFileName.TextChanged += new System.EventHandler(this.tbxFTPFileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "FTP File";
            // 
            // btnGetFileFTP
            // 
            this.btnGetFileFTP.Enabled = false;
            this.btnGetFileFTP.FlatAppearance.BorderSize = 0;
            this.btnGetFileFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetFileFTP.Image = ((System.Drawing.Image)(resources.GetObject("btnGetFileFTP.Image")));
            this.btnGetFileFTP.Location = new System.Drawing.Point(388, 30);
            this.btnGetFileFTP.Name = "btnGetFileFTP";
            this.btnGetFileFTP.Size = new System.Drawing.Size(23, 23);
            this.btnGetFileFTP.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnGetFileFTP, "Start FTP download");
            this.btnGetFileFTP.UseVisualStyleBackColor = true;
            this.btnGetFileFTP.Click += new System.EventHandler(this.GetFileFTP_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "FTP Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(88, 60);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(381, 20);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 2;
            // 
            // btnCancelFTP
            // 
            this.btnCancelFTP.Enabled = false;
            this.btnCancelFTP.FlatAppearance.BorderSize = 0;
            this.btnCancelFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelFTP.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelFTP.Image")));
            this.btnCancelFTP.Location = new System.Drawing.Point(417, 30);
            this.btnCancelFTP.Name = "btnCancelFTP";
            this.btnCancelFTP.Size = new System.Drawing.Size(23, 23);
            this.btnCancelFTP.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnCancelFTP, "Cancel FTP download");
            this.btnCancelFTP.UseVisualStyleBackColor = true;
            this.btnCancelFTP.Click += new System.EventHandler(this.btnCancelFTP_Click);
            // 
            // btnRefreshFTP
            // 
            this.btnRefreshFTP.Enabled = false;
            this.btnRefreshFTP.FlatAppearance.BorderSize = 0;
            this.btnRefreshFTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshFTP.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshFTP.Image")));
            this.btnRefreshFTP.Location = new System.Drawing.Point(446, 30);
            this.btnRefreshFTP.Name = "btnRefreshFTP";
            this.btnRefreshFTP.Size = new System.Drawing.Size(23, 23);
            this.btnRefreshFTP.TabIndex = 3;
            this.btnRefreshFTP.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRefreshFTP, "Reset FTP controls");
            this.btnRefreshFTP.UseVisualStyleBackColor = true;
            this.btnRefreshFTP.Click += new System.EventHandler(this.btnRefeshFTP_Click);
            // 
            // checkBox26
            // 
            this.checkBox26.AutoSize = true;
            this.checkBox26.Location = new System.Drawing.Point(88, 171);
            this.checkBox26.Name = "checkBox26";
            this.checkBox26.Size = new System.Drawing.Size(46, 17);
            this.checkBox26.TabIndex = 35;
            this.checkBox26.TabStop = false;
            this.checkBox26.Text = "BPL";
            this.toolTip1.SetToolTip(this.checkBox26, "Toggle File Types (All apps must also be checked)");
            this.checkBox26.UseVisualStyleBackColor = true;
            this.checkBox26.CheckedChanged += new System.EventHandler(this.checkBox26_CheckedChanged);
            // 
            // cBxDest
            // 
            this.cBxDest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxDest.FormattingEnabled = true;
            this.cBxDest.IntegralHeight = false;
            this.cBxDest.Items.AddRange(new object[] {
            "Root",
            "4.0.1",
            "4.1.0",
            "4.1.1",
            "4.2.0",
            "5.0.0",
            "Internal"});
            this.cBxDest.Location = new System.Drawing.Point(306, 31);
            this.cBxDest.Name = "cBxDest";
            this.cBxDest.Size = new System.Drawing.Size(76, 21);
            this.cBxDest.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cBxDest, "Select FTP folder");
            this.cBxDest.SelectedIndexChanged += new System.EventHandler(this.cBxDest_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(496, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 34;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel2.Text = "Idle...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(496, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pathsToolStripMenuItem,
            this.fTPSettingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // pathsToolStripMenuItem
            // 
            this.pathsToolStripMenuItem.Name = "pathsToolStripMenuItem";
            this.pathsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.pathsToolStripMenuItem.Text = "Paths...";
            this.pathsToolStripMenuItem.Click += new System.EventHandler(this.pathsToolStripMenuItem_Click);
            // 
            // fTPSettingsToolStripMenuItem
            // 
            this.fTPSettingsToolStripMenuItem.Name = "fTPSettingsToolStripMenuItem";
            this.fTPSettingsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.fTPSettingsToolStripMenuItem.Text = "FTP Settings...";
            this.fTPSettingsToolStripMenuItem.Click += new System.EventHandler(this.fTPSettingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // checkBox33
            // 
            this.checkBox33.AutoSize = true;
            this.checkBox33.Location = new System.Drawing.Point(236, 16);
            this.checkBox33.Name = "checkBox33";
            this.checkBox33.Size = new System.Drawing.Size(41, 17);
            this.checkBox33.TabIndex = 34;
            this.checkBox33.TabStop = false;
            this.checkBox33.Tag = "EngenixQT.exe";
            this.checkBox33.Text = "QT";
            this.toolTip1.SetToolTip(this.checkBox33, "Select  File Type");
            this.checkBox33.UseVisualStyleBackColor = true;
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 705);
            this.Controls.Add(this.cBxDest);
            this.Controls.Add(this.checkBox26);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRefreshFTP);
            this.Controls.Add(this.checkBox25);
            this.Controls.Add(this.btnCancelFTP);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox22);
            this.Controls.Add(this.btnGetFileFTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox19);
            this.Controls.Add(this.tbxFTPFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox17);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenExplorerDesination);
            this.Controls.Add(this.checkBox13);
            this.Controls.Add(this.tbxDestinationFolder);
            this.Controls.Add(this.btnResetSourceFolder);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Controls.Add(this.checkBox10);
            this.Controls.Add(this.lbxZipFileList);
            this.Controls.Add(this.btnOpenExplorerSource);
            this.Controls.Add(this.tbxSourceFolder);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AppMainForm";
            this.Text = "Engenix Update Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenExplorerSource;
        private System.Windows.Forms.ListBox lbxZipFileList;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.Button btnResetSourceFolder;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doThisToolStripMenuItem;
        private System.Windows.Forms.Button btnOpenExplorerDesination;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox23;
        private System.Windows.Forms.CheckBox checkBox24;
        private System.Windows.Forms.CheckBox checkBox25;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private System.Windows.Forms.CheckBox checkBox22;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxFTPFileName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetFileFTP;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbxSourceFolder;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker bgwGetFileFromFTP;
        private System.ComponentModel.BackgroundWorker bgwCheckFileSize;
        private System.Windows.Forms.Button btnCancelFTP;
        private System.Windows.Forms.Button btnRefreshFTP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        public System.Windows.Forms.TextBox tbxDestinationFolder;
        private System.Windows.Forms.CheckBox checkBox27;
        private System.Windows.Forms.CheckBox checkBox26;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pathsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fTPSettingsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBxDest;
        private System.Windows.Forms.CheckBox checkBox28;
        private System.Windows.Forms.CheckBox checkBox31;
        private System.Windows.Forms.CheckBox checkBox30;
        private System.Windows.Forms.CheckBox checkBox29;
        private System.Windows.Forms.CheckBox checkBox32;
        private System.Windows.Forms.CheckBox checkBox33;
    }
}