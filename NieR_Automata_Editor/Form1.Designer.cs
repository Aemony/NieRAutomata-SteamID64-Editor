using System;

namespace NieR_Automata_Editor
{
    partial class Form1
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
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.textBoxWorkingFile = new System.Windows.Forms.TextBox();
            this.textBoxSteamID64 = new System.Windows.Forms.TextBox();
            this.labelSteamID64 = new System.Windows.Forms.Label();
            this.groupBoxSteamID = new System.Windows.Forms.GroupBox();
            this.textBoxSteamID64_New = new System.Windows.Forms.TextBox();
            this.linkLabelSteamID64_New = new System.Windows.Forms.LinkLabel();
            this.labelSteamID_New = new System.Windows.Forms.Label();
            this.buttonSteamIDUpdate = new System.Windows.Forms.Button();
            this.linkLabelSteamID64 = new System.Windows.Forms.LinkLabel();
            this.textBoxSteamID3 = new System.Windows.Forms.TextBox();
            this.labelSteamID3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSteamID.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(259, 19);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Open file...";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // textBoxWorkingFile
            // 
            this.textBoxWorkingFile.Location = new System.Drawing.Point(23, 21);
            this.textBoxWorkingFile.Name = "textBoxWorkingFile";
            this.textBoxWorkingFile.ReadOnly = true;
            this.textBoxWorkingFile.Size = new System.Drawing.Size(230, 20);
            this.textBoxWorkingFile.TabIndex = 2;
            this.textBoxWorkingFile.Text = "No file loaded...";
            // 
            // textBoxSteamID64
            // 
            this.textBoxSteamID64.Location = new System.Drawing.Point(158, 55);
            this.textBoxSteamID64.Name = "textBoxSteamID64";
            this.textBoxSteamID64.ReadOnly = true;
            this.textBoxSteamID64.Size = new System.Drawing.Size(147, 20);
            this.textBoxSteamID64.TabIndex = 5;
            this.textBoxSteamID64.TextChanged += new System.EventHandler(this.textBoxSteamID64_TextChanged);
            // 
            // labelSteamID64
            // 
            this.labelSteamID64.AutoSize = true;
            this.labelSteamID64.Location = new System.Drawing.Point(6, 58);
            this.labelSteamID64.Name = "labelSteamID64";
            this.labelSteamID64.Size = new System.Drawing.Size(97, 13);
            this.labelSteamID64.TabIndex = 6;
            this.labelSteamID64.Text = "Current SteamID64";
            // 
            // groupBoxSteamID
            // 
            this.groupBoxSteamID.Controls.Add(this.textBoxSteamID64_New);
            this.groupBoxSteamID.Controls.Add(this.linkLabelSteamID64_New);
            this.groupBoxSteamID.Controls.Add(this.labelSteamID_New);
            this.groupBoxSteamID.Controls.Add(this.buttonSteamIDUpdate);
            this.groupBoxSteamID.Controls.Add(this.linkLabelSteamID64);
            this.groupBoxSteamID.Controls.Add(this.textBoxSteamID3);
            this.groupBoxSteamID.Controls.Add(this.labelSteamID3);
            this.groupBoxSteamID.Controls.Add(this.textBoxSteamID64);
            this.groupBoxSteamID.Controls.Add(this.labelSteamID64);
            this.groupBoxSteamID.Location = new System.Drawing.Point(23, 62);
            this.groupBoxSteamID.Name = "groupBoxSteamID";
            this.groupBoxSteamID.Size = new System.Drawing.Size(311, 213);
            this.groupBoxSteamID.TabIndex = 7;
            this.groupBoxSteamID.TabStop = false;
            this.groupBoxSteamID.Text = "SteamID";
            // 
            // textBoxSteamID64_New
            // 
            this.textBoxSteamID64_New.Location = new System.Drawing.Point(157, 133);
            this.textBoxSteamID64_New.MaxLength = 20;
            this.textBoxSteamID64_New.Name = "textBoxSteamID64_New";
            this.textBoxSteamID64_New.Size = new System.Drawing.Size(147, 20);
            this.textBoxSteamID64_New.TabIndex = 13;
            this.textBoxSteamID64_New.TextChanged += new System.EventHandler(this.textBoxSteamID64_New_TextChanged);
            // 
            // linkLabelSteamID64_New
            // 
            this.linkLabelSteamID64_New.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelSteamID64_New.AutoSize = true;
            this.linkLabelSteamID64_New.Enabled = false;
            this.linkLabelSteamID64_New.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelSteamID64_New.Location = new System.Drawing.Point(181, 156);
            this.linkLabelSteamID64_New.Name = "linkLabelSteamID64_New";
            this.linkLabelSteamID64_New.Size = new System.Drawing.Size(123, 13);
            this.linkLabelSteamID64_New.TabIndex = 12;
            this.linkLabelSteamID64_New.TabStop = true;
            this.linkLabelSteamID64_New.Text = "Steam Community Profile";
            this.linkLabelSteamID64_New.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSteamID64_New_LinkClicked);
            this.linkLabelSteamID64_New.MouseEnter += new System.EventHandler(this.linkLabelSteamID64_New_MouseEnter);
            this.linkLabelSteamID64_New.MouseLeave += new System.EventHandler(this.linkLabelSteamID64_New_MouseLeave);
            // 
            // labelSteamID_New
            // 
            this.labelSteamID_New.AutoSize = true;
            this.labelSteamID_New.Location = new System.Drawing.Point(6, 136);
            this.labelSteamID_New.Name = "labelSteamID_New";
            this.labelSteamID_New.Size = new System.Drawing.Size(85, 13);
            this.labelSteamID_New.TabIndex = 11;
            this.labelSteamID_New.Text = "New SteamID64";
            // 
            // buttonSteamIDUpdate
            // 
            this.buttonSteamIDUpdate.Enabled = false;
            this.buttonSteamIDUpdate.Location = new System.Drawing.Point(230, 181);
            this.buttonSteamIDUpdate.Name = "buttonSteamIDUpdate";
            this.buttonSteamIDUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonSteamIDUpdate.TabIndex = 10;
            this.buttonSteamIDUpdate.Text = "Update";
            this.buttonSteamIDUpdate.UseVisualStyleBackColor = true;
            this.buttonSteamIDUpdate.Click += new System.EventHandler(this.buttonSteamIDUpdate_Click);
            // 
            // linkLabelSteamID64
            // 
            this.linkLabelSteamID64.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelSteamID64.AutoSize = true;
            this.linkLabelSteamID64.Enabled = false;
            this.linkLabelSteamID64.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabelSteamID64.Location = new System.Drawing.Point(183, 78);
            this.linkLabelSteamID64.Name = "linkLabelSteamID64";
            this.linkLabelSteamID64.Size = new System.Drawing.Size(122, 13);
            this.linkLabelSteamID64.TabIndex = 9;
            this.linkLabelSteamID64.TabStop = true;
            this.linkLabelSteamID64.Text = "Steam Community profile";
            this.linkLabelSteamID64.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSteamID64_LinkClicked);
            this.linkLabelSteamID64.MouseEnter += new System.EventHandler(this.linkLabelSteamID64_MouseEnter);
            this.linkLabelSteamID64.MouseLeave += new System.EventHandler(this.linkLabelSteamID64_MouseLeave);
            // 
            // textBoxSteamID3
            // 
            this.textBoxSteamID3.Location = new System.Drawing.Point(158, 29);
            this.textBoxSteamID3.Name = "textBoxSteamID3";
            this.textBoxSteamID3.ReadOnly = true;
            this.textBoxSteamID3.Size = new System.Drawing.Size(147, 20);
            this.textBoxSteamID3.TabIndex = 7;
            // 
            // labelSteamID3
            // 
            this.labelSteamID3.AutoSize = true;
            this.labelSteamID3.Location = new System.Drawing.Point(6, 32);
            this.labelSteamID3.Name = "labelSteamID3";
            this.labelSteamID3.Size = new System.Drawing.Size(91, 13);
            this.labelSteamID3.TabIndex = 8;
            this.labelSteamID3.Text = "Current SteamID3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(357, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "Open a file to begin...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 310);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxSteamID);
            this.Controls.Add(this.textBoxWorkingFile);
            this.Controls.Add(this.buttonOpenFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NieR: Automata - SteamID64 Editor";
            this.groupBoxSteamID.ResumeLayout(false);
            this.groupBoxSteamID.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TextBox textBoxWorkingFile;
        private System.Windows.Forms.TextBox textBoxSteamID64;
        private System.Windows.Forms.Label labelSteamID64;
        private System.Windows.Forms.GroupBox groupBoxSteamID;
        private System.Windows.Forms.TextBox textBoxSteamID3;
        private System.Windows.Forms.Label labelSteamID3;
        private System.Windows.Forms.LinkLabel linkLabelSteamID64;
        private System.Windows.Forms.Button buttonSteamIDUpdate;
        private System.Windows.Forms.Label labelSteamID_New;
        private System.Windows.Forms.LinkLabel linkLabelSteamID64_New;
        private System.Windows.Forms.TextBox textBoxSteamID64_New;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

