using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Globalization;
using System.IO.Compression;
using System.Diagnostics;
using MetroFramework.Controls;

namespace Checksum_Inspector
{
    public partial class Checksum_InspectorUI : MetroFramework.Forms.MetroForm
    {
        string FilePathToZipFile;
                       
        //global variable bool, he decides if md5 or sha1 should calculated
        bool Md5YesNo = true;

        //global variable for the current version
        double Version = 1.1;

        public Checksum_InspectorUI(string FilePath)
        {
            InitializeComponent();
            this.LblFileName.Text = FilePath.ToString(); //Get Path and write it to label            
        }

        private void Checksum_InspectorUI_Load(object sender, EventArgs e)
        {
            //Get current installed version and show it on a label
            this.LblVersion.Text = "Version: " + Version.ToString("0.0");

            //Get filepath and wirte him to a string value
            string PathToFile = this.LblFileName.Text;
            
            //Check for Updtes, onetime
            Check4Updates();            

            //create instanc of Fileinfo
            FileInfo FI = new FileInfo(PathToFile);
                        
            //create FI as Fileinfo and check if file is empty
            //if file is not empty start calculation
            if (FI.Length > 0)
            {
                //Edit all elemnts for the zip file creation
                this.BtnStart.PerformClick();
            }
            else
            {
                MetroMessageBox.Show(this, "The file is empty!", "Information", MessageBoxButtons.OK);
                this.Close();
            }
        }
               
        private void Check4Updates()
        {
            //Download File from extern server to check how many people downloading the programm
            //later i will check the version on the server            
            string TempPath = Path.GetTempPath();

            if (!(File.Exists(@TempPath + "\\" + "version.txt")))
            {
                WebClient Wclient = new WebClient();
                Wclient.DownloadFile("https://checksum-inspector.florian-ballweber.com/Download/version.txt", @TempPath + "\\" + "version.txt");

                if (File.Exists(@TempPath + "\\" + "version.txt"))
                {
                    using (StreamReader SR = new StreamReader(@TempPath + "\\" + "version.txt"))
                    {
                        string TextFromFile = SR.ReadLine();
                        double VersionOnServer = double.Parse(TextFromFile, CultureInfo.InvariantCulture);

                        if (VersionOnServer > Version)
                        {
                            DialogResult result = MetroMessageBox.Show(this, "Version " + TextFromFile + " is available!\n\nContinue with update?", "Update", MessageBoxButtons.YesNo);
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                Checksum_Inspector_Update CIUpdateGUI = new Checksum_Inspector_Update(TextFromFile);
                                CIUpdateGUI.ShowDialog();
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "\nThe current version, " + TextFromFile + " is up to date! \nPlease check later for a new version.");
                            this.LblVersion.Text = "Version: " + TextFromFile;
                        }
                    }
                }
            }
            else
            {
                this.LblVersion.Text = "Version: " + Version.ToString("0.0");
            }
        }

