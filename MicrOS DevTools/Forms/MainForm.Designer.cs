namespace MicrOS_DevTools.Forms
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
            this.SelectGDBDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectMicrOSDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.RepositoryLinkTextBox = new System.Windows.Forms.TextBox();
            this.SelectGDBButton = new System.Windows.Forms.Button();
            this.GDBTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MSYSTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectMSYSButton = new System.Windows.Forms.Button();
            this.SelectMSYSDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProjectPathTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SelectMicrOSDirectoryButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LocalConfigurationVersionLabel = new System.Windows.Forms.Label();
            this.RemoteConfigurationVersionLabel = new System.Windows.Forms.Label();
            this.GenerateConfigurationButton = new System.Windows.Forms.Button();
            this.FloppyLetterTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DebuggerTargetComboBox = new System.Windows.Forms.ComboBox();
            this.GeneratorProgressBar = new System.Windows.Forms.ProgressBar();
            this.QemuTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SelectQemuButton = new System.Windows.Forms.Button();
            this.SelectQemuDialog = new System.Windows.Forms.OpenFileDialog();
            this.CreateEnvironmentButton = new System.Windows.Forms.Button();
            this.WindowsVersionComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ConnectionStatus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // SelectGDBDialog
            // 
            this.SelectGDBDialog.Filter = "GDB | gdb.exe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Link do repozytorium plików:";
            // 
            // RepositoryLinkTextBox
            // 
            this.RepositoryLinkTextBox.Location = new System.Drawing.Point(322, 6);
            this.RepositoryLinkTextBox.Name = "RepositoryLinkTextBox";
            this.RepositoryLinkTextBox.Size = new System.Drawing.Size(381, 22);
            this.RepositoryLinkTextBox.TabIndex = 1;
            this.RepositoryLinkTextBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            this.RepositoryLinkTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RepositoryLinkTextBox_KeyUp);
            // 
            // SelectGDBButton
            // 
            this.SelectGDBButton.Location = new System.Drawing.Point(617, 32);
            this.SelectGDBButton.Name = "SelectGDBButton";
            this.SelectGDBButton.Size = new System.Drawing.Size(114, 28);
            this.SelectGDBButton.TabIndex = 2;
            this.SelectGDBButton.Text = "Wybierz...";
            this.SelectGDBButton.UseVisualStyleBackColor = true;
            this.SelectGDBButton.Click += new System.EventHandler(this.SelectGDBButton_Click);
            // 
            // GDBTextBox
            // 
            this.GDBTextBox.Location = new System.Drawing.Point(322, 35);
            this.GDBTextBox.Name = "GDBTextBox";
            this.GDBTextBox.ReadOnly = true;
            this.GDBTextBox.Size = new System.Drawing.Size(289, 22);
            this.GDBTextBox.TabIndex = 4;
            this.GDBTextBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ścieżka do debuggera (plik gdb.exe):";
            // 
            // MSYSTextBox
            // 
            this.MSYSTextBox.Location = new System.Drawing.Point(322, 65);
            this.MSYSTextBox.Name = "MSYSTextBox";
            this.MSYSTextBox.ReadOnly = true;
            this.MSYSTextBox.Size = new System.Drawing.Size(289, 22);
            this.MSYSTextBox.TabIndex = 7;
            this.MSYSTextBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ścieżka do MSYS (plik msys2_shell.cmd):";
            // 
            // SelectMSYSButton
            // 
            this.SelectMSYSButton.Location = new System.Drawing.Point(617, 62);
            this.SelectMSYSButton.Name = "SelectMSYSButton";
            this.SelectMSYSButton.Size = new System.Drawing.Size(114, 28);
            this.SelectMSYSButton.TabIndex = 5;
            this.SelectMSYSButton.Text = "Wybierz...";
            this.SelectMSYSButton.UseVisualStyleBackColor = true;
            this.SelectMSYSButton.Click += new System.EventHandler(this.SelectMSYSButton_Click);
            // 
            // SelectMSYSDialog
            // 
            this.SelectMSYSDialog.Filter = "MSYS | msys2_shell.cmd";
            // 
            // ProjectPathTextBox
            // 
            this.ProjectPathTextBox.Location = new System.Drawing.Point(322, 128);
            this.ProjectPathTextBox.Name = "ProjectPathTextBox";
            this.ProjectPathTextBox.ReadOnly = true;
            this.ProjectPathTextBox.Size = new System.Drawing.Size(289, 22);
            this.ProjectPathTextBox.TabIndex = 10;
            this.ProjectPathTextBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Katalog główny projektu (folder MicrOS):";
            // 
            // SelectMicrOSDirectoryButton
            // 
            this.SelectMicrOSDirectoryButton.Location = new System.Drawing.Point(617, 125);
            this.SelectMicrOSDirectoryButton.Name = "SelectMicrOSDirectoryButton";
            this.SelectMicrOSDirectoryButton.Size = new System.Drawing.Size(114, 28);
            this.SelectMicrOSDirectoryButton.TabIndex = 8;
            this.SelectMicrOSDirectoryButton.Text = "Wybierz...";
            this.SelectMicrOSDirectoryButton.UseVisualStyleBackColor = true;
            this.SelectMicrOSDirectoryButton.Click += new System.EventHandler(this.SelectMicrOSDirectoryButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wersja lokalnej konfiguracji:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wersja konfiguracji na repozytorium:";
            // 
            // LocalConfigurationVersionLabel
            // 
            this.LocalConfigurationVersionLabel.AutoSize = true;
            this.LocalConfigurationVersionLabel.Location = new System.Drawing.Point(261, 256);
            this.LocalConfigurationVersionLabel.Name = "LocalConfigurationVersionLabel";
            this.LocalConfigurationVersionLabel.Size = new System.Drawing.Size(16, 17);
            this.LocalConfigurationVersionLabel.TabIndex = 13;
            this.LocalConfigurationVersionLabel.Text = "0";
            // 
            // RemoteConfigurationVersionLabel
            // 
            this.RemoteConfigurationVersionLabel.AutoSize = true;
            this.RemoteConfigurationVersionLabel.Location = new System.Drawing.Point(261, 287);
            this.RemoteConfigurationVersionLabel.Name = "RemoteConfigurationVersionLabel";
            this.RemoteConfigurationVersionLabel.Size = new System.Drawing.Size(16, 17);
            this.RemoteConfigurationVersionLabel.TabIndex = 14;
            this.RemoteConfigurationVersionLabel.Text = "0";
            // 
            // GenerateConfigurationButton
            // 
            this.GenerateConfigurationButton.Location = new System.Drawing.Point(476, 256);
            this.GenerateConfigurationButton.Name = "GenerateConfigurationButton";
            this.GenerateConfigurationButton.Size = new System.Drawing.Size(255, 52);
            this.GenerateConfigurationButton.TabIndex = 15;
            this.GenerateConfigurationButton.Text = "Zapisz ustawienia i wygeneruj pliki konfiguracyjne";
            this.GenerateConfigurationButton.UseVisualStyleBackColor = true;
            this.GenerateConfigurationButton.Click += new System.EventHandler(this.GenerateConfigurationButton_Click);
            // 
            // FloppyLetterTextBox
            // 
            this.FloppyLetterTextBox.Location = new System.Drawing.Point(322, 157);
            this.FloppyLetterTextBox.MaxLength = 1;
            this.FloppyLetterTextBox.Name = "FloppyLetterTextBox";
            this.FloppyLetterTextBox.Size = new System.Drawing.Size(409, 22);
            this.FloppyLetterTextBox.TabIndex = 17;
            this.FloppyLetterTextBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Litera zamontowanej dyskietki:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Cel debuggera:";
            // 
            // DebuggerTargetComboBox
            // 
            this.DebuggerTargetComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DebuggerTargetComboBox.FormattingEnabled = true;
            this.DebuggerTargetComboBox.Location = new System.Drawing.Point(322, 185);
            this.DebuggerTargetComboBox.Name = "DebuggerTargetComboBox";
            this.DebuggerTargetComboBox.Size = new System.Drawing.Size(409, 24);
            this.DebuggerTargetComboBox.TabIndex = 19;
            this.DebuggerTargetComboBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // GeneratorProgressBar
            // 
            this.GeneratorProgressBar.Location = new System.Drawing.Point(15, 317);
            this.GeneratorProgressBar.Name = "GeneratorProgressBar";
            this.GeneratorProgressBar.Size = new System.Drawing.Size(716, 23);
            this.GeneratorProgressBar.TabIndex = 20;
            // 
            // QemuTextBox
            // 
            this.QemuTextBox.Location = new System.Drawing.Point(322, 96);
            this.QemuTextBox.Name = "QemuTextBox";
            this.QemuTextBox.ReadOnly = true;
            this.QemuTextBox.Size = new System.Drawing.Size(289, 22);
            this.QemuTextBox.TabIndex = 23;
            this.QemuTextBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Ścieżka do qemu (plik qemu-system-i386.exe):";
            // 
            // SelectQemuButton
            // 
            this.SelectQemuButton.Location = new System.Drawing.Point(617, 93);
            this.SelectQemuButton.Name = "SelectQemuButton";
            this.SelectQemuButton.Size = new System.Drawing.Size(114, 28);
            this.SelectQemuButton.TabIndex = 21;
            this.SelectQemuButton.Text = "Wybierz...";
            this.SelectQemuButton.UseVisualStyleBackColor = true;
            this.SelectQemuButton.Click += new System.EventHandler(this.SelectQemuButton_Click);
            // 
            // SelectQemuDialog
            // 
            this.SelectQemuDialog.Filter = "qemu | qemu-system-i386.exe";
            // 
            // CreateEnvironmentButton
            // 
            this.CreateEnvironmentButton.Location = new System.Drawing.Point(322, 256);
            this.CreateEnvironmentButton.Name = "CreateEnvironmentButton";
            this.CreateEnvironmentButton.Size = new System.Drawing.Size(148, 52);
            this.CreateEnvironmentButton.TabIndex = 24;
            this.CreateEnvironmentButton.Text = "Utwórz środowisko";
            this.CreateEnvironmentButton.UseVisualStyleBackColor = true;
            this.CreateEnvironmentButton.Click += new System.EventHandler(this.CreateEnvironmentButton_Click);
            // 
            // WindowsVersionComboBox
            // 
            this.WindowsVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WindowsVersionComboBox.FormattingEnabled = true;
            this.WindowsVersionComboBox.Items.AddRange(new object[] {
            "Windows 10",
            "Windows 7"});
            this.WindowsVersionComboBox.Location = new System.Drawing.Point(322, 217);
            this.WindowsVersionComboBox.Name = "WindowsVersionComboBox";
            this.WindowsVersionComboBox.Size = new System.Drawing.Size(409, 24);
            this.WindowsVersionComboBox.TabIndex = 26;
            this.WindowsVersionComboBox.TextChanged += new System.EventHandler(this.AllControls_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Wersja Windowsa:";
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.BackColor = System.Drawing.Color.Red;
            this.ConnectionStatus.Location = new System.Drawing.Point(709, 6);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(22, 22);
            this.ConnectionStatus.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 350);
            this.Controls.Add(this.ConnectionStatus);
            this.Controls.Add(this.WindowsVersionComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.CreateEnvironmentButton);
            this.Controls.Add(this.QemuTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SelectQemuButton);
            this.Controls.Add(this.GeneratorProgressBar);
            this.Controls.Add(this.DebuggerTargetComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FloppyLetterTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GenerateConfigurationButton);
            this.Controls.Add(this.RemoteConfigurationVersionLabel);
            this.Controls.Add(this.LocalConfigurationVersionLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProjectPathTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SelectMicrOSDirectoryButton);
            this.Controls.Add(this.MSYSTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SelectMSYSButton);
            this.Controls.Add(this.GDBTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectGDBButton);
            this.Controls.Add(this.RepositoryLinkTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MicrOS DevTools";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelectGDBDialog;
        private System.Windows.Forms.FolderBrowserDialog SelectMicrOSDirectoryDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RepositoryLinkTextBox;
        private System.Windows.Forms.Button SelectGDBButton;
        private System.Windows.Forms.TextBox GDBTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MSYSTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectMSYSButton;
        private System.Windows.Forms.OpenFileDialog SelectMSYSDialog;
        private System.Windows.Forms.TextBox ProjectPathTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SelectMicrOSDirectoryButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LocalConfigurationVersionLabel;
        private System.Windows.Forms.Label RemoteConfigurationVersionLabel;
        private System.Windows.Forms.Button GenerateConfigurationButton;
        private System.Windows.Forms.TextBox FloppyLetterTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DebuggerTargetComboBox;
        private System.Windows.Forms.ProgressBar GeneratorProgressBar;
        private System.Windows.Forms.TextBox QemuTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button SelectQemuButton;
        private System.Windows.Forms.OpenFileDialog SelectQemuDialog;
        private System.Windows.Forms.Button CreateEnvironmentButton;
        private System.Windows.Forms.ComboBox WindowsVersionComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel ConnectionStatus;
    }
}

