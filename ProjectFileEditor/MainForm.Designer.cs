namespace ProjectFileEditor
{
    partial class MainForm
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
            this.btnOpenProjectFiles = new System.Windows.Forms.Button();
            this.btnCopyLibs = new System.Windows.Forms.Button();
            this.grpUpdateThirdpartyLibs = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSolutionDirectoryPath = new System.Windows.Forms.TextBox();
            this.btnBrowseSolutionDirectory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtInfragisticsSimergyLibPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSimplebimLibPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtInfagisticsVersionedLibPath = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grpDevExpressLib = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.txtInfagisticsVersionFreeLibPath = new System.Windows.Forms.TextBox();
            this.btnCopyInfragisticsLibraries = new System.Windows.Forms.Button();
            this.grpUpdateThirdpartyLibs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpDevExpressLib.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenProjectFiles
            // 
            this.btnOpenProjectFiles.Location = new System.Drawing.Point(394, 7);
            this.btnOpenProjectFiles.Name = "btnOpenProjectFiles";
            this.btnOpenProjectFiles.Size = new System.Drawing.Size(108, 37);
            this.btnOpenProjectFiles.TabIndex = 0;
            this.btnOpenProjectFiles.Text = "Open project files in Notepad++";
            this.btnOpenProjectFiles.UseVisualStyleBackColor = true;
            this.btnOpenProjectFiles.Click += new System.EventHandler(this.btnOpenProjectFiles_Click);
            // 
            // btnCopyLibs
            // 
            this.btnCopyLibs.Location = new System.Drawing.Point(630, 62);
            this.btnCopyLibs.Name = "btnCopyLibs";
            this.btnCopyLibs.Size = new System.Drawing.Size(124, 23);
            this.btnCopyLibs.TabIndex = 1;
            this.btnCopyLibs.Text = "button1";
            this.btnCopyLibs.UseVisualStyleBackColor = true;
            this.btnCopyLibs.Click += new System.EventHandler(this.btnCopyLibs_Click);
            // 
            // grpUpdateThirdpartyLibs
            // 
            this.grpUpdateThirdpartyLibs.Controls.Add(this.groupBox1);
            this.grpUpdateThirdpartyLibs.Controls.Add(this.grpDevExpressLib);
            this.grpUpdateThirdpartyLibs.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpUpdateThirdpartyLibs.Location = new System.Drawing.Point(0, 0);
            this.grpUpdateThirdpartyLibs.Name = "grpUpdateThirdpartyLibs";
            this.grpUpdateThirdpartyLibs.Size = new System.Drawing.Size(766, 338);
            this.grpUpdateThirdpartyLibs.TabIndex = 2;
            this.grpUpdateThirdpartyLibs.TabStop = false;
            this.grpUpdateThirdpartyLibs.Text = "Update Thirdparty Libraries";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(726, 29);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(337, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "D:\\TFS-Shared\\Simergy\\Simergy_Source\\Development\\Dev_2_6\\ThirdPartyLibraries\\DevE" +
    "xpress\\16.1.12.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Target Library Directory";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "C:\\Program Files (x86)\\DevExpress 16.1\\Components\\Bin\\Framework";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source Library Directory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Solution Directory";
            // 
            // txtSolutionDirectoryPath
            // 
            this.txtSolutionDirectoryPath.Location = new System.Drawing.Point(10, 24);
            this.txtSolutionDirectoryPath.Name = "txtSolutionDirectoryPath";
            this.txtSolutionDirectoryPath.Size = new System.Drawing.Size(337, 20);
            this.txtSolutionDirectoryPath.TabIndex = 4;
            this.txtSolutionDirectoryPath.Text = "D:\\TFS\\Simergy\\Simergy_Source\\Development\\Dev_2_3";
            // 
            // btnBrowseSolutionDirectory
            // 
            this.btnBrowseSolutionDirectory.Location = new System.Drawing.Point(352, 22);
            this.btnBrowseSolutionDirectory.Name = "btnBrowseSolutionDirectory";
            this.btnBrowseSolutionDirectory.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseSolutionDirectory.TabIndex = 5;
            this.btnBrowseSolutionDirectory.Text = "...";
            this.btnBrowseSolutionDirectory.UseVisualStyleBackColor = true;
            this.btnBrowseSolutionDirectory.Click += new System.EventHandler(this.btnBrowseSolutionDirectory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSolutionDirectoryPath);
            this.panel1.Controls.Add(this.btnBrowseSolutionDirectory);
            this.panel1.Controls.Add(this.btnOpenProjectFiles);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 65);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(726, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtInfragisticsSimergyLibPath
            // 
            this.txtInfragisticsSimergyLibPath.Location = new System.Drawing.Point(384, 72);
            this.txtInfragisticsSimergyLibPath.Name = "txtInfragisticsSimergyLibPath";
            this.txtInfragisticsSimergyLibPath.Size = new System.Drawing.Size(337, 20);
            this.txtInfragisticsSimergyLibPath.TabIndex = 16;
            this.txtInfragisticsSimergyLibPath.Text = "D:\\TFS-Shared\\Simergy\\Simergy_Source\\Development\\Dev_3_3\\ThirdPartyLibraries\\Infr" +
    "agistics\\CLR4.0_2017.2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Target Library Directory";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(26, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtSimplebimLibPath
            // 
            this.txtSimplebimLibPath.Location = new System.Drawing.Point(9, 72);
            this.txtSimplebimLibPath.Name = "txtSimplebimLibPath";
            this.txtSimplebimLibPath.Size = new System.Drawing.Size(337, 20);
            this.txtSimplebimLibPath.TabIndex = 13;
            this.txtSimplebimLibPath.Text = "D:\\TFS-Shared\\Simergy\\Simergy_Source\\Development\\Dev_3_3\\ThirdPartyLibraries\\Simp" +
    "leBim.Developer\\x64";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "SimpleBim Source Library Directory";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(351, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtInfagisticsVersionedLibPath
            // 
            this.txtInfagisticsVersionedLibPath.Location = new System.Drawing.Point(9, 31);
            this.txtInfagisticsVersionedLibPath.Name = "txtInfagisticsVersionedLibPath";
            this.txtInfagisticsVersionedLibPath.Size = new System.Drawing.Size(337, 20);
            this.txtInfagisticsVersionedLibPath.TabIndex = 19;
            this.txtInfagisticsVersionedLibPath.Text = "C:\\Program Files (x86)\\Infragistics\\2017.2\\Windows Forms\\CLR4.0\\Bin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Infragistics UI Edit Lib Path";
            // 
            // grpDevExpressLib
            // 
            this.grpDevExpressLib.Controls.Add(this.label2);
            this.grpDevExpressLib.Controls.Add(this.textBox1);
            this.grpDevExpressLib.Controls.Add(this.button2);
            this.grpDevExpressLib.Controls.Add(this.label3);
            this.grpDevExpressLib.Controls.Add(this.textBox2);
            this.grpDevExpressLib.Controls.Add(this.button3);
            this.grpDevExpressLib.Controls.Add(this.btnCopyLibs);
            this.grpDevExpressLib.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDevExpressLib.Location = new System.Drawing.Point(3, 16);
            this.grpDevExpressLib.Name = "grpDevExpressLib";
            this.grpDevExpressLib.Size = new System.Drawing.Size(760, 91);
            this.grpDevExpressLib.TabIndex = 21;
            this.grpDevExpressLib.TabStop = false;
            this.grpDevExpressLib.Text = "DevExpress Libraries";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCopyInfragisticsLibraries);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.txtInfagisticsVersionFreeLibPath);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.txtSimplebimLibPath);
            this.groupBox1.Controls.Add(this.txtInfagisticsVersionedLibPath);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtInfragisticsSimergyLibPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 133);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Infragistics Libraries";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Infragistics Version-Free Lib Path";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(726, 29);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 23);
            this.button6.TabIndex = 23;
            this.button6.Text = "...";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // txtInfagisticsVersionFreeLibPath
            // 
            this.txtInfagisticsVersionFreeLibPath.Location = new System.Drawing.Point(384, 31);
            this.txtInfagisticsVersionFreeLibPath.Name = "txtInfagisticsVersionFreeLibPath";
            this.txtInfagisticsVersionFreeLibPath.Size = new System.Drawing.Size(337, 20);
            this.txtInfagisticsVersionFreeLibPath.TabIndex = 22;
            this.txtInfagisticsVersionFreeLibPath.Text = "D:\\WinForms_20172_VersionFree";
            // 
            // btnCopyInfragisticsLibraries
            // 
            this.btnCopyInfragisticsLibraries.Location = new System.Drawing.Point(573, 104);
            this.btnCopyInfragisticsLibraries.Name = "btnCopyInfragisticsLibraries";
            this.btnCopyInfragisticsLibraries.Size = new System.Drawing.Size(178, 23);
            this.btnCopyInfragisticsLibraries.TabIndex = 24;
            this.btnCopyInfragisticsLibraries.Text = "Copy Infragistics Libraries";
            this.btnCopyInfragisticsLibraries.UseVisualStyleBackColor = true;
            this.btnCopyInfragisticsLibraries.Click += new System.EventHandler(this.btnCopyInfragisticsLibraries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpUpdateThirdpartyLibs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpUpdateThirdpartyLibs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpDevExpressLib.ResumeLayout(false);
            this.grpDevExpressLib.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProjectFiles;
        private System.Windows.Forms.Button btnCopyLibs;
        private System.Windows.Forms.GroupBox grpUpdateThirdpartyLibs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSolutionDirectoryPath;
        private System.Windows.Forms.Button btnBrowseSolutionDirectory;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCopyInfragisticsLibraries;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtInfagisticsVersionFreeLibPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSimplebimLibPath;
        private System.Windows.Forms.TextBox txtInfagisticsVersionedLibPath;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtInfragisticsSimergyLibPath;
        private System.Windows.Forms.GroupBox grpDevExpressLib;
    }
}

