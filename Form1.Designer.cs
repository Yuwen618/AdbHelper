namespace AdbHelper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pushbtn = new Button();
            enablelogbtn = new Button();
            btn_backkey = new Button();
            btn_homekey = new Button();
            startlogbtn = new Button();
            textbox_apkname = new TextBox();
            textbox_apk_destination = new TextBox();
            label1 = new Label();
            textbox_log11 = new TextBox();
            checkBox1 = new CheckBox();
            btnstartlog2 = new Button();
            textbox_log21 = new TextBox();
            btn_adb_install = new Button();
            apk_to_install = new TextBox();
            killbutton1 = new Button();
            killpackagename1 = new TextBox();
            adbrebootbutton = new Button();
            label3 = new Label();
            btn_browse_apk2 = new Button();
            btnfindapk = new Button();
            hutime_label = new Label();
            textbox_log12 = new TextBox();
            textbox_log13 = new TextBox();
            textbox_log14 = new TextBox();
            textbox_log22 = new TextBox();
            textbox_log23 = new TextBox();
            textbox_log24 = new TextBox();
            lable_device = new Label();
            btnChangeHeight = new Button();
            btnkeyclear1 = new Button();
            btnclearkey2 = new Button();
            btn_crashlog = new Button();
            btn_scrcpy = new Button();
            label2 = new Label();
            btn_adbshell = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btn_logcat_c = new Button();
            btn_custombtn1 = new Button();
            btn_custombtn2 = new Button();
            text_customkey1 = new TextBox();
            text_customkey2 = new TextBox();
            btn_height2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // pushbtn
            // 
            pushbtn.Enabled = false;
            pushbtn.Location = new Point(12, 100);
            pushbtn.Name = "pushbtn";
            pushbtn.Size = new Size(75, 23);
            pushbtn.TabIndex = 12;
            pushbtn.Text = "Push";
            pushbtn.UseVisualStyleBackColor = true;
            pushbtn.Click += pushbtn_Click;
            // 
            // enablelogbtn
            // 
            enablelogbtn.Enabled = false;
            enablelogbtn.Location = new Point(164, 34);
            enablelogbtn.Name = "enablelogbtn";
            enablelogbtn.Size = new Size(75, 23);
            enablelogbtn.TabIndex = 2;
            enablelogbtn.Text = "adb root";
            enablelogbtn.UseVisualStyleBackColor = true;
            enablelogbtn.Click += enablelogbtn_Click;
            // 
            // btn_backkey
            // 
            btn_backkey.Enabled = false;
            btn_backkey.Location = new Point(12, 34);
            btn_backkey.Name = "btn_backkey";
            btn_backkey.Size = new Size(75, 23);
            btn_backkey.TabIndex = 0;
            btn_backkey.Text = "back key";
            btn_backkey.UseVisualStyleBackColor = true;
            btn_backkey.Click += button1_Click;
            // 
            // btn_homekey
            // 
            btn_homekey.Enabled = false;
            btn_homekey.Location = new Point(88, 34);
            btn_homekey.Name = "btn_homekey";
            btn_homekey.Size = new Size(75, 23);
            btn_homekey.TabIndex = 1;
            btn_homekey.Text = "home key";
            btn_homekey.UseVisualStyleBackColor = true;
            btn_homekey.Click += btn_homekey_Click;
            // 
            // startlogbtn
            // 
            startlogbtn.Enabled = false;
            startlogbtn.Location = new Point(12, 214);
            startlogbtn.Name = "startlogbtn";
            startlogbtn.Size = new Size(75, 23);
            startlogbtn.TabIndex = 21;
            startlogbtn.Text = "Start log";
            startlogbtn.UseVisualStyleBackColor = true;
            startlogbtn.Click += startlogbtn_Click;
            // 
            // textbox_apkname
            // 
            textbox_apkname.Location = new Point(106, 101);
            textbox_apkname.Name = "textbox_apkname";
            textbox_apkname.Size = new Size(161, 23);
            textbox_apkname.TabIndex = 13;
            textbox_apkname.TextChanged += textbox_apkname_TextChanged;
            // 
            // textbox_apk_destination
            // 
            textbox_apk_destination.Location = new Point(333, 101);
            textbox_apk_destination.Name = "textbox_apk_destination";
            textbox_apk_destination.Size = new Size(183, 23);
            textbox_apk_destination.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 106);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 2;
            label1.Text = "To";
            label1.Click += label1_Click;
            // 
            // textbox_log11
            // 
            textbox_log11.Location = new Point(106, 214);
            textbox_log11.Name = "textbox_log11";
            textbox_log11.Size = new Size(77, 23);
            textbox_log11.TabIndex = 22;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(393, 7);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(85, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Stay Ontop";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnstartlog2
            // 
            btnstartlog2.Enabled = false;
            btnstartlog2.Location = new Point(12, 254);
            btnstartlog2.Name = "btnstartlog2";
            btnstartlog2.Size = new Size(75, 23);
            btnstartlog2.TabIndex = 27;
            btnstartlog2.Text = "Start log";
            btnstartlog2.UseVisualStyleBackColor = true;
            btnstartlog2.Click += btnstartlog2_Click;
            // 
            // textbox_log21
            // 
            textbox_log21.Location = new Point(106, 254);
            textbox_log21.Name = "textbox_log21";
            textbox_log21.Size = new Size(77, 23);
            textbox_log21.TabIndex = 28;
            // 
            // btn_adb_install
            // 
            btn_adb_install.Enabled = false;
            btn_adb_install.Location = new Point(12, 135);
            btn_adb_install.Name = "btn_adb_install";
            btn_adb_install.Size = new Size(75, 23);
            btn_adb_install.TabIndex = 16;
            btn_adb_install.Text = "adb install";
            btn_adb_install.UseVisualStyleBackColor = true;
            btn_adb_install.Click += btn_adb_install_Click;
            // 
            // apk_to_install
            // 
            apk_to_install.Location = new Point(106, 136);
            apk_to_install.Name = "apk_to_install";
            apk_to_install.Size = new Size(291, 23);
            apk_to_install.TabIndex = 17;
            // 
            // killbutton1
            // 
            killbutton1.Enabled = false;
            killbutton1.Location = new Point(12, 174);
            killbutton1.Name = "killbutton1";
            killbutton1.Size = new Size(75, 23);
            killbutton1.TabIndex = 19;
            killbutton1.Text = "Kill";
            killbutton1.UseVisualStyleBackColor = true;
            killbutton1.Click += killbutton1_Click;
            // 
            // killpackagename1
            // 
            killpackagename1.Location = new Point(106, 175);
            killpackagename1.Name = "killpackagename1";
            killpackagename1.Size = new Size(203, 23);
            killpackagename1.TabIndex = 20;
            // 
            // adbrebootbutton
            // 
            adbrebootbutton.Enabled = false;
            adbrebootbutton.Location = new Point(12, 65);
            adbrebootbutton.Name = "adbrebootbutton";
            adbrebootbutton.Size = new Size(75, 23);
            adbrebootbutton.TabIndex = 7;
            adbrebootbutton.Text = "adb reboot";
            adbrebootbutton.UseVisualStyleBackColor = true;
            adbrebootbutton.Click += adbrebootbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 9);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "HU time : ";
            // 
            // btn_browse_apk2
            // 
            btn_browse_apk2.Location = new Point(403, 136);
            btn_browse_apk2.Name = "btn_browse_apk2";
            btn_browse_apk2.Size = new Size(29, 24);
            btn_browse_apk2.TabIndex = 18;
            btn_browse_apk2.Text = "...";
            btn_browse_apk2.UseVisualStyleBackColor = true;
            btn_browse_apk2.Click += btn_browse_apk2_Click;
            // 
            // btnfindapk
            // 
            btnfindapk.Location = new Point(273, 101);
            btnfindapk.Name = "btnfindapk";
            btnfindapk.Size = new Size(29, 24);
            btnfindapk.TabIndex = 14;
            btnfindapk.Text = "...";
            btnfindapk.UseVisualStyleBackColor = true;
            btnfindapk.Click += btnfindapk_Click;
            // 
            // hutime_label
            // 
            hutime_label.AutoSize = true;
            hutime_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hutime_label.Location = new Point(256, 9);
            hutime_label.Name = "hutime_label";
            hutime_label.Size = new Size(0, 15);
            hutime_label.TabIndex = 2;
            // 
            // textbox_log12
            // 
            textbox_log12.Location = new Point(190, 215);
            textbox_log12.Name = "textbox_log12";
            textbox_log12.Size = new Size(77, 23);
            textbox_log12.TabIndex = 23;
            // 
            // textbox_log13
            // 
            textbox_log13.Location = new Point(273, 215);
            textbox_log13.Name = "textbox_log13";
            textbox_log13.Size = new Size(77, 23);
            textbox_log13.TabIndex = 24;
            // 
            // textbox_log14
            // 
            textbox_log14.Location = new Point(356, 214);
            textbox_log14.Name = "textbox_log14";
            textbox_log14.Size = new Size(77, 23);
            textbox_log14.TabIndex = 25;
            // 
            // textbox_log22
            // 
            textbox_log22.Location = new Point(190, 254);
            textbox_log22.Name = "textbox_log22";
            textbox_log22.Size = new Size(77, 23);
            textbox_log22.TabIndex = 29;
            // 
            // textbox_log23
            // 
            textbox_log23.Location = new Point(273, 255);
            textbox_log23.Name = "textbox_log23";
            textbox_log23.Size = new Size(77, 23);
            textbox_log23.TabIndex = 30;
            // 
            // textbox_log24
            // 
            textbox_log24.Location = new Point(356, 255);
            textbox_log24.Name = "textbox_log24";
            textbox_log24.Size = new Size(77, 23);
            textbox_log24.TabIndex = 31;
            // 
            // lable_device
            // 
            lable_device.AutoSize = true;
            lable_device.Location = new Point(12, 9);
            lable_device.Name = "lable_device";
            lable_device.Size = new Size(83, 15);
            lable_device.TabIndex = 2;
            lable_device.Text = "No adb device";
            // 
            // btnChangeHeight
            // 
            btnChangeHeight.Location = new Point(498, 4);
            btnChangeHeight.Name = "btnChangeHeight";
            btnChangeHeight.Size = new Size(29, 24);
            btnChangeHeight.TabIndex = 0;
            btnChangeHeight.Text = "v";
            btnChangeHeight.UseVisualStyleBackColor = true;
            btnChangeHeight.Click += btnChangeHeight_Click;
            // 
            // btnkeyclear1
            // 
            btnkeyclear1.Location = new Point(439, 212);
            btnkeyclear1.Name = "btnkeyclear1";
            btnkeyclear1.Size = new Size(25, 24);
            btnkeyclear1.TabIndex = 26;
            btnkeyclear1.Text = "x";
            btnkeyclear1.UseVisualStyleBackColor = true;
            btnkeyclear1.Click += btnkeyclear1_Click;
            // 
            // btnclearkey2
            // 
            btnclearkey2.Location = new Point(439, 255);
            btnclearkey2.Name = "btnclearkey2";
            btnclearkey2.Size = new Size(25, 24);
            btnclearkey2.TabIndex = 32;
            btnclearkey2.Text = "x";
            btnclearkey2.UseVisualStyleBackColor = true;
            btnclearkey2.Click += btnclearkey2_Click;
            // 
            // btn_crashlog
            // 
            btn_crashlog.Enabled = false;
            btn_crashlog.Location = new Point(317, 34);
            btn_crashlog.Name = "btn_crashlog";
            btn_crashlog.Size = new Size(75, 23);
            btn_crashlog.TabIndex = 4;
            btn_crashlog.Text = "show crash";
            btn_crashlog.UseVisualStyleBackColor = true;
            btn_crashlog.Click += btn_crashlog_Click;
            // 
            // btn_scrcpy
            // 
            btn_scrcpy.Enabled = false;
            btn_scrcpy.Location = new Point(241, 34);
            btn_scrcpy.Name = "btn_scrcpy";
            btn_scrcpy.Size = new Size(75, 23);
            btn_scrcpy.TabIndex = 3;
            btn_scrcpy.Text = "scrcpy";
            btn_scrcpy.UseVisualStyleBackColor = true;
            btn_scrcpy.Click += btn_scrcpy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(508, 287);
            label2.Name = "label2";
            label2.Size = new Size(37, 12);
            label2.TabIndex = 2;
            label2.Text = "By Bely";
            // 
            // btn_adbshell
            // 
            btn_adbshell.Enabled = false;
            btn_adbshell.Location = new Point(393, 34);
            btn_adbshell.Name = "btn_adbshell";
            btn_adbshell.Size = new Size(75, 24);
            btn_adbshell.TabIndex = 5;
            btn_adbshell.Text = "adb shell";
            btn_adbshell.UseVisualStyleBackColor = true;
            btn_adbshell.Click += btn_adbshell_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 178);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 4;
            label4.Text = "(package name)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 218);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "(reg keywords)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 258);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 5;
            label6.Text = "(reg keywords)";
            // 
            // btn_logcat_c
            // 
            btn_logcat_c.Enabled = false;
            btn_logcat_c.Location = new Point(470, 34);
            btn_logcat_c.Name = "btn_logcat_c";
            btn_logcat_c.Size = new Size(75, 24);
            btn_logcat_c.TabIndex = 6;
            btn_logcat_c.Text = "logcat -c";
            btn_logcat_c.UseVisualStyleBackColor = true;
            btn_logcat_c.Click += btn_logcat_c_Click;
            // 
            // btn_custombtn1
            // 
            btn_custombtn1.Enabled = false;
            btn_custombtn1.Location = new Point(88, 65);
            btn_custombtn1.Name = "btn_custombtn1";
            btn_custombtn1.Size = new Size(75, 23);
            btn_custombtn1.TabIndex = 8;
            btn_custombtn1.Text = "send key1";
            btn_custombtn1.UseVisualStyleBackColor = true;
            btn_custombtn1.Click += btn_custombtn1_Click;
            // 
            // btn_custombtn2
            // 
            btn_custombtn2.Enabled = false;
            btn_custombtn2.Location = new Point(248, 65);
            btn_custombtn2.Name = "btn_custombtn2";
            btn_custombtn2.Size = new Size(75, 23);
            btn_custombtn2.TabIndex = 10;
            btn_custombtn2.Text = "send key2";
            btn_custombtn2.UseVisualStyleBackColor = true;
            btn_custombtn2.Click += btn_custombtn2_Click;
            // 
            // text_customkey1
            // 
            text_customkey1.Location = new Point(165, 66);
            text_customkey1.Name = "text_customkey1";
            text_customkey1.Size = new Size(26, 23);
            text_customkey1.TabIndex = 9;
            // 
            // text_customkey2
            // 
            text_customkey2.Location = new Point(324, 65);
            text_customkey2.Name = "text_customkey2";
            text_customkey2.Size = new Size(26, 23);
            text_customkey2.TabIndex = 11;
            // 
            // btn_height2
            // 
            btn_height2.Location = new Point(498, 64);
            btn_height2.Name = "btn_height2";
            btn_height2.Size = new Size(29, 24);
            btn_height2.TabIndex = 10;
            btn_height2.Text = "v";
            btn_height2.UseVisualStyleBackColor = true;
            btn_height2.Click += btn_height2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(194, 69);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 11;
            label7.Text = "(code)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 68);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 12;
            label8.Text = "(code)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(435, 141);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 13;
            label9.Text = "(select apk)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 301);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btn_height2);
            Controls.Add(text_customkey2);
            Controls.Add(text_customkey1);
            Controls.Add(btn_custombtn2);
            Controls.Add(btn_custombtn1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(checkBox1);
            Controls.Add(hutime_label);
            Controls.Add(lable_device);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textbox_log24);
            Controls.Add(textbox_log23);
            Controls.Add(textbox_log22);
            Controls.Add(textbox_log21);
            Controls.Add(textbox_log14);
            Controls.Add(textbox_log13);
            Controls.Add(textbox_log12);
            Controls.Add(textbox_log11);
            Controls.Add(textbox_apk_destination);
            Controls.Add(btn_scrcpy);
            Controls.Add(btn_crashlog);
            Controls.Add(btnstartlog2);
            Controls.Add(killpackagename1);
            Controls.Add(apk_to_install);
            Controls.Add(textbox_apkname);
            Controls.Add(startlogbtn);
            Controls.Add(adbrebootbutton);
            Controls.Add(btn_homekey);
            Controls.Add(btn_backkey);
            Controls.Add(enablelogbtn);
            Controls.Add(btnfindapk);
            Controls.Add(btnclearkey2);
            Controls.Add(btnkeyclear1);
            Controls.Add(btnChangeHeight);
            Controls.Add(btn_logcat_c);
            Controls.Add(btn_adbshell);
            Controls.Add(btn_browse_apk2);
            Controls.Add(killbutton1);
            Controls.Add(btn_adb_install);
            Controls.Add(pushbtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "AdbHelper";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button pushbtn;
        private Button enablelogbtn;
        private Button btn_backkey;
        private Button btn_homekey;
        private Button startlogbtn;
        private TextBox textbox_apkname;
        private TextBox textbox_apk_destination;
        private Label label1;
        private TextBox textbox_log11;
        private CheckBox checkBox1;
        private Button btnstartlog2;
        private TextBox textbox_log21;
        private Button btn_adb_install;
        private TextBox apk_to_install;
        private Button killbutton1;
        private TextBox killpackagename1;
        private Button adbrebootbutton;
        private Label label3;
        private Button btn_browse_apk2;
        private Button btnfindapk;
        private Label hutime_label;
        private TextBox textbox_log12;
        private TextBox textbox_log13;
        private TextBox textbox_log14;
        private TextBox textbox_log22;
        private TextBox textbox_log23;
        private TextBox textbox_log24;
        private Label lable_device;
        private Button btnChangeHeight;
        private Button btnkeyclear1;
        private Button btnclearkey2;
        private Button btn_crashlog;
        private Button btn_scrcpy;
        private Label label2;
        private Button btn_adbshell;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_logcat_c;
        private Button btn_custombtn1;
        private Button btn_custombtn2;
        private TextBox text_customkey1;
        private TextBox text_customkey2;
        private Button btn_height2;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}