        #region Buttons Enter and Leave Events for Color Effect
        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            this.BtnStart.Style = MetroColorStyle.Silver;
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            this.BtnStart.Style = MetroColorStyle.Orange;
        }        

        private void BtnCopyChecksum_MouseEnter(object sender, EventArgs e)
        {
            this.BtnCopyChecksum.Style = MetroColorStyle.Silver;
        }

        private void BtnCopyChecksum_MouseLeave(object sender, EventArgs e)
        {
            this.BtnCopyChecksum.Style = MetroColorStyle.Orange;
        }

        private void BtnChangeChecksum_MouseEnter(object sender, EventArgs e)
        {
            this.BtnChangeChecksum.Style = MetroColorStyle.Silver;
        }

        private void BtnChangeChecksum_MouseLeave(object sender, EventArgs e)
        {
            this.BtnChangeChecksum.Style = MetroColorStyle.Orange;
        }              
        #endregion
                
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //If Worker is busy stop him with 'CancelAsync()' and reset Text
            if (BackgroundWorker.IsBusy)
            {
                BackgroundWorker.CancelAsync();
                this.BtnStart.Text = "Start";
            }
            else
            {
                //Get Path to File from Label
                string PathToFile = this.LblFileName.Text;

                //Calculate Md5
                if (File.Exists(PathToFile))
                {
                    //Reset Elements
                    this.LblMD5Sum.Text = "";
                    this.BtnChangeChecksum.Enabled = false;
                    this.BtnCopyChecksum.Enabled = false;
                    this.TxtMD5SumToCheck.Text = "";
                    this.BtnStart.Text = "Stop";
                    this.PbControlImage.Image = Checksum_Inspector.Properties.Resources.Fehler_Kreuz_klein;

                    //Start Backgroundworker and deliver Filepath
                    BackgroundWorker.RunWorkerAsync(PathToFile);
                }
                else
                {
                    MetroMessageBox.Show(this, "The destination path dosent exist! \nPlease check it and try the calculation again.", "Information");
                }
            }
        }

        void Btn_Open_Click(object sender, EventArgs e)
        {            
            
        }
        
        private void ResizeForm()
        {
            
        }

        private void SaveFileDialog_FileOk(object sender, CancelEventArgs e)
        {             
           
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            //Get Path
            string FilePath = e.Argument.ToString();

            //declare variables for calculation
            byte[] buffer = null;
            long size;
            int bytesRead;
            long totalBytesRead = 0;

            //Open File Stream on file
            using (Stream file = File.OpenRead(FilePath))
            {
                //Get Size of File
                size = file.Length;

                //Check if 'md5YesNo' ist true or false, if true -> calculate md5, if false -> calcualte sha1
                //the user can change it with a button, in the background the bool switches
                if (Md5YesNo)
                {
                    //Calculate md5
                    using (HashAlgorithm hasher = MD5.Create())
                    {
                        do
                        {
                            //if the user cancel the backgroundworker, "CancellationPending" will change to true. 
                            //check it, if is true stop loop with break.
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }
                            else
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                hasher.TransformBlock(buffer, 0, bytesRead, null, 0);
                                BackgroundWorker.ReportProgress((int)((double)totalBytesRead / size * 100));
                            }
                        }
                        while (bytesRead != 0);

                        hasher.TransformFinalBlock(buffer, 0, 0);
                        e.Result = MakeHashString(hasher.Hash);
                    }
                }
                else
                {
                    //Calculate sha1
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        do
                        {
                            //if you user cancel the backgroundworker, "CancellationPending" will change to true. 
                            //check it, if is true stop loop with break.
                            if (worker.CancellationPending == true)
                            {
                                e.Cancel = true;
                                break;
                            }
                            else
                            {
                                buffer = new byte[4096];
                                bytesRead = file.Read(buffer, 0, buffer.Length);
                                totalBytesRead += bytesRead;
                                sha1.TransformBlock(buffer, 0, bytesRead, null, 0);
                                BackgroundWorker.ReportProgress((int)((double)totalBytesRead / size * 100));
                            }
                        }
                        while (bytesRead != 0);

                        sha1.TransformFinalBlock(buffer, 0, 0);
                        e.Result = MakeHashString(sha1.Hash);
                    }
                }
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //set progressbar value to current percentage
            PbarCalculationState.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //If Backgroundworker was canceled or finish, this event would anytime enter.
            //reset progressbar
            PbarCalculationState.Value = 0;
            
            //If Backgroundworker was not canceled, write checksum to label
            if (!(e.Cancelled == true))
            {
                this.LblMD5Sum.Text = e.Result.ToString();
                CheckCheckSumms();
            }

            //Reset Elements
            this.BtnChangeChecksum.Enabled = true;
            this.BtnCopyChecksum.Enabled = true;
            this.BtnStart.Text = "Start";
            this.BtnStart.Enabled = true;
            
        }
        private static string MakeHashString(byte[] hashBytes)
        {
            StringBuilder hash = new StringBuilder(32);

            foreach (byte b in hashBytes)
            {
                hash.Append(b.ToString("X2").ToLower());
            }

            return hash.ToString();
        }

        private void BtnCopyChecksum_Click(object sender, EventArgs e)
        {
            if (!(this.LblMD5Sum.Text == "")) //If label not empty
            {
                Clipboard.SetText(this.LblMD5Sum.Text.ToString()); // Get Checksum and copy to cash
            }
            else
            {
                MetroMessageBox.Show(this, "No checksum for copy! Please press start for calculation", "Information");
            }
        }

        private void LblFileName_TextChanged(object sender, EventArgs e)
        {
            //if filepath is to long for the label (55 chars), create a tooltip
            if (this.LblFileName.Text.Count() > 55)
            {
                this.TT4FileName.SetToolTip(this.LblFileName, Path.GetFileName(this.LblFileName.Text));
            }
        }
        private void CheckCheckSumms()
        {
            //check if checksumms compare and change picture
            if (this.LblMD5Sum.Text.ToUpper() == this.TxtMD5SumToCheck.Text.ToUpper())
            {
                this.PbControlImage.Image = Checksum_Inspector.Properties.Resources.Ok_Haken_klein;
            }
            else
            {
                this.PbControlImage.Image = Checksum_Inspector.Properties.Resources.Fehler_Kreuz_klein;
            }
        }

        private void TxtMD5SumToCheck_TextChanged(object sender, EventArgs e)
        {
            CheckCheckSumms(); //after any text change check the checksumms
        }

        private void BtnChangeChecksum_Click(object sender, EventArgs e)
        {
            //bool value to check if user will md5 or sha1            
            this.PbControlImage.Image = Checksum_Inspector.Properties.Resources.Fehler_Kreuz_klein; //reset picture before starting
            this.TxtMD5SumToCheck.Text = ""; //reset label

            if (Md5YesNo == true)
            {
                Md5YesNo = false;
                this.LblMD5Sum.Text = "";
                this.LblChecksumTyp.Text = "SHA1 Sum:";
            }
            else
            {
                Md5YesNo = true;
                this.LblMD5Sum.Text = "";
                this.LblChecksumTyp.Text = "MD5 Sum:";
            }
        }
               
        private void LblUpdate_Click(object sender, EventArgs e)
        {
            string TempPath = Path.GetTempPath();

            if (File.Exists(@TempPath + "\\" + "version.txt"))
            {
                File.Delete(@TempPath + "\\" + "version.txt");
            }
            Check4Updates();
        }

        private void LblUpdate_MouseEnter(object sender, EventArgs e)
        {
            this.LblUpdate.BackColor = Color.WhiteSmoke;
        }

        private void LblUpdate_MouseLeave(object sender, EventArgs e)
        {
            this.LblUpdate.BackColor = Color.White;
        }

        private void BackgroundWorker4ZipCreation_DoWork(object sender, DoWorkEventArgs e)
        {
                                 
        }

        private void BackgroundWorker4ZipCreation_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PbarCalculationState.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker4ZipCreation_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.BtnStart.Text = "Start";
            this.Lbl_FileDescription.Text = "File:";            
            this.BtnStart.PerformClick();
        }        
    }
}