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
            textbox_log15 = new TextBox();
            textbox_log22 = new TextBox();
            textbox_log23 = new TextBox();
            textbox_log24 = new TextBox();
            textbox_log25 = new TextBox();
            lable_device = new Label();
            btnChangeHeight = new Button();
            btnkeyclear1 = new Button();
            btnclearkey2 = new Button();
            SuspendLayout();
            // 
            // pushbtn
            // 
            pushbtn.Enabled = false;
            pushbtn.Location = new Point(12, 82);
            pushbtn.Name = "pushbtn";
            pushbtn.Size = new Size(75, 23);
            pushbtn.TabIndex = 0;
            pushbtn.Text = "Push";
            pushbtn.UseVisualStyleBackColor = true;
            pushbtn.Click += pushbtn_Click;
            // 
            // enablelogbtn
            // 
            enablelogbtn.Enabled = false;
            enablelogbtn.Location = new Point(199, 38);
            enablelogbtn.Name = "enablelogbtn";
            enablelogbtn.Size = new Size(75, 23);
            enablelogbtn.TabIndex = 0;
            enablelogbtn.Text = "Enable log";
            enablelogbtn.UseVisualStyleBackColor = true;
            enablelogbtn.Click += enablelogbtn_Click;
            // 
            // btn_backkey
            // 
            btn_backkey.Enabled = false;
            btn_backkey.Location = new Point(12, 38);
            btn_backkey.Name = "btn_backkey";
            btn_backkey.Size = new Size(75, 23);
            btn_backkey.TabIndex = 0;
            btn_backkey.Text = "Back Key";
            btn_backkey.UseVisualStyleBackColor = true;
            btn_backkey.Click += button1_Click;
            // 
            // btn_homekey
            // 
            btn_homekey.Enabled = false;
            btn_homekey.Location = new Point(108, 38);
            btn_homekey.Name = "btn_homekey";
            btn_homekey.Size = new Size(75, 23);
            btn_homekey.TabIndex = 0;
            btn_homekey.Text = "Home Key";
            btn_homekey.UseVisualStyleBackColor = true;
            btn_homekey.Click += btn_homekey_Click;
            // 
            // startlogbtn
            // 
            startlogbtn.Enabled = false;
            startlogbtn.Location = new Point(12, 196);
            startlogbtn.Name = "startlogbtn";
            startlogbtn.Size = new Size(75, 23);
            startlogbtn.TabIndex = 0;
            startlogbtn.Text = "Start log";
            startlogbtn.UseVisualStyleBackColor = true;
            startlogbtn.Click += startlogbtn_Click;
            // 
            // textbox_apkname
            // 
            textbox_apkname.Location = new Point(106, 83);
            textbox_apkname.Name = "textbox_apkname";
            textbox_apkname.Size = new Size(161, 23);
            textbox_apkname.TabIndex = 1;
            textbox_apkname.TextChanged += textbox_apkname_TextChanged;
            // 
            // textbox_apk_destination
            // 
            textbox_apk_destination.Location = new Point(333, 83);
            textbox_apk_destination.Name = "textbox_apk_destination";
            textbox_apk_destination.Size = new Size(183, 23);
            textbox_apk_destination.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(308, 88);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 2;
            label1.Text = "To";
            // 
            // textbox_log11
            // 
            textbox_log11.Location = new Point(106, 196);
            textbox_log11.Name = "textbox_log11";
            textbox_log11.Size = new Size(77, 23);
            textbox_log11.TabIndex = 1;
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
            btnstartlog2.Location = new Point(12, 236);
            btnstartlog2.Name = "btnstartlog2";
            btnstartlog2.Size = new Size(75, 23);
            btnstartlog2.TabIndex = 0;
            btnstartlog2.Text = "Start log";
            btnstartlog2.UseVisualStyleBackColor = true;
            btnstartlog2.Click += btnstartlog2_Click;
            // 
            // textbox_log21
            // 
            textbox_log21.Location = new Point(106, 236);
            textbox_log21.Name = "textbox_log21";
            textbox_log21.Size = new Size(77, 23);
            textbox_log21.TabIndex = 1;
            // 
            // btn_adb_install
            // 
            btn_adb_install.Enabled = false;
            btn_adb_install.Location = new Point(12, 117);
            btn_adb_install.Name = "btn_adb_install";
            btn_adb_install.Size = new Size(75, 23);
            btn_adb_install.TabIndex = 0;
            btn_adb_install.Text = "adb install";
            btn_adb_install.UseVisualStyleBackColor = true;
            btn_adb_install.Click += btn_adb_install_Click;
            // 
            // apk_to_install
            // 
            apk_to_install.Location = new Point(106, 118);
            apk_to_install.Name = "apk_to_install";
            apk_to_install.Size = new Size(350, 23);
            apk_to_install.TabIndex = 1;
            // 
            // killbutton1
            // 
            killbutton1.Enabled = false;
            killbutton1.Location = new Point(12, 156);
            killbutton1.Name = "killbutton1";
            killbutton1.Size = new Size(75, 23);
            killbutton1.TabIndex = 0;
            killbutton1.Text = "Kill";
            killbutton1.UseVisualStyleBackColor = true;
            killbutton1.Click += killbutton1_Click;
            // 
            // killpackagename1
            // 
            killpackagename1.Location = new Point(106, 157);
            killpackagename1.Name = "killpackagename1";
            killpackagename1.Size = new Size(203, 23);
            killpackagename1.TabIndex = 1;
            // 
            // adbrebootbutton
            // 
            adbrebootbutton.Enabled = false;
            adbrebootbutton.Location = new Point(287, 38);
            adbrebootbutton.Name = "adbrebootbutton";
            adbrebootbutton.Size = new Size(75, 23);
            adbrebootbutton.TabIndex = 0;
            adbrebootbutton.Text = "Adb reboot";
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
            btn_browse_apk2.Location = new Point(462, 117);
            btn_browse_apk2.Name = "btn_browse_apk2";
            btn_browse_apk2.Size = new Size(29, 24);
            btn_browse_apk2.TabIndex = 0;
            btn_browse_apk2.Text = "...";
            btn_browse_apk2.UseVisualStyleBackColor = true;
            btn_browse_apk2.Click += btn_browse_apk2_Click;
            // 
            // btnfindapk
            // 
            btnfindapk.Location = new Point(273, 83);
            btnfindapk.Name = "btnfindapk";
            btnfindapk.Size = new Size(29, 24);
            btnfindapk.TabIndex = 0;
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
            textbox_log12.Location = new Point(190, 197);
            textbox_log12.Name = "textbox_log12";
            textbox_log12.Size = new Size(77, 23);
            textbox_log12.TabIndex = 1;
            // 
            // textbox_log13
            // 
            textbox_log13.Location = new Point(273, 197);
            textbox_log13.Name = "textbox_log13";
            textbox_log13.Size = new Size(77, 23);
            textbox_log13.TabIndex = 1;
            // 
            // textbox_log14
            // 
            textbox_log14.Location = new Point(356, 196);
            textbox_log14.Name = "textbox_log14";
            textbox_log14.Size = new Size(77, 23);
            textbox_log14.TabIndex = 1;
            // 
            // textbox_log15
            // 
            textbox_log15.Location = new Point(439, 196);
            textbox_log15.Name = "textbox_log15";
            textbox_log15.Size = new Size(77, 23);
            textbox_log15.TabIndex = 1;
            // 
            // textbox_log22
            // 
            textbox_log22.Location = new Point(190, 236);
            textbox_log22.Name = "textbox_log22";
            textbox_log22.Size = new Size(77, 23);
            textbox_log22.TabIndex = 1;
            // 
            // textbox_log23
            // 
            textbox_log23.Location = new Point(273, 237);
            textbox_log23.Name = "textbox_log23";
            textbox_log23.Size = new Size(77, 23);
            textbox_log23.TabIndex = 1;
            // 
            // textbox_log24
            // 
            textbox_log24.Location = new Point(356, 237);
            textbox_log24.Name = "textbox_log24";
            textbox_log24.Size = new Size(77, 23);
            textbox_log24.TabIndex = 1;
            // 
            // textbox_log25
            // 
            textbox_log25.Location = new Point(439, 237);
            textbox_log25.Name = "textbox_log25";
            textbox_log25.Size = new Size(77, 23);
            textbox_log25.TabIndex = 1;
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
            btnkeyclear1.Location = new Point(522, 195);
            btnkeyclear1.Name = "btnkeyclear1";
            btnkeyclear1.Size = new Size(25, 24);
            btnkeyclear1.TabIndex = 0;
            btnkeyclear1.Text = "x";
            btnkeyclear1.UseVisualStyleBackColor = true;
            btnkeyclear1.Click += btnkeyclear1_Click;
            // 
            // btnclearkey2
            // 
            btnclearkey2.Location = new Point(522, 237);
            btnclearkey2.Name = "btnclearkey2";
            btnclearkey2.Size = new Size(25, 24);
            btnclearkey2.TabIndex = 0;
            btnclearkey2.Text = "x";
            btnclearkey2.UseVisualStyleBackColor = true;
            btnclearkey2.Click += btnclearkey2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 271);
            Controls.Add(checkBox1);
            Controls.Add(hutime_label);
            Controls.Add(lable_device);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textbox_log25);
            Controls.Add(textbox_log24);
            Controls.Add(textbox_log23);
            Controls.Add(textbox_log22);
            Controls.Add(textbox_log21);
            Controls.Add(textbox_log15);
            Controls.Add(textbox_log14);
            Controls.Add(textbox_log13);
            Controls.Add(textbox_log12);
            Controls.Add(textbox_log11);
            Controls.Add(textbox_apk_destination);
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
            Controls.Add(btn_browse_apk2);
            Controls.Add(killbutton1);
            Controls.Add(btn_adb_install);
            Controls.Add(pushbtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "AdbHelper - by bely  1.0";
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
        private TextBox textbox_log15;
        private TextBox textbox_log22;
        private TextBox textbox_log23;
        private TextBox textbox_log24;
        private TextBox textbox_log25;
        private Label lable_device;
        private Button btnChangeHeight;
        private Button btnkeyclear1;
        private Button btnclearkey2;
    }
}