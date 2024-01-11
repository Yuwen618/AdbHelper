using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdbHelper
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer adbCheckTimer;

        private System.Windows.Forms.Timer timeCheckTimer;
        public Form1()
        {
            InitializeComponent();
            this.TopMost = false;
            checkBox1.Checked = false;

            InitializeTimer();



            textbox_apkname.AllowDrop = true;
            textbox_apkname.DragEnter += PushAPK_TextBox1_DragEnter;
            textbox_apkname.DragDrop += PushAPK_TextBox1_DragDrop;

            apk_to_install.AllowDrop = true;
            apk_to_install.DragEnter += InstallAPK_TextBox1_DragEnter;
            apk_to_install.DragDrop += InstallAPK_TextBox1_DragDrop;

            this.Width = 568;
            this.Height = 110;
        }

        private void PushAPK_TextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PushAPK_TextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                string filePath = files[0];
                textbox_apkname.Text = $"{filePath}{Environment.NewLine}";
            }
        }

        private void InstallAPK_TextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (files.Length == 1)
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void InstallAPK_TextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length == 1)
            {
                string filePath = files[0];
                apk_to_install.Text = $"{filePath}{Environment.NewLine}";
            }
        }

        private async void startlogbtn_Click(object sender, EventArgs e)
        {
            string keyword = "";

            if (!string.IsNullOrEmpty(textbox_log11.Text.Trim()))
            {
                keyword += " -e '" + textbox_log11.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log12.Text.Trim()))
            {
                keyword += " -e '" + textbox_log12.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log13.Text.Trim()))
            {
                keyword += " -e '" + textbox_log13.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log14.Text.Trim()))
            {
                keyword += " -e '" + textbox_log14.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log15.Text.Trim()))
            {
                keyword += " -e '" + textbox_log15.Text.Trim() + "'";
            }
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("At least 1 keyword needed");
                return;
            }

            await Task.Run(() => executecommand("adb shell \"logcat|grep -i " + keyword + "\"", false));
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => RunCommand(" shell input keyevent 3"));
        }

        private async void enablelogbtn_Click(object sender, EventArgs e)
        {

            await Task.Run(() =>
            {
                RunCommand(" root");
                RunCommand(" remount");
                RunCommand(" shell setprop persist.log.tag Dlog");
                RunCommand(" shell setprop persist.log.tag VERBOSE");
                RunCommand(" logcat -c;adb logcat -G 250m");
            });
        }

        private async void pushbtn_Click(object sender, EventArgs e)
        {
            string apkFilePath = textbox_apkname.Text.Trim();

            if (!string.IsNullOrWhiteSpace(apkFilePath))
            {
                if (!apkFilePath.EndsWith(".apk"))
                {
                    MessageBox.Show("not valid apk");
                    return;
                }

                string dest = textbox_apk_destination.Text.Trim();
                if (string.IsNullOrWhiteSpace(dest))
                {
                    MessageBox.Show("destination path needed to be specified, start with /, for example : /system/app/");
                    return;
                }

                await Task.Run(() => RunAdbInstall("push " + apkFilePath + " " + dest));
            }
            else
            {
                MessageBox.Show("no file");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBox1.Checked;
        }

        private void executecommand(string command, bool nowindow)
        {
            ProcessStartInfo info = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                RedirectStandardInput = false,
                RedirectStandardOutput = false,
                CreateNoWindow = nowindow,
                UseShellExecute = false
            };
            Process process = new Process
            {
                StartInfo = info
            };
            process.StartInfo.Arguments = "/K " + command;
            process.Start();


            //process.StandardInput.WriteLine(command);
            process.WaitForExit();
            //process.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void startStopTimeCheckTimer(bool start)
        {
            if (start)
            {
                if (timeCheckTimer == null)
                {
                    timeCheckTimer = new System.Windows.Forms.Timer();
                    adbCheckTimer.Interval = 1000;
                    adbCheckTimer.Tick += TimeCheckTimer_Tick;
                }
                RunCommand(" shell setprop persist.logd.timestamp Realtime");
                timeCheckTimer.Start();
            }
            else
            {
                if (timeCheckTimer != null)
                {
                    timeCheckTimer.Stop();
                }
            }
        }

        private void TimeCheckTimer_Tick(object sender, EventArgs e)
        {
            checkADBTime();
        }

        private void InitializeTimer()
        {
            adbCheckTimer = new System.Windows.Forms.Timer();

            adbCheckTimer.Interval = 3000;

            adbCheckTimer.Tick += AdbCheckTimer_Tick;

            adbCheckTimer.Start();
        }

        private void AdbCheckTimer_Tick(object sender, EventArgs e)
        {

            checkADBDevice();
        }

        private void checkADBTime()
        {
            string adbCommand = "shell date";
            string adbOutput = RunCommand(adbCommand);
            Regex regex = new Regex(@"(\d{2}:\d{2}:\d{2})");
            Match match = regex.Match(adbOutput);

            if (match.Success)
            {
                hutime_label.Text = match.Groups[1].Value;
            }
        }

        bool mADBDeviceConnected = false;

        private void checkADBDevice()
        {
            string adbCommand = "devices";
            string adbOutput = RunCommand(adbCommand);

            string devicename = IsDeviceConnected(adbOutput);

            if (devicename != null)
            {
                lable_device.Text = devicename;
                mADBDeviceConnected = true;
            }
            else
            {
                lable_device.Text = "No adb device";
                mADBDeviceConnected = false;
            }
            enableCommandBtns(mADBDeviceConnected);
            startStopTimeCheckTimer(devicename != null);
        }

        private void enableCommandBtns(bool enable)
        {
            btn_backkey.Enabled = enable;
            btn_homekey.Enabled = enable;
            enablelogbtn.Enabled = enable;
            adbrebootbutton.Enabled = enable;
            pushbtn.Enabled = enable;
            btn_adb_install.Enabled = enable;
            killbutton1.Enabled = enable;
            startlogbtn.Enabled = enable;
            btnstartlog2.Enabled = enable;
        }

        static string RunCommand(string command, bool nowindow)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = "adb",
                Arguments = command,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = nowindow,
                UseShellExecute = false
            };

            Process process = new Process
            {
                StartInfo = processStartInfo
            };
            process.Start();

            //            process.StandardInput.WriteLine(command + " & exit");
            string output = process.StandardOutput.ReadToEnd();

            process.WaitForExit();

            return output;
        }

        static string RunCommand(string command)
        {
            return RunCommand(command, true);
        }

        static string IsDeviceConnected(string adbOutput)
        {
            bool foundstartline = false;
            string[] lines = adbOutput.Split('\n');
            foreach (string line in lines)
            {
                if (line == "List of devices attached\r")
                {
                    foundstartline = true;
                    continue;
                }

                if (foundstartline && !string.IsNullOrWhiteSpace(line) && line.Contains("device"))
                {
                    string[] parts = line.Split("\t");
                    if (parts.Length >= 1)
                    {
                        return parts[0].Trim();
                    }
                }
            }

            return null;
        }

        private void textbox_apkname_TextChanged(object sender, EventArgs e)
        {

        }





        private async void btnInstall_Click(object sender, EventArgs e)
        {
            string apkFilePath = apk_to_install.Text.Trim();

            if (!string.IsNullOrWhiteSpace(apkFilePath))
            {
                if (!apkFilePath.EndsWith(".apk"))
                {
                    MessageBox.Show("not valid apk");
                    return;
                }
                await Task.Run(() => RunAdbInstall(" install -r " + apkFilePath));
            }
            else
            {
                MessageBox.Show("no file");
            }
        }

        private void RunAdbInstall(string arguments)
        {

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "adb",
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                }
            };

            process.Start();


            string output = process.StandardOutput.ReadToEnd();

            process.WaitForExit();

            this.Invoke((MethodInvoker)delegate
            {
                MessageBox.Show(output, "");
            });
        }

        private void btn_adb_install_Click(object sender, EventArgs e)
        {
            btnInstall_Click(sender, e);
        }

        private async void btn_homekey_Click(object sender, EventArgs e)
        {
            await Task.Run(() => RunCommand(" shell input keyevent 4"));
        }

        private async void adbrebootbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            await Task.Run(() => RunCommand(" reboot"));
        }

        private async void killbutton1_Click(object sender, EventArgs e)
        {
            string apppkg = killpackagename1.Text.Trim();
            if (!string.IsNullOrEmpty(apppkg))
            {
                await Task.Run(() => RunCommand(" shell pkill -f " + apppkg));
            }
            else
            {
                MessageBox.Show("Input package name");
            }
        }

        private void btnChangeHeight_Click(object sender, EventArgs e)
        {
            if (this.Height == 110)
            {
                this.Height = 312;
                btnChangeHeight.Text = "^";
            }
            else
            {
                this.Height = 110;
                btnChangeHeight.Text = "v";
            }
        }

        private async void btnstartlog2_Click(object sender, EventArgs e)
        {
            if (!mADBDeviceConnected)
            {
                MessageBox.Show("No adb device");
                return;
            }
            string keyword = "";

            if (!string.IsNullOrEmpty(textbox_log21.Text.Trim()))
            {
                keyword += " -e '" + textbox_log21.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log22.Text.Trim()))
            {
                keyword += " -e '" + textbox_log22.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log23.Text.Trim()))
            {
                keyword += " -e '" + textbox_log23.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log24.Text.Trim()))
            {
                keyword += " -e '" + textbox_log24.Text.Trim() + "'";
            }
            if (!string.IsNullOrEmpty(textbox_log25.Text.Trim()))
            {
                keyword += " -e '" + textbox_log25.Text.Trim() + "'";
            }
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("at least 1 keyword needed");
                return;
            }

            await Task.Run(() => executecommand("adb shell \"logcat|grep -i " + keyword + "\"", false));
        }

        private void btnkeyclear1_Click(object sender, EventArgs e)
        {
            textbox_log11.Text = "";
            textbox_log12.Text = "";
            textbox_log13.Text = "";
            textbox_log14.Text = "";
            textbox_log15.Text = "";
        }

        private void btnclearkey2_Click(object sender, EventArgs e)
        {
            textbox_log21.Text = "";
            textbox_log22.Text = "";
            textbox_log23.Text = "";
            textbox_log24.Text = "";
            textbox_log25.Text = "";
        }

        private void btnfindapk_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select apk file";
            fileDialog.Filter = "apk file (*.apk)|*.apk|all files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textbox_apkname.Text = fileDialog.FileName;
            }
        }

        private void btn_browse_apk2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select apk file";
            fileDialog.Filter = "apk file (*.apk)|*.apk|all files (*.*)|*.*";
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                apk_to_install.Text = fileDialog.FileName;
            }
        }
    }
}