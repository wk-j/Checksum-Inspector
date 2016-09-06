namespace Checksum_Inspector
{
    partial class Checksum_InspectorUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checksum_InspectorUI));
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.TxtMD5SumToCheck = new MetroFramework.Controls.MetroTextBox();
            this.LblMD5Sum = new MetroFramework.Controls.MetroLabel();
            this.PbarCalculationState = new MetroFramework.Controls.MetroProgressBar();
            this.LblChecksumTyp = new MetroFramework.Controls.MetroLabel();
            this.LblFileName = new MetroFramework.Controls.MetroLabel();
            this.Lbl_FileDescription = new MetroFramework.Controls.MetroLabel();
            this.BtnStart = new MetroFramework.Controls.MetroTile();
            this.BtnCopyChecksum = new MetroFramework.Controls.MetroTile();
            this.BtnChangeChecksum = new MetroFramework.Controls.MetroTile();
            this.BackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.TT4FileName = new MetroFramework.Components.MetroToolTip();
            this.PbControlImage = new System.Windows.Forms.PictureBox();
            this.LblVersion = new System.Windows.Forms.Label();
            this.LblUpdate = new System.Windows.Forms.Label();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TableLayout4_LabelsTextboxAndBackgroundworker = new System.Windows.Forms.TableLayoutPanel();
            this.TableLayout4_ButtonsAndPicBox = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PbControlImage)).BeginInit();
            this.TableLayout4_LabelsTextboxAndBackgroundworker.SuspendLayout();
            this.TableLayout4_ButtonsAndPicBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel6.Location = new System.Drawing.Point(3, 191);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(510, 19);
            this.metroLabel6.TabIndex = 72;
            this.metroLabel6.Text = "State:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel5.Location = new System.Drawing.Point(3, 131);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(510, 19);
            this.metroLabel5.TabIndex = 71;
            this.metroLabel5.Text = "Comparison:";
            // 
            // TxtMD5SumToCheck
            // 
            this.TxtMD5SumToCheck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMD5SumToCheck.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtMD5SumToCheck.Lines = new string[0];
            this.TxtMD5SumToCheck.Location = new System.Drawing.Point(3, 153);
            this.TxtMD5SumToCheck.MaxLength = 47;
            this.TxtMD5SumToCheck.Name = "TxtMD5SumToCheck";
            this.TxtMD5SumToCheck.PasswordChar = '\0';
            this.TxtMD5SumToCheck.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMD5SumToCheck.SelectedText = "";
            this.TxtMD5SumToCheck.Size = new System.Drawing.Size(510, 24);
            this.TxtMD5SumToCheck.Style = MetroFramework.MetroColorStyle.Orange;
            this.TxtMD5SumToCheck.TabIndex = 70;
            this.TxtMD5SumToCheck.UseSelectable = true;
            this.TxtMD5SumToCheck.TextChanged += new System.EventHandler(this.TxtMD5SumToCheck_TextChanged);
            // 
            // LblMD5Sum
            // 
            this.LblMD5Sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMD5Sum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblMD5Sum.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblMD5Sum.Location = new System.Drawing.Point(3, 90);
            this.LblMD5Sum.Name = "LblMD5Sum";
            this.LblMD5Sum.Size = new System.Drawing.Size(510, 30);
            this.LblMD5Sum.TabIndex = 69;
            // 
            // PbarCalculationState
            // 
            this.PbarCalculationState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbarCalculationState.Location = new System.Drawing.Point(3, 213);
            this.PbarCalculationState.Name = "PbarCalculationState";
            this.PbarCalculationState.Size = new System.Drawing.Size(510, 24);
            this.PbarCalculationState.Style = MetroFramework.MetroColorStyle.Orange;
            this.PbarCalculationState.TabIndex = 68;
            // 
            // LblChecksumTyp
            // 
            this.LblChecksumTyp.AutoSize = true;
            this.LblChecksumTyp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblChecksumTyp.Location = new System.Drawing.Point(3, 71);
            this.LblChecksumTyp.Name = "LblChecksumTyp";
            this.LblChecksumTyp.Size = new System.Drawing.Size(510, 19);
            this.LblChecksumTyp.TabIndex = 67;
            this.LblChecksumTyp.Text = "MD5 Sum:";
            // 
            // LblFileName
            // 
            this.LblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblFileName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblFileName.Location = new System.Drawing.Point(3, 30);
            this.LblFileName.Name = "LblFileName";
            this.LblFileName.Size = new System.Drawing.Size(510, 30);
            this.LblFileName.TabIndex = 66;
            this.LblFileName.TextChanged += new System.EventHandler(this.LblFileName_TextChanged);
            // 
            // Lbl_FileDescription
            // 
            this.Lbl_FileDescription.AutoSize = true;
            this.Lbl_FileDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Lbl_FileDescription.Location = new System.Drawing.Point(3, 11);
            this.Lbl_FileDescription.Name = "Lbl_FileDescription";
            this.Lbl_FileDescription.Size = new System.Drawing.Size(510, 19);
            this.Lbl_FileDescription.TabIndex = 65;
            this.Lbl_FileDescription.Text = "File:";
            // 
            // BtnStart
            // 
            this.BtnStart.ActiveControl = null;
            this.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStart.Location = new System.Drawing.Point(3, 3);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(174, 27);
            this.BtnStart.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnStart.TabIndex = 73;
            this.BtnStart.Text = "Start";
            this.BtnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnStart.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnStart.UseSelectable = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.BtnStart.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.BtnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // BtnCopyChecksum
            // 
            this.BtnCopyChecksum.ActiveControl = null;
            this.BtnCopyChecksum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCopyChecksum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCopyChecksum.Location = new System.Drawing.Point(3, 61);
            this.BtnCopyChecksum.Name = "BtnCopyChecksum";
            this.BtnCopyChecksum.Size = new System.Drawing.Size(174, 29);
            this.BtnCopyChecksum.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnCopyChecksum.TabIndex = 74;
            this.BtnCopyChecksum.Text = "Copy Checksum";
            this.BtnCopyChecksum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCopyChecksum.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnCopyChecksum.UseSelectable = true;
            this.BtnCopyChecksum.Click += new System.EventHandler(this.BtnCopyChecksum_Click);
            this.BtnCopyChecksum.MouseEnter += new System.EventHandler(this.BtnCopyChecksum_MouseEnter);
            this.BtnCopyChecksum.MouseLeave += new System.EventHandler(this.BtnCopyChecksum_MouseLeave);
            // 
            // BtnChangeChecksum
            // 
            this.BtnChangeChecksum.ActiveControl = null;
            this.BtnChangeChecksum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnChangeChecksum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnChangeChecksum.Location = new System.Drawing.Point(3, 182);
            this.BtnChangeChecksum.Name = "BtnChangeChecksum";
            this.BtnChangeChecksum.Size = new System.Drawing.Size(174, 27);
            this.BtnChangeChecksum.Style = MetroFramework.MetroColorStyle.Orange;
            this.BtnChangeChecksum.TabIndex = 75;
            this.BtnChangeChecksum.Text = "Change Checksum";
            this.BtnChangeChecksum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnChangeChecksum.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnChangeChecksum.UseSelectable = true;
            this.BtnChangeChecksum.Click += new System.EventHandler(this.BtnChangeChecksum_Click);
            this.BtnChangeChecksum.MouseEnter += new System.EventHandler(this.BtnChangeChecksum_MouseEnter);
            this.BtnChangeChecksum.MouseLeave += new System.EventHandler(this.BtnChangeChecksum_MouseLeave);
            // 
            // BackgroundWorker
            // 
            this.BackgroundWorker.WorkerReportsProgress = true;
            this.BackgroundWorker.WorkerSupportsCancellation = true;
            this.BackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.BackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker_ProgressChanged);
            this.BackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // TT4FileName
            // 
            this.TT4FileName.Style = MetroFramework.MetroColorStyle.Blue;
            this.TT4FileName.StyleManager = null;
            this.TT4FileName.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PbControlImage
            // 
            this.PbControlImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PbControlImage.Image = global::Checksum_Inspector.Properties.Resources.Fehler_Kreuz_klein;
            this.PbControlImage.Location = new System.Drawing.Point(3, 107);
            this.PbControlImage.Name = "PbControlImage";
            this.PbControlImage.Size = new System.Drawing.Size(174, 51);
            this.PbControlImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbControlImage.TabIndex = 76;
            this.PbControlImage.TabStop = false;
            // 
            // LblVersion
            // 
            this.LblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblVersion.Location = new System.Drawing.Point(3, 262);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(510, 78);
            this.LblVersion.TabIndex = 77;
            this.LblVersion.Text = "Version: ";
            // 
            // LblUpdate
            // 
            this.LblUpdate.BackColor = System.Drawing.Color.White;
            this.LblUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUpdate.ForeColor = System.Drawing.Color.Black;
            this.LblUpdate.Location = new System.Drawing.Point(648, 5);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(54, 21);
            this.LblUpdate.TabIndex = 78;
            this.LblUpdate.Text = "Update";
            this.LblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblUpdate.Click += new System.EventHandler(this.LblUpdate_Click);
            this.LblUpdate.MouseEnter += new System.EventHandler(this.LblUpdate_MouseEnter);
            this.LblUpdate.MouseLeave += new System.EventHandler(this.LblUpdate_MouseLeave);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "\".zip\"";
            this.SaveFileDialog.Filter = "\"Zip Files|*.zip\"";
            this.SaveFileDialog.Title = "Select path for you zip file";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog_FileOk);
            // 
            // TableLayout4_LabelsTextboxAndBackgroundworker
            // 
            this.TableLayout4_LabelsTextboxAndBackgroundworker.ColumnCount = 1;
            this.TableLayout4_LabelsTextboxAndBackgroundworker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.36905F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.LblVersion, 0, 9);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.LblChecksumTyp, 0, 2);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.Lbl_FileDescription, 0, 0);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.metroLabel6, 0, 6);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.LblMD5Sum, 0, 3);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.LblFileName, 0, 1);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.TxtMD5SumToCheck, 0, 5);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.metroLabel5, 0, 4);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Controls.Add(this.PbarCalculationState, 0, 7);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Location = new System.Drawing.Point(23, 63);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Name = "TableLayout4_LabelsTextboxAndBackgroundworker";
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowCount = 10;
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.TableLayout4_LabelsTextboxAndBackgroundworker.Size = new System.Drawing.Size(516, 285);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.TabIndex = 80;
            // 
            // TableLayout4_ButtonsAndPicBox
            // 
            this.TableLayout4_ButtonsAndPicBox.ColumnCount = 1;
            this.TableLayout4_ButtonsAndPicBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayout4_ButtonsAndPicBox.Controls.Add(this.BtnStart, 0, 0);
            this.TableLayout4_ButtonsAndPicBox.Controls.Add(this.PbControlImage, 0, 4);
            this.TableLayout4_ButtonsAndPicBox.Controls.Add(this.BtnCopyChecksum, 0, 2);
            this.TableLayout4_ButtonsAndPicBox.Controls.Add(this.BtnChangeChecksum, 0, 6);
            this.TableLayout4_ButtonsAndPicBox.Location = new System.Drawing.Point(545, 93);
            this.TableLayout4_ButtonsAndPicBox.Name = "TableLayout4_ButtonsAndPicBox";
            this.TableLayout4_ButtonsAndPicBox.RowCount = 8;
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.89655F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.10345F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.TableLayout4_ButtonsAndPicBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.TableLayout4_ButtonsAndPicBox.Size = new System.Drawing.Size(180, 236);
            this.TableLayout4_ButtonsAndPicBox.TabIndex = 81;
            // 
            // Checksum_InspectorUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(760, 350);
            this.Controls.Add(this.TableLayout4_ButtonsAndPicBox);
            this.Controls.Add(this.TableLayout4_LabelsTextboxAndBackgroundworker);
            this.Controls.Add(this.LblUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Checksum_InspectorUI";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Checksum-Inspector";
            this.Load += new System.EventHandler(this.Checksum_InspectorUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbControlImage)).EndInit();
            this.TableLayout4_LabelsTextboxAndBackgroundworker.ResumeLayout(false);
            this.TableLayout4_LabelsTextboxAndBackgroundworker.PerformLayout();
            this.TableLayout4_ButtonsAndPicBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox TxtMD5SumToCheck;
        private MetroFramework.Controls.MetroLabel LblMD5Sum;
        private MetroFramework.Controls.MetroProgressBar PbarCalculationState;
        private MetroFramework.Controls.MetroLabel LblChecksumTyp;
        private MetroFramework.Controls.MetroLabel LblFileName;
        private MetroFramework.Controls.MetroLabel Lbl_FileDescription;
        private MetroFramework.Controls.MetroTile BtnStart;
        private MetroFramework.Controls.MetroTile BtnCopyChecksum;
        private MetroFramework.Controls.MetroTile BtnChangeChecksum;
        private System.Windows.Forms.PictureBox PbControlImage;
        private System.ComponentModel.BackgroundWorker BackgroundWorker;
        private MetroFramework.Components.MetroToolTip TT4FileName;
        private System.Windows.Forms.Label LblVersion;
        private System.Windows.Forms.Label LblUpdate;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.TableLayoutPanel TableLayout4_LabelsTextboxAndBackgroundworker;
        private System.Windows.Forms.TableLayoutPanel TableLayout4_ButtonsAndPicBox;
    }
}