namespace MicrOS_DevTools.Forms
{
    partial class NewEnvironmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEnvironmentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QemuInstallerLink = new System.Windows.Forms.LinkLabel();
            this.ImdiskInstallerLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.MsysInstallerLink = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MSYSTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectMSYSButton = new System.Windows.Forms.Button();
            this.CreateEnvironmentButton = new System.Windows.Forms.Button();
            this.SelectMSYSDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.VisualStudioCodeInstallerLink = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ProjectPathTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectMicrOSDirectoryButton = new System.Windows.Forms.Button();
            this.SelectMicrOSDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Procedura tworzenia nowego środowiska";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. QEMU (emulator procesora):";
            // 
            // QemuInstallerLink
            // 
            this.QemuInstallerLink.AutoSize = true;
            this.QemuInstallerLink.Location = new System.Drawing.Point(244, 156);
            this.QemuInstallerLink.Name = "QemuInstallerLink";
            this.QemuInstallerLink.Size = new System.Drawing.Size(119, 17);
            this.QemuInstallerLink.TabIndex = 3;
            this.QemuInstallerLink.TabStop = true;
            this.QemuInstallerLink.Text = "link do instalatora";
            this.QemuInstallerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.QemuInstallerLink_LinkClicked);
            // 
            // ImdiskInstallerLink
            // 
            this.ImdiskInstallerLink.AutoSize = true;
            this.ImdiskInstallerLink.Location = new System.Drawing.Point(244, 182);
            this.ImdiskInstallerLink.Name = "ImdiskInstallerLink";
            this.ImdiskInstallerLink.Size = new System.Drawing.Size(119, 17);
            this.ImdiskInstallerLink.TabIndex = 5;
            this.ImdiskInstallerLink.TabStop = true;
            this.ImdiskInstallerLink.Text = "link do instalatora";
            this.ImdiskInstallerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ImdiskInstallerLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "3. Imdisk (montowanie dyskietki):";
            // 
            // MsysInstallerLink
            // 
            this.MsysInstallerLink.AutoSize = true;
            this.MsysInstallerLink.Location = new System.Drawing.Point(244, 208);
            this.MsysInstallerLink.Name = "MsysInstallerLink";
            this.MsysInstallerLink.Size = new System.Drawing.Size(119, 17);
            this.MsysInstallerLink.TabIndex = 7;
            this.MsysInstallerLink.TabStop = true;
            this.MsysInstallerLink.Text = "link do instalatora";
            this.MsysInstallerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MsysInstallerLink_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "4. MSYS2 (środowisko Linuksowe):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(473, 51);
            this.label5.TabIndex = 8;
            this.label5.Text = "Należy zainstalować poniższe programy, a następnie wskazać ścieżkę do \r\nfolderu M" +
    "SYS2 i kliknąć przycisk \"Utwórz środowisko\". Status \"gotowe\" \r\nbędzie oznaczał, " +
    "że konfiguracja została zakończona.";
            // 
            // MSYSTextBox
            // 
            this.MSYSTextBox.Location = new System.Drawing.Point(193, 281);
            this.MSYSTextBox.Name = "MSYSTextBox";
            this.MSYSTextBox.ReadOnly = true;
            this.MSYSTextBox.Size = new System.Drawing.Size(202, 22);
            this.MSYSTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ścieżka do folderu MSYS2:";
            // 
            // SelectMSYSButton
            // 
            this.SelectMSYSButton.Location = new System.Drawing.Point(398, 276);
            this.SelectMSYSButton.Name = "SelectMSYSButton";
            this.SelectMSYSButton.Size = new System.Drawing.Size(84, 32);
            this.SelectMSYSButton.TabIndex = 9;
            this.SelectMSYSButton.Text = "Wybierz...";
            this.SelectMSYSButton.UseVisualStyleBackColor = true;
            this.SelectMSYSButton.Click += new System.EventHandler(this.SelectMSYSButton_Click);
            // 
            // CreateEnvironmentButton
            // 
            this.CreateEnvironmentButton.Enabled = false;
            this.CreateEnvironmentButton.Location = new System.Drawing.Point(340, 343);
            this.CreateEnvironmentButton.Name = "CreateEnvironmentButton";
            this.CreateEnvironmentButton.Size = new System.Drawing.Size(142, 37);
            this.CreateEnvironmentButton.TabIndex = 12;
            this.CreateEnvironmentButton.Text = "Utwórz środowisko";
            this.CreateEnvironmentButton.UseVisualStyleBackColor = true;
            this.CreateEnvironmentButton.Click += new System.EventHandler(this.CreateEnvironmentButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(17, 314);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(465, 23);
            this.ProgressBar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aktualny status:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(117, 349);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(78, 17);
            this.StatusLabel.TabIndex = 15;
            this.StatusLabel.Text = "oczekujący";
            // 
            // VisualStudioCodeInstallerLink
            // 
            this.VisualStudioCodeInstallerLink.AutoSize = true;
            this.VisualStudioCodeInstallerLink.Location = new System.Drawing.Point(244, 114);
            this.VisualStudioCodeInstallerLink.Name = "VisualStudioCodeInstallerLink";
            this.VisualStudioCodeInstallerLink.Size = new System.Drawing.Size(119, 17);
            this.VisualStudioCodeInstallerLink.TabIndex = 17;
            this.VisualStudioCodeInstallerLink.TabStop = true;
            this.VisualStudioCodeInstallerLink.Text = "link do instalatora";
            this.VisualStudioCodeInstallerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VisualStudioCodeInstallerLink_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "1. Visual Studio Code (edytor)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(403, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "(wymagany jest także dodatek do obsługi C/C++ od Microsoftu)";
            // 
            // ProjectPathTextBox
            // 
            this.ProjectPathTextBox.Location = new System.Drawing.Point(193, 248);
            this.ProjectPathTextBox.Name = "ProjectPathTextBox";
            this.ProjectPathTextBox.ReadOnly = true;
            this.ProjectPathTextBox.Size = new System.Drawing.Size(202, 22);
            this.ProjectPathTextBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Katalog główny projektu:";
            // 
            // SelectMicrOSDirectoryButton
            // 
            this.SelectMicrOSDirectoryButton.Location = new System.Drawing.Point(398, 245);
            this.SelectMicrOSDirectoryButton.Name = "SelectMicrOSDirectoryButton";
            this.SelectMicrOSDirectoryButton.Size = new System.Drawing.Size(84, 28);
            this.SelectMicrOSDirectoryButton.TabIndex = 19;
            this.SelectMicrOSDirectoryButton.Text = "Wybierz...";
            this.SelectMicrOSDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectMicrOSDirectoryButton.Click += new System.EventHandler(this.SelectMicrOSDirectoryButton_Click);
            // 
            // NewEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 389);
            this.Controls.Add(this.ProjectPathTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SelectMicrOSDirectoryButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.VisualStudioCodeInstallerLink);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CreateEnvironmentButton);
            this.Controls.Add(this.MSYSTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SelectMSYSButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MsysInstallerLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ImdiskInstallerLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QemuInstallerLink);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEnvironmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MicrOS Dev Tools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel QemuInstallerLink;
        private System.Windows.Forms.LinkLabel ImdiskInstallerLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel MsysInstallerLink;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MSYSTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SelectMSYSButton;
        private System.Windows.Forms.Button CreateEnvironmentButton;
        private System.Windows.Forms.FolderBrowserDialog SelectMSYSDirectoryDialog;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.LinkLabel VisualStudioCodeInstallerLink;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ProjectPathTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SelectMicrOSDirectoryButton;
        private System.Windows.Forms.FolderBrowserDialog SelectMicrOSDirectoryDialog;
    }
}