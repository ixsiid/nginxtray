/*
 * NginxTray - A tray icon to manage Nginx and other components.
 * 
 * This file is part of NginxTray <https://github.com/nginxtray/nginxtray>.
 * 
 * Copyright (C) 2010-2017 by Emiliano del Gobbo
 * <https://emilianodelgobbo.com> and other contributors.
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License version 2 as 
 * published by the Free Software Foundation.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License version 2 for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * version 2 along with this program.  If not, see
 * <http://www.gnu.org/licenses/>.
*/

namespace NginxTray
{
    partial class frmSettings
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
            this.nginxSettingsTab = new System.Windows.Forms.TabPage();
            this.NginxSettingsCloseButton = new System.Windows.Forms.Button();
            this.ExampleLabel2 = new System.Windows.Forms.Label();
            this.ExampleLabel1 = new System.Windows.Forms.Label();
            this.NginxSettingsSaveButton = new System.Windows.Forms.Button();
            this.NginxProcessLabel = new System.Windows.Forms.Label();
            this.NginxDirectoryLabel = new System.Windows.Forms.Label();
            this.textBoxNginxProcess = new System.Windows.Forms.TextBox();
            this.textBoxNginxDirectory = new System.Windows.Forms.TextBox();
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.phpSettingsTab = new System.Windows.Forms.TabPage();
            this.panelSettingsPHP = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPHPPort = new System.Windows.Forms.TextBox();
            this.labelPHPAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelPHPProcess = new System.Windows.Forms.Label();
            this.labelPHPDirectory = new System.Windows.Forms.Label();
            this.textBoxPHPProcess = new System.Windows.Forms.TextBox();
            this.textBoxPHPDirectory = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PHPSettingsSaveButton = new System.Windows.Forms.Button();
            this.checkBoxPHPEnable = new System.Windows.Forms.CheckBox();
            this.NginxSettingsDirectoryOpenButton = new System.Windows.Forms.Button();
            this.nginxSettingsTab.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.phpSettingsTab.SuspendLayout();
            this.panelSettingsPHP.SuspendLayout();
            this.SuspendLayout();
            // 
            // nginxSettingsTab
            // 
            this.nginxSettingsTab.Controls.Add(this.NginxSettingsDirectoryOpenButton);
            this.nginxSettingsTab.Controls.Add(this.NginxSettingsCloseButton);
            this.nginxSettingsTab.Controls.Add(this.ExampleLabel2);
            this.nginxSettingsTab.Controls.Add(this.ExampleLabel1);
            this.nginxSettingsTab.Controls.Add(this.NginxSettingsSaveButton);
            this.nginxSettingsTab.Controls.Add(this.NginxProcessLabel);
            this.nginxSettingsTab.Controls.Add(this.NginxDirectoryLabel);
            this.nginxSettingsTab.Controls.Add(this.textBoxNginxProcess);
            this.nginxSettingsTab.Controls.Add(this.textBoxNginxDirectory);
            this.nginxSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.nginxSettingsTab.Name = "nginxSettingsTab";
            this.nginxSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.nginxSettingsTab.Size = new System.Drawing.Size(401, 314);
            this.nginxSettingsTab.TabIndex = 0;
            this.nginxSettingsTab.Text = "Nginx";
            this.nginxSettingsTab.UseVisualStyleBackColor = true;
            // 
            // NginxSettingsCloseButton
            // 
            this.NginxSettingsCloseButton.Location = new System.Drawing.Point(283, 283);
            this.NginxSettingsCloseButton.Name = "NginxSettingsCloseButton";
            this.NginxSettingsCloseButton.Size = new System.Drawing.Size(111, 27);
            this.NginxSettingsCloseButton.TabIndex = 7;
            this.NginxSettingsCloseButton.Text = "Close";
            this.NginxSettingsCloseButton.UseVisualStyleBackColor = true;
            this.NginxSettingsCloseButton.Click += new System.EventHandler(this.SettingsCloseButton_Click);
            // 
            // ExampleLabel2
            // 
            this.ExampleLabel2.AutoSize = true;
            this.ExampleLabel2.Location = new System.Drawing.Point(92, 142);
            this.ExampleLabel2.Name = "ExampleLabel2";
            this.ExampleLabel2.Size = new System.Drawing.Size(101, 12);
            this.ExampleLabel2.TabIndex = 6;
            this.ExampleLabel2.Text = "Example: nginx.exe";
            // 
            // ExampleLabel1
            // 
            this.ExampleLabel1.AutoSize = true;
            this.ExampleLabel1.Location = new System.Drawing.Point(92, 81);
            this.ExampleLabel1.Name = "ExampleLabel1";
            this.ExampleLabel1.Size = new System.Drawing.Size(97, 12);
            this.ExampleLabel1.TabIndex = 5;
            this.ExampleLabel1.Text = "Example: C:\\nginx";
            // 
            // NginxSettingsSaveButton
            // 
            this.NginxSettingsSaveButton.Location = new System.Drawing.Point(160, 283);
            this.NginxSettingsSaveButton.Name = "NginxSettingsSaveButton";
            this.NginxSettingsSaveButton.Size = new System.Drawing.Size(111, 27);
            this.NginxSettingsSaveButton.TabIndex = 4;
            this.NginxSettingsSaveButton.Text = "Save";
            this.NginxSettingsSaveButton.UseVisualStyleBackColor = true;
            this.NginxSettingsSaveButton.Click += new System.EventHandler(this.NginxSettingsSaveButton_Click);
            // 
            // NginxProcessLabel
            // 
            this.NginxProcessLabel.AutoSize = true;
            this.NginxProcessLabel.Location = new System.Drawing.Point(14, 121);
            this.NginxProcessLabel.Name = "NginxProcessLabel";
            this.NginxProcessLabel.Size = new System.Drawing.Size(79, 12);
            this.NginxProcessLabel.TabIndex = 3;
            this.NginxProcessLabel.Text = "Nginx Process";
            // 
            // NginxDirectoryLabel
            // 
            this.NginxDirectoryLabel.AutoSize = true;
            this.NginxDirectoryLabel.Location = new System.Drawing.Point(10, 63);
            this.NginxDirectoryLabel.Name = "NginxDirectoryLabel";
            this.NginxDirectoryLabel.Size = new System.Drawing.Size(85, 12);
            this.NginxDirectoryLabel.TabIndex = 2;
            this.NginxDirectoryLabel.Text = "Nginx Directory";
            // 
            // textBoxNginxProcess
            // 
            this.textBoxNginxProcess.Location = new System.Drawing.Point(95, 121);
            this.textBoxNginxProcess.Name = "textBoxNginxProcess";
            this.textBoxNginxProcess.Size = new System.Drawing.Size(278, 19);
            this.textBoxNginxProcess.TabIndex = 1;
            // 
            // textBoxNginxDirectory
            // 
            this.textBoxNginxDirectory.Location = new System.Drawing.Point(95, 60);
            this.textBoxNginxDirectory.Name = "textBoxNginxDirectory";
            this.textBoxNginxDirectory.Size = new System.Drawing.Size(214, 19);
            this.textBoxNginxDirectory.TabIndex = 0;
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.nginxSettingsTab);
            this.SettingsTab.Controls.Add(this.phpSettingsTab);
            this.SettingsTab.Location = new System.Drawing.Point(9, 12);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            this.SettingsTab.Size = new System.Drawing.Size(409, 340);
            this.SettingsTab.TabIndex = 0;
            // 
            // phpSettingsTab
            // 
            this.phpSettingsTab.Controls.Add(this.panelSettingsPHP);
            this.phpSettingsTab.Controls.Add(this.button1);
            this.phpSettingsTab.Controls.Add(this.PHPSettingsSaveButton);
            this.phpSettingsTab.Controls.Add(this.checkBoxPHPEnable);
            this.phpSettingsTab.Location = new System.Drawing.Point(4, 22);
            this.phpSettingsTab.Name = "phpSettingsTab";
            this.phpSettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.phpSettingsTab.Size = new System.Drawing.Size(401, 314);
            this.phpSettingsTab.TabIndex = 1;
            this.phpSettingsTab.Text = "PHP FastCGI";
            this.phpSettingsTab.UseVisualStyleBackColor = true;
            // 
            // panelSettingsPHP
            // 
            this.panelSettingsPHP.Controls.Add(this.label6);
            this.panelSettingsPHP.Controls.Add(this.textBoxPHPPort);
            this.panelSettingsPHP.Controls.Add(this.labelPHPAddress);
            this.panelSettingsPHP.Controls.Add(this.label1);
            this.panelSettingsPHP.Controls.Add(this.label2);
            this.panelSettingsPHP.Controls.Add(this.labelPHPProcess);
            this.panelSettingsPHP.Controls.Add(this.labelPHPDirectory);
            this.panelSettingsPHP.Controls.Add(this.textBoxPHPProcess);
            this.panelSettingsPHP.Controls.Add(this.textBoxPHPDirectory);
            this.panelSettingsPHP.Location = new System.Drawing.Point(6, 53);
            this.panelSettingsPHP.Name = "panelSettingsPHP";
            this.panelSettingsPHP.Size = new System.Drawing.Size(392, 182);
            this.panelSettingsPHP.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "Example: 127.0.0.1:9123";
            // 
            // textBoxPHPPort
            // 
            this.textBoxPHPPort.Location = new System.Drawing.Point(119, 132);
            this.textBoxPHPPort.Name = "textBoxPHPPort";
            this.textBoxPHPPort.Size = new System.Drawing.Size(189, 19);
            this.textBoxPHPPort.TabIndex = 14;
            // 
            // labelPHPAddress
            // 
            this.labelPHPAddress.AutoSize = true;
            this.labelPHPAddress.Location = new System.Drawing.Point(3, 135);
            this.labelPHPAddress.Name = "labelPHPAddress";
            this.labelPHPAddress.Size = new System.Drawing.Size(119, 12);
            this.labelPHPAddress.TabIndex = 13;
            this.labelPHPAddress.Text = "PHP FastCGI Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Example: php-cgi.exe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "Example: C:\\php";
            // 
            // labelPHPProcess
            // 
            this.labelPHPProcess.AutoSize = true;
            this.labelPHPProcess.Location = new System.Drawing.Point(2, 74);
            this.labelPHPProcess.Name = "labelPHPProcess";
            this.labelPHPProcess.Size = new System.Drawing.Size(118, 12);
            this.labelPHPProcess.TabIndex = 10;
            this.labelPHPProcess.Text = "PHP FastCGI Process";
            // 
            // labelPHPDirectory
            // 
            this.labelPHPDirectory.AutoSize = true;
            this.labelPHPDirectory.Location = new System.Drawing.Point(39, 13);
            this.labelPHPDirectory.Name = "labelPHPDirectory";
            this.labelPHPDirectory.Size = new System.Drawing.Size(78, 12);
            this.labelPHPDirectory.TabIndex = 9;
            this.labelPHPDirectory.Text = "PHP Directory";
            // 
            // textBoxPHPProcess
            // 
            this.textBoxPHPProcess.Location = new System.Drawing.Point(119, 71);
            this.textBoxPHPProcess.Name = "textBoxPHPProcess";
            this.textBoxPHPProcess.Size = new System.Drawing.Size(258, 19);
            this.textBoxPHPProcess.TabIndex = 8;
            // 
            // textBoxPHPDirectory
            // 
            this.textBoxPHPDirectory.Location = new System.Drawing.Point(119, 10);
            this.textBoxPHPDirectory.Name = "textBoxPHPDirectory";
            this.textBoxPHPDirectory.Size = new System.Drawing.Size(258, 19);
            this.textBoxPHPDirectory.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 27);
            this.button1.TabIndex = 18;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SettingsCloseButton_Click);
            // 
            // PHPSettingsSaveButton
            // 
            this.PHPSettingsSaveButton.Location = new System.Drawing.Point(160, 283);
            this.PHPSettingsSaveButton.Name = "PHPSettingsSaveButton";
            this.PHPSettingsSaveButton.Size = new System.Drawing.Size(111, 27);
            this.PHPSettingsSaveButton.TabIndex = 17;
            this.PHPSettingsSaveButton.Text = "Save";
            this.PHPSettingsSaveButton.UseVisualStyleBackColor = true;
            this.PHPSettingsSaveButton.Click += new System.EventHandler(this.PHPSettingsSaveButton_Click);
            // 
            // checkBoxPHPEnable
            // 
            this.checkBoxPHPEnable.AutoSize = true;
            this.checkBoxPHPEnable.Location = new System.Drawing.Point(12, 20);
            this.checkBoxPHPEnable.Name = "checkBoxPHPEnable";
            this.checkBoxPHPEnable.Size = new System.Drawing.Size(166, 16);
            this.checkBoxPHPEnable.TabIndex = 16;
            this.checkBoxPHPEnable.Text = "Enable use of PHP FastCGI";
            this.checkBoxPHPEnable.UseVisualStyleBackColor = true;
            this.checkBoxPHPEnable.CheckedChanged += new System.EventHandler(this.checkBoxPHPEnable_CheckedChanged);
            // 
            // NginxSettingsDirectoryOpenButton
            // 
            this.NginxSettingsDirectoryOpenButton.Location = new System.Drawing.Point(315, 59);
            this.NginxSettingsDirectoryOpenButton.Name = "NginxSettingsDirectoryOpenButton";
            this.NginxSettingsDirectoryOpenButton.Size = new System.Drawing.Size(73, 20);
            this.NginxSettingsDirectoryOpenButton.TabIndex = 8;
            this.NginxSettingsDirectoryOpenButton.Text = "Open";
            this.NginxSettingsDirectoryOpenButton.UseVisualStyleBackColor = true;
            this.NginxSettingsDirectoryOpenButton.Click += new System.EventHandler(this.NginxSettingsDirectoryOpenButton_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 363);
            this.Controls.Add(this.SettingsTab);
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.nginxSettingsTab.ResumeLayout(false);
            this.nginxSettingsTab.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.phpSettingsTab.ResumeLayout(false);
            this.phpSettingsTab.PerformLayout();
            this.panelSettingsPHP.ResumeLayout(false);
            this.panelSettingsPHP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage nginxSettingsTab;
        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.Button NginxSettingsSaveButton;
        private System.Windows.Forms.Label NginxProcessLabel;
        private System.Windows.Forms.Label NginxDirectoryLabel;
        private System.Windows.Forms.TextBox textBoxNginxProcess;
        private System.Windows.Forms.TextBox textBoxNginxDirectory;
        private System.Windows.Forms.Label ExampleLabel2;
        private System.Windows.Forms.Label ExampleLabel1;
        private System.Windows.Forms.Button NginxSettingsCloseButton;
        private System.Windows.Forms.TabPage phpSettingsTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPHPPort;
        private System.Windows.Forms.Label labelPHPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPHPProcess;
        private System.Windows.Forms.Label labelPHPDirectory;
        private System.Windows.Forms.TextBox textBoxPHPProcess;
        private System.Windows.Forms.TextBox textBoxPHPDirectory;
        private System.Windows.Forms.CheckBox checkBoxPHPEnable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PHPSettingsSaveButton;
        private System.Windows.Forms.Panel panelSettingsPHP;
        private System.Windows.Forms.Button NginxSettingsDirectoryOpenButton;
    }
}