using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using VideoEncoder;
using System.Threading;
using System.Diagnostics;

namespace VideoSplit
{
    public partial class MainForm : Form
    {
        private string file = null;
        private string formate = null;
        private string path = null;

        public MainForm()
        {
            InitializeComponent();
            InitOption();
        }

        private void InitOption()
        {
            radioNum.Checked = true;
            boxEndHour.SelectedIndex = 0;
            boxEndMin.SelectedIndex = 0;
            boxEndSec.SelectedIndex = 0;
            boxPartHour.SelectedIndex = 0;
            boxPartMin.SelectedIndex = 0;
            boxPartNum.SelectedIndex = 0;
            boxPartSec.SelectedIndex = 0;
            boxStartHour.SelectedIndex = 0;
            boxStartMin.SelectedIndex = 0;
            boxStartSec.SelectedIndex = 0;

        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            textVideo.Text = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textVideo.Text == null)
            {
                MessageBox.Show("path empty");
                return;
            }
            if (!File.Exists(textVideo.Text))
            {
                MessageBox.Show("file does not exist.");
                return;
            }
            EnableUI(false);
            file = textVideo.Text;
            formate = file.Substring(file.LastIndexOf("."), file.Length - file.LastIndexOf("."));
            path = file.Substring(0, file.Length - formate.Length);
            if (radioTime.Checked)
            {
                VideoSplitByTime();
            }
            else if (radioNum.Checked)
            {
                VideoSplitByParts();
            }
            else
            {
                VideoStract();
            }
        }

        private void VideoSplitByTime()
        {
            int time = Int32.Parse(boxPartHour.Text) * 3600
                + Int32.Parse(boxPartMin.Text) * 60
                + Int32.Parse(boxPartSec.Text);
            VideoEncoder.Encoder enc = new VideoEncoder.Encoder();
            enc.FFmpegPath = "ffmpeg.exe";
            VideoFile vf = new VideoFile(file);
            enc.GetVideoInfo(vf);
            TimeSpan t = vf.Duration;
            //int tt =(int)t.TotalSeconds;
            int parts = (int)t.TotalSeconds / time + 1;

            #region thread start

            //EnableUI(false);
            new Thread(() =>
            {
                for (int i = 0; i < parts; i++)
                {
                    Process p = new Process();
                    string ph = Environment.CommandLine;
                    ph = ph.Substring(0, ph.LastIndexOf('\\') + 1);
                    if (ph[0] == '"')
                        ph = ph.Substring(1);
                    p.StartInfo.FileName = "\"" + ph + "ffmpeg.exe\"";
                    p.StartInfo.Arguments = " -ss " + (i == 0 ? 0 : time * i - 10).ToString()
                        + " -i " + "\"" + file + "\""
                        + " -vcodec copy -acodec copy "
                        + " -t " + (i == 0 ? time : (time + 10)).ToString() + " "
                        + "\"" + path + (i + 1).ToString("00") + formate + "\"";
                    p.StartInfo.RedirectStandardError = true;
                    p.ErrorDataReceived += new DataReceivedEventHandler(SplitOutput);
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    p.BeginErrorReadLine();
                    p.WaitForExit();
                    p.Close();
                    p.Dispose();

                }

                this.BeginInvoke(new MethodInvoker(() =>
                {
                    EnableUI(true);
                    //this.Text = title + " - 分割完成!";
                }));
            }).Start();
            #endregion

        }

        private void VideoSplitByParts()
        {
            int parts = Int32.Parse(boxPartNum.Text);
            VideoEncoder.Encoder enc = new VideoEncoder.Encoder();
            enc.FFmpegPath = "ffmpeg.exe";
            VideoFile vf = new VideoFile(file);
            enc.GetVideoInfo(vf);
            TimeSpan t = vf.Duration;
            int time = (int)t.TotalSeconds / parts + 10;

            #region thread start

            //EnableUI(false);
            new Thread(() =>
            {
                for (int i = 0; i < parts; i++)
                {
                    Process p = new Process();
                    string ph = Environment.CommandLine;
                    ph = ph.Substring(0, ph.LastIndexOf('\\') + 1);
                    if (ph[0] == '"')
                        ph = ph.Substring(1);
                    p.StartInfo.FileName = "\"" + ph + "ffmpeg.exe\"";
                    p.StartInfo.Arguments = " -ss " + (i == 0 ? 0 : time * i - 10).ToString()
                        + " -i " + "\"" + file + "\""
                        + " -vcodec copy -acodec copy "
                        + " -t " + (i == 0 ? time : (time + 10)).ToString() + " "
                        + "\"" + path + (i + 1).ToString("00") + formate + "\"";
                    p.StartInfo.RedirectStandardError = true;
                    p.ErrorDataReceived += new DataReceivedEventHandler(SplitOutput);
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.CreateNoWindow = true;
                    p.Start();
                    p.BeginErrorReadLine();
                    p.WaitForExit();
                    p.Close();
                    p.Dispose();

                }

                this.BeginInvoke(new MethodInvoker(() =>
                {
                    EnableUI(true);
                    //this.Text = title + " - 分割完成!";
                }));
            }).Start();
            #endregion
        }

        private void VideoStract()
        {
            int startTime = Int32.Parse(boxStartHour.Text) * 3600
                + Int32.Parse(boxStartMin.Text) * 60
                + Int32.Parse(boxStartSec.Text);
            int endTime = Int32.Parse(boxEndHour.Text) * 3600
                + Int32.Parse(boxEndMin.Text) * 60
                + Int32.Parse(boxEndSec.Text);
            #region thread start

            //EnableUI(false);
            new Thread(() =>
            {

                Process p = new Process();
                string ph = Environment.CommandLine;
                ph = ph.Substring(0, ph.LastIndexOf('\\') + 1);
                if (ph[0] == '"')
                    ph = ph.Substring(1);
                p.StartInfo.FileName = "\"" + ph + "ffmpeg.exe\"";
                p.StartInfo.Arguments = " -ss " + startTime.ToString()
                    + " -i " + "\"" + file + "\""
                    + " -vcodec copy -acodec copy "
                    + " -t " + (endTime - startTime).ToString() + " "
                    + "\"" + path + "_stract" + formate + "\"";
                p.StartInfo.RedirectStandardError = true;
                p.ErrorDataReceived += new DataReceivedEventHandler(SplitOutput);
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.BeginErrorReadLine();
                p.WaitForExit();
                p.Close();
                p.Dispose();



                this.BeginInvoke(new MethodInvoker(() =>
                {
                    EnableUI(true);
                    //this.Text = title + " - 分割完成!";
                }));
            }).Start();
            #endregion
        }

        private void SplitOutput(object sendProcess, DataReceivedEventArgs output)
        {
            if (String.IsNullOrEmpty(output.Data)) return;
            this.Invoke(new MethodInvoker(() =>
            {
                labelStatu.Text = output.Data;
                //listBoxStat.
            }));

        }

        private void EnableUI(Boolean on)
        {
            //
            textVideo.Enabled = on;
            groupBox1.Enabled = on;
            buttonStart.Enabled = on;
        }

    }
}
