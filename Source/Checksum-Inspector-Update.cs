using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Checksum_Inspector
{
    public partial class Checksum_Inspector_Update : MetroFramework.Forms.MetroForm
    {
        string DownloadString = "https://checksum-inspector.florian-ballweber.com/Download/";
        string DownloadStringTemplate = "https://checksum-inspector.florian-ballweber.com/Download/";

        public Checksum_Inspector_Update(string VersionOnServer)
        {
            InitializeComponent();
            this.LblAvailableVersion.Text = VersionOnServer; //show available version during the update
            DownloadString += Convert.ToString(VersionOnServer) + "/Files.txt"; //create a download string for 'Files.txt'
            DownloadStringTemplate += Convert.ToString(VersionOnServer) + "/"; //create a template for the download string
        }

        private void Checksum_Inspector_Update_Load(object sender, EventArgs e)
        {            
            //Start the backgroundworker automtic to invoke the update
            if (!(BackgroundWorker4Downoad.IsBusy))
            {
                BackgroundWorker4Downoad.RunWorkerAsync();
            }            
        }

        void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
            Thread.Sleep(10000);
        }

        void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.metroProgressBar1.Value = 0;
            this.LblDownloadProgress.Text = "Downloading File:";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            if (BackgroundWorker4Downoad.IsBusy)
            {
                BackgroundWorker4Downoad.CancelAsync();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        public static string GetMD5Hash(string FilePath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(FilePath))
                {
                    return Encoding.Default.GetString(md5.ComputeHash(stream));
                }
            }
        } 

        private void BackgroundWorker4Downoad_DoWork(object sender, DoWorkEventArgs e)
        {
            Dictionary<string, string> Files = new Dictionary<string, string>(); //empty dictonary for the files we need for the update, later we fill it
            string TempPath = Path.GetTempPath(); //Read out the temporary path
            string line; //empty string, later we use it to save temporary strings from streamreader     

            //Delete 'Files.txt' if it from older updates exist
            if (File.Exists(@TempPath + "\\Files.txt"))
            {
                File.Delete(@TempPath + "\\Files.txt");
            }

            //Create web client and download 'Files.txt' and save it to the temporary files
            //'Files.txt' includes all Files we need for the update
            WebClient Wclient = new WebClient();
            Wclient.DownloadFile(DownloadString, @TempPath + "\\Files.txt");
                        
            //First check if it exist, if it exist, read it out and add it to a string array.
            if (File.Exists(@TempPath + "\\Files.txt"))
            {
                using (StreamReader SR = new StreamReader(@TempPath + "\\Files.txt"))
                {
                    while ((line = SR.ReadLine()) != null)
                    {
                        //Create a temp Array and Split Filename and Md5sum by '|'
                        string[] FileAndMd5Sum = line.Split('|');

                        //Read out Filename and Md5sum from Array 'FileAndMd5Sum'
                        string FileName = FileAndMd5Sum.ElementAt(0); //key
                        string Md5Sum = FileAndMd5Sum.ElementAt(1); //value
                        
                        //Fill Dictionary with Filename and Md5Sum
                        Files.Add(FileName, Md5Sum);
                    }
                }

                //Creat a new string and copy the download template string, we need it to reset the download string later
                string DownloadStringTemplateBefore = DownloadStringTemplate;

                //'CurrentFiles' working as a counter for the current file which we download                
                int CurrentFiles = 0;

                //Count all strings in 'Files' array and set progressbar maximum
                int TotalFiles = Files.Count;
                
                //Count Errors, by more than 5 Erros cancel update!
                int ErrorDownloadCounter = 0;

                metroProgressBar1.Maximum = TotalFiles;
                
                foreach(KeyValuePair<string, string> File4Download in Files)
                {
                    //Create webclient and add some events
                    WebClient webClient = new WebClient();
                    webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
                    webClient.DownloadProgressChanged += webClient_DownloadProgressChanged;
                    
                    //Add the file name to the download string and creat a link for web client
                    DownloadStringTemplate += File4Download.Key;
                                        
                    //Download file and save it to temporary files
                    Wclient.DownloadFile(DownloadStringTemplate, @TempPath + "\\" + File4Download.Key);
                                        
                    //Show current file 
                    this.LblDownloadProgress.Text = "Downloading File: " + File4Download.Key.ToString();

                    //Reset 'DownloadStringTemplate' for the next run in the loop
                    DownloadStringTemplate = DownloadStringTemplateBefore;       
             
                    //extend counter with 1, because the file is finish downloaded
                    CurrentFiles++;

                    //Report the current download file 
                    BackgroundWorker4Downoad.ReportProgress(CurrentFiles);
                }
                //Reset the label who shows the current download file
                this.LblDownloadProgress.Text = "Downloading File: ";
            }
            
            string OutputForComparing = "========================================SharpShell - Server Registration Manager========================================Preparing to install (OS64Bit): Class1    Class1 installed and registered.";
            string Version = this.LblAvailableVersion.Text.ToString();
            string ChecksumInspectorDLL = "Checksum-Inspector.dll";
            this.LblDownloadProgress.Text = "Installing " + ChecksumInspectorDLL;
            if (File.Exists(TempPath + "/" + ChecksumInspectorDLL))
            {
                try
                {
                    //Create process start info and parse install string with arguments
                    System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/c " + @TempPath + "\\" + "srm.exe install " + @TempPath + "\\" + ChecksumInspectorDLL + " -codebase");

                    //Settings of process info
                    procStartInfo.RedirectStandardOutput = true; //set it to true to get output
                    procStartInfo.UseShellExecute = false;
                    procStartInfo.CreateNoWindow = true; //hide cmd window 
                                      
                    //Start process with process info 
                    using (Process process = Process.Start(procStartInfo))
                    {
                        //Get standardoutput with streamreader
                        using (StreamReader sr = process.StandardOutput)
                        {
                            //Get output from process
                            string Output = sr.ReadToEnd();

                            //Remove line breaks for comparing
                            Output = Output.Replace(System.Environment.NewLine, "");
                                                        
                            //Compare the output with a local varibable what includes the message for succesfully installation
                            if (Output == OutputForComparing)
                            {
                                MetroMessageBox.Show(this, "\nUpdate to version " + Version + " was sucessfully!\nTo finish the installation the explorer process must be restarted.");
                            }                                                      
                        }
                    }

                    //Close the update form
                    this.Close();

                    //kill explorer process to show the new Checksum-Inspector Version in explorer context menu
                    try
                    {
                        foreach (var process in Process.GetProcessesByName("explorer"))
                        {
                            process.Kill();
                        }
                    }
                    catch (Exception ex)
                    {
                        MetroMessageBox.Show(this, "Failed to kill explorer process, please kill it manually to finish installation:\n" + ex.Message);
                    }
                }
                catch (Exception objException)
                {
                    MetroMessageBox.Show(this,"Problems by installation. Contact the support wiht following exeption:" + Environment.NewLine + objException.Message);
                }
            }
        }

        private void BackgroundWorker4Downoad_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressBar1.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker4Downoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            metroProgressBar1.Value = 0;            
        }
    }
}
