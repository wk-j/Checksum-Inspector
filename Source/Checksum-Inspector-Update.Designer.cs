namespace Checksum_Inspector
{
    partial class Checksum_Inspector_Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checksum_Inspector_Update));
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.LblDownloadProgress = new System.Windows.Forms.Label();
            this.Btn_CancelUpdate = new MetroFramework.Controls.MetroTile();
            this.LblAvailableVersion = new System.Windows.Forms.Label();
            this.BackgroundWorker4Downoad = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(26, 103);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(416, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroProgressBar1.TabIndex = 0;
            // 
            // LblDownloadProgress
            // 
            this.LblDownloadProgress.Location = new System.Drawing.Point(24, 82);
            this.LblDownloadProgress.Name = "LblDownloadProgress";
            this.LblDownloadProgress.Size = new System.Drawing.Size(338, 18);
            this.LblDownloadProgress.TabIndex = 1;
            this.LblDownloadProgress.Text = "Downloading File:";
            // 
            // Btn_CancelUpdate
            // 
            this.Btn_CancelUpdate.ActiveControl = null;
            this.Btn_CancelUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CancelUpdate.Location = new System.Drawing.Point(327, 133);
            this.Btn_CancelUpdate.Name = "Btn_CancelUpdate";
            this.Btn_CancelUpdate.Size = new System.Drawing.Size(115, 23);
            this.Btn_CancelUpdate.Style = MetroFramework.MetroColorStyle.Orange;
            this.Btn_CancelUpdate.TabIndex = 2;
            this.Btn_CancelUpdate.Text = "Cancel Update";
            this.Btn_CancelUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_CancelUpdate.UseSelectable = true;
            this.Btn_CancelUpdate.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // LblAvailableVersion
            // 
            this.LblAvailableVersion.Location = new System.Drawing.Point(128, 64);
            this.LblAvailableVersion.Name = "LblAvailableVersion";
            this.LblAvailableVersion.Size = new System.Drawing.Size(48, 18);
            this.LblAvailableVersion.TabIndex = 3;
            // 
            // BackgroundWorker4Downoad
            // 
            this.BackgroundWorker4Downoad.WorkerReportsProgress = true;
            this.BackgroundWorker4Downoad.WorkerSupportsCancellation = true;
            this.BackgroundWorker4Downoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker4Downoad_DoWork);
            this.BackgroundWorker4Downoad.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker4Downoad_ProgressChanged);
            this.BackgroundWorker4Downoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker4Downoad_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Available Version: ";
            // 
            // Checksum_Inspector_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(471, 172);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblAvailableVersion);
            this.Controls.Add(this.Btn_CancelUpdate);
            this.Controls.Add(this.LblDownloadProgress);
            this.Controls.Add(this.metroProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Checksum_Inspector_Update";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Checksum Inspector Update";
            this.Load += new System.EventHandler(this.Checksum_Inspector_Update_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Label LblDownloadProgress;
        private MetroFramework.Controls.MetroTile Btn_CancelUpdate;
        private System.Windows.Forms.Label LblAvailableVersion;
        private System.ComponentModel.BackgroundWorker BackgroundWorker4Downoad;
        private System.Windows.Forms.Label label1;
    }
}