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
            this.label8 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "1. QEMU (emulator procesora):";
            // 
            // QemuInstallerLink
            // 
            this.QemuInstallerLink.AutoSize = true;
            this.QemuInstallerLink.Location = new System.Drawing.Point(244, 112);
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
            this.ImdiskInstallerLink.Location = new System.Drawing.Point(244, 138);
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
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "2. Imdisk (montowanie dyskietki):";
            // 
            // MsysInstallerLink
            // 
            this.MsysInstallerLink.AutoSize = true;
            this.MsysInstallerLink.Location = new System.Drawing.Point(244, 164);
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
            this.label4.Location = new System.Drawing.Point(14, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "3. MSYS2 (środowisko Linuksowe):";
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
            this.MSYSTextBox.Location = new System.Drawing.Point(193, 198);
            this.MSYSTextBox.Name = "MSYSTextBox";
            this.MSYSTextBox.ReadOnly = true;
            this.MSYSTextBox.Size = new System.Drawing.Size(202, 22);
            this.MSYSTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ścieżka do folderu MSYS2:";
            // 
            // SelectMSYSButton
            // 
            this.SelectMSYSButton.Location = new System.Drawing.Point(398, 193);
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
            this.CreateEnvironmentButton.Location = new System.Drawing.Point(340, 260);
            this.CreateEnvironmentButton.Name = "CreateEnvironmentButton";
            this.CreateEnvironmentButton.Size = new System.Drawing.Size(142, 29);
            this.CreateEnvironmentButton.TabIndex = 12;
            this.CreateEnvironmentButton.Text = "Utwórz środowisko";
            this.CreateEnvironmentButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(17, 231);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(465, 23);
            this.ProgressBar.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Aktualny status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "oczekujący";
            // 
            // NewEnvironmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 296);
            this.Controls.Add(this.label8);
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
        private System.Windows.Forms.Label label8;
    }
}