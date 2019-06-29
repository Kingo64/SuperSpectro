using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SuperSpectro {

    public partial class UI : Form {

        string[] allFiles;

        public UI() {
            InitializeComponent();
        }

        private void bBuildList_Click(object sender, EventArgs e) {
            try {
                allFiles = Directory.GetFileSystemEntries(tbInput.Text, tbFilemask.Text, SearchOption.AllDirectories);
                tbFiles.Text = string.Join(Environment.NewLine, allFiles);
                lFileCounter.Text = "Files: " + allFiles.Length;
            }
            catch { }
        }

        private void bExecute_Click(object sender, EventArgs e) {
            if (File.Exists(Directory.GetCurrentDirectory() + "\\ffmpeg.exe")) {
                try {
                    ThreadPool.SetMinThreads(1, 0);
                    ThreadPool.SetMaxThreads(Convert.ToInt32(nThreads.Value), 0);
                    foreach (string file in allFiles) {
                        ThreadInfo ti = new ThreadInfo();
                        ti.file = file;
                        ThreadPool.QueueUserWorkItem(new WaitCallback(buildSpectro), ti);
                    }
                }
                catch { }
            } else {
                MessageBox.Show("ffmpeg.exe missing");
            }
        }

        private void buildSpectro(object a) {
            ThreadInfo threadInfo = a as ThreadInfo;
            string file = threadInfo.file;
            string filename = file.Replace("\\", "").Replace(":", "");
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = Directory.GetCurrentDirectory() + "\\ffmpeg.exe";
            startInfo.Arguments = "-i " + "\"" + file + "\" -lavfi showspectrumpic=s=" + tbRes.Text + " \"" + tbOutput.Text + filename + ".png\"";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process p = new Process();
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();
            p.Close();
        }
    }

    class ThreadInfo {
        public string file { get; set; }
    }
}
