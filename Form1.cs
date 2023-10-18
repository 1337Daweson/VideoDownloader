using Fiddler;
using PuppeteerSharp;
using System.CodeDom;
using System.Diagnostics;
using System.Net;
using System.Text.RegularExpressions;

namespace VideoDownloader
{
    public partial class Form1 : Form
    {
        private const string MANUAL = "http://czprgsvld00:6122/video-downloader/IndexManual.pdf";
        private const string HELP = "https://github.com/yt-dlp/yt-dlp/blob/master/supportedsites.md";
        private const string PROGRAMS = "C:\\Users\\Default\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_Download.Enabled = false;
        }

        /// <summary>
        /// Disables all controls in form
        /// </summary>
        /// <param name="control"></param>
        private void DisableForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                c.Enabled = false;
                if (c.HasChildren)
                {
                    DisableForm(c);
                }
            }
        }

        /// <summary>
        /// Enables all controls in form
        /// </summary>
        /// <param name="control"></param>
        private void EnableForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                c.Enabled = true;
                if (c.HasChildren)
                {
                    EnableForm(c);
                }
            }
        }

        /// <summary>
        /// Opens microsoft edge with link from the linkLabel component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "msedge.exe",
                UseShellExecute = true,
                WorkingDirectory = PROGRAMS,
                Arguments = HELP,
            };

            Process process = new Process() { StartInfo = startInfo };
            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            linkLabel.LinkVisited = true;
        }

        /// <summary>
        /// Selects the path for the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Path_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            textBox_Path.Text = folderBrowserDialog.SelectedPath;
        }

        /// <summary>
        /// Updates the Output TextBox using Invoke method
        /// </summary>
        /// <param name="text"></param>
        private void UpdateOutput(string text)
        {
            if (textBox_Output.InvokeRequired)
            {
                textBox_Output.Invoke(new Action<string>(UpdateOutput), text);
            }
            else
            {
                textBox_Output.Text = text;
            }
        }

        /// <summary>
        /// Checks if all criteria to download a file are met
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void EnableDownloadButton(object sender, EventArgs e)
        {
            string pattern = @"^(https?|ftp)://[^\s/$.?#].[^\s]*$";
            Regex regex = new Regex(pattern);

            button_Download.Enabled = (!string.IsNullOrEmpty(textBox_URL.Text) &&
                regex.IsMatch(textBox_URL.Text) &&
                !string.IsNullOrEmpty(textBox_Filename.Text) &&
                !string.IsNullOrEmpty(textBox_Path.Text)) ||
                (!string.IsNullOrEmpty(textBox_URL.Text) &&
                textBox_OptionalArgs.Text.StartsWith("-F"));
        }

        /// <summary>
        /// Downloads the file using yt-dlp console app and shows output from command line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button_Download_Click(object sender, EventArgs e)
        {
            // nejlepší možné video ale ne s vyšší výškou než 576
            DisableForm(this);
            const string quote = "\"";
            string url = textBox_URL.Text;
            string filename = textBox_Filename.Text + ".mp4";
            string path = quote + folderBrowserDialog.SelectedPath + quote;
            string sanitizedUrl = quote + url + quote;
            string optionalArgs = textBox_OptionalArgs.Text;
            bool isOptionalArgsSet = textBox_OptionalArgs.Text != String.Empty;
            string command = $"yt-dlp.exe {sanitizedUrl} -o {filename} -P {path} -S height:576";

            if (isOptionalArgsSet)
            {
                command = $"yt-dlp.exe {sanitizedUrl} -o {filename} -P {path} {optionalArgs}";
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + command,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.OutputDataReceived += (sender, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data))
                    {
                        UpdateOutput(args.Data);
                    }
                };

                process.ErrorDataReceived += (sender, args) =>
                {
                    if (!string.IsNullOrEmpty(args.Data))
                    {
                        UpdateOutput(args.Data);
                    }
                };

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                await process.WaitForExitAsync();
                MessageBox.Show("Video bylo úspìšnì staženo!", "Video Downloader");
                EnableForm(this);
            }
        }

        /// <summary>
        /// Opens manual in microsoft edge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel_Manual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "msedge.exe",
                UseShellExecute = true,
                WorkingDirectory = PROGRAMS,
                Arguments = MANUAL,
            };

            Process process = new Process() { StartInfo = startInfo };
            try
            {
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            linkLabel.LinkVisited = true;
        }

        /// <summary>
        /// Updates yt-dlp.exe
        /// </summary>
        private async void UpdateYtDlp()
        {
            string command = $"yt-dlp.exe -U";
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + command,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                using (Process process = new Process() { StartInfo = startInfo })
                {
                    DisableForm(this);
                    process.Start();
                    process.BeginOutputReadLine();
                    process.OutputDataReceived += (sender, args) =>
                    {
                        if (!string.IsNullOrEmpty(args.Data))
                        {
                            UpdateOutput(args.Data);
                        }
                    };
                    await process.WaitForExitAsync();
                    EnableForm(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdateYtDlp();
        }

    }
}