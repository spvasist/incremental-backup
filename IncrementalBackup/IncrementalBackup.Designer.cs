namespace IncrementalBackup
{
    partial class IncrementalBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncrementalBackup));
            this.textBoxBackupPath = new System.Windows.Forms.TextBox();
            this.textBoxNewDataPath = new System.Windows.Forms.TextBox();
            this.buttonBackupPath = new System.Windows.Forms.Button();
            this.buttonNewDataPath = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxBackupPath
            // 
            this.textBoxBackupPath.Location = new System.Drawing.Point(126, 34);
            this.textBoxBackupPath.Name = "textBoxBackupPath";
            this.textBoxBackupPath.ReadOnly = true;
            this.textBoxBackupPath.Size = new System.Drawing.Size(623, 20);
            this.textBoxBackupPath.TabIndex = 0;
            // 
            // textBoxNewDataPath
            // 
            this.textBoxNewDataPath.Location = new System.Drawing.Point(126, 85);
            this.textBoxNewDataPath.Name = "textBoxNewDataPath";
            this.textBoxNewDataPath.ReadOnly = true;
            this.textBoxNewDataPath.Size = new System.Drawing.Size(623, 20);
            this.textBoxNewDataPath.TabIndex = 2;
            // 
            // buttonBackupPath
            // 
            this.buttonBackupPath.Location = new System.Drawing.Point(755, 32);
            this.buttonBackupPath.Name = "buttonBackupPath";
            this.buttonBackupPath.Size = new System.Drawing.Size(75, 23);
            this.buttonBackupPath.TabIndex = 1;
            this.buttonBackupPath.Text = "Browse...";
            this.buttonBackupPath.UseVisualStyleBackColor = true;
            this.buttonBackupPath.Click += new System.EventHandler(this.buttonBackupPath_Click);
            // 
            // buttonNewDataPath
            // 
            this.buttonNewDataPath.Location = new System.Drawing.Point(755, 83);
            this.buttonNewDataPath.Name = "buttonNewDataPath";
            this.buttonNewDataPath.Size = new System.Drawing.Size(75, 23);
            this.buttonNewDataPath.TabIndex = 3;
            this.buttonNewDataPath.Text = "Browse...";
            this.buttonNewDataPath.UseVisualStyleBackColor = true;
            this.buttonNewDataPath.Click += new System.EventHandler(this.buttonNewDataPath_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.BackgroundImage = global::IncrementalBackup.Properties.Resources.icon_tick;
            this.buttonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBackup.Location = new System.Drawing.Point(126, 136);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(704, 102);
            this.buttonBackup.TabIndex = 4;
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "New data Path :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Backup Path :";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // 
            // IncrementalBackup
            // 
            this.AcceptButton = this.buttonBackup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackup);
            this.Controls.Add(this.buttonNewDataPath);
            this.Controls.Add(this.buttonBackupPath);
            this.Controls.Add(this.textBoxNewDataPath);
            this.Controls.Add(this.textBoxBackupPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncrementalBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incremental Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBackupPath;
        private System.Windows.Forms.TextBox textBoxNewDataPath;
        private System.Windows.Forms.Button buttonBackupPath;
        private System.Windows.Forms.Button buttonNewDataPath;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

