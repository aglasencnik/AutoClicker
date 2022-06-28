namespace AutoClicker
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_hotkey_setting = new System.Windows.Forms.Button();
            this.btn_record_playback = new System.Windows.Forms.Button();
            this.gpbx_click_interval = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_miliseconds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_seconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_minutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_hours = new System.Windows.Forms.TextBox();
            this.gpbx_click_options = new System.Windows.Forms.GroupBox();
            this.cbx_click_type = new System.Windows.Forms.ComboBox();
            this.cbx_mouse_button = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gpbx_click_repeat = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.num_times = new System.Windows.Forms.NumericUpDown();
            this.rbtn_repeat_until_stopped = new System.Windows.Forms.RadioButton();
            this.rbtn_repeat = new System.Windows.Forms.RadioButton();
            this.gpbx_cursor_position = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbx_y_location = new System.Windows.Forms.TextBox();
            this.tbx_x_location = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_pick_location = new System.Windows.Forms.Button();
            this.rbtn_pick_location = new System.Windows.Forms.RadioButton();
            this.rbtn_current_location = new System.Windows.Forms.RadioButton();
            this.gpbx_click_interval.SuspendLayout();
            this.gpbx_click_options.SuspendLayout();
            this.gpbx_click_repeat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_times)).BeginInit();
            this.gpbx_cursor_position.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(16, 232);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(192, 40);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start (F6)";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(224, 232);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(192, 40);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop (F6)";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_hotkey_setting
            // 
            this.btn_hotkey_setting.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hotkey_setting.Location = new System.Drawing.Point(16, 280);
            this.btn_hotkey_setting.Name = "btn_hotkey_setting";
            this.btn_hotkey_setting.Size = new System.Drawing.Size(192, 40);
            this.btn_hotkey_setting.TabIndex = 2;
            this.btn_hotkey_setting.Text = "Hotkey setting";
            this.btn_hotkey_setting.UseVisualStyleBackColor = true;
            this.btn_hotkey_setting.Click += new System.EventHandler(this.btn_hotkey_setting_Click);
            // 
            // btn_record_playback
            // 
            this.btn_record_playback.Enabled = false;
            this.btn_record_playback.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_record_playback.Location = new System.Drawing.Point(224, 280);
            this.btn_record_playback.Name = "btn_record_playback";
            this.btn_record_playback.Size = new System.Drawing.Size(192, 40);
            this.btn_record_playback.TabIndex = 3;
            this.btn_record_playback.Text = "Record and Playback";
            this.btn_record_playback.UseVisualStyleBackColor = true;
            this.btn_record_playback.Click += new System.EventHandler(this.btn_record_playback_Click);
            // 
            // gpbx_click_interval
            // 
            this.gpbx_click_interval.Controls.Add(this.label4);
            this.gpbx_click_interval.Controls.Add(this.tbx_miliseconds);
            this.gpbx_click_interval.Controls.Add(this.label3);
            this.gpbx_click_interval.Controls.Add(this.tbx_seconds);
            this.gpbx_click_interval.Controls.Add(this.label2);
            this.gpbx_click_interval.Controls.Add(this.tbx_minutes);
            this.gpbx_click_interval.Controls.Add(this.label1);
            this.gpbx_click_interval.Controls.Add(this.tbx_hours);
            this.gpbx_click_interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_click_interval.Location = new System.Drawing.Point(8, 8);
            this.gpbx_click_interval.Name = "gpbx_click_interval";
            this.gpbx_click_interval.Size = new System.Drawing.Size(416, 56);
            this.gpbx_click_interval.TabIndex = 4;
            this.gpbx_click_interval.TabStop = false;
            this.gpbx_click_interval.Text = "Click interval";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(328, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "miliseconds";
            // 
            // tbx_miliseconds
            // 
            this.tbx_miliseconds.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_miliseconds.Location = new System.Drawing.Point(280, 24);
            this.tbx_miliseconds.Name = "tbx_miliseconds";
            this.tbx_miliseconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_miliseconds.Size = new System.Drawing.Size(48, 21);
            this.tbx_miliseconds.TabIndex = 6;
            this.tbx_miliseconds.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "secs";
            // 
            // tbx_seconds
            // 
            this.tbx_seconds.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_seconds.Location = new System.Drawing.Point(192, 24);
            this.tbx_seconds.Name = "tbx_seconds";
            this.tbx_seconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_seconds.Size = new System.Drawing.Size(48, 21);
            this.tbx_seconds.TabIndex = 4;
            this.tbx_seconds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "mins";
            // 
            // tbx_minutes
            // 
            this.tbx_minutes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_minutes.Location = new System.Drawing.Point(104, 24);
            this.tbx_minutes.Name = "tbx_minutes";
            this.tbx_minutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_minutes.Size = new System.Drawing.Size(48, 21);
            this.tbx_minutes.TabIndex = 2;
            this.tbx_minutes.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "hours";
            // 
            // tbx_hours
            // 
            this.tbx_hours.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_hours.Location = new System.Drawing.Point(8, 24);
            this.tbx_hours.Name = "tbx_hours";
            this.tbx_hours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_hours.Size = new System.Drawing.Size(48, 21);
            this.tbx_hours.TabIndex = 0;
            this.tbx_hours.Text = "0";
            // 
            // gpbx_click_options
            // 
            this.gpbx_click_options.Controls.Add(this.cbx_click_type);
            this.gpbx_click_options.Controls.Add(this.cbx_mouse_button);
            this.gpbx_click_options.Controls.Add(this.label6);
            this.gpbx_click_options.Controls.Add(this.label5);
            this.gpbx_click_options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbx_click_options.Location = new System.Drawing.Point(8, 72);
            this.gpbx_click_options.Name = "gpbx_click_options";
            this.gpbx_click_options.Size = new System.Drawing.Size(192, 88);
            this.gpbx_click_options.TabIndex = 5;
            this.gpbx_click_options.TabStop = false;
            this.gpbx_click_options.Text = "Click options";
            // 
            // cbx_click_type
            // 
            this.cbx_click_type.FormattingEnabled = true;
            this.cbx_click_type.Items.AddRange(new object[] {
            "Single",
            "Double"});
            this.cbx_click_type.Location = new System.Drawing.Point(96, 56);
            this.cbx_click_type.Name = "cbx_click_type";
            this.cbx_click_type.Size = new System.Drawing.Size(89, 21);
            this.cbx_click_type.TabIndex = 9;
            // 
            // cbx_mouse_button
            // 
            this.cbx_mouse_button.FormattingEnabled = true;
            this.cbx_mouse_button.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.cbx_mouse_button.Location = new System.Drawing.Point(96, 24);
            this.cbx_mouse_button.Name = "cbx_mouse_button";
            this.cbx_mouse_button.Size = new System.Drawing.Size(89, 21);
            this.cbx_mouse_button.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Click type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mouse button:";
            // 
            // gpbx_click_repeat
            // 
            this.gpbx_click_repeat.Controls.Add(this.label7);
            this.gpbx_click_repeat.Controls.Add(this.num_times);
            this.gpbx_click_repeat.Controls.Add(this.rbtn_repeat_until_stopped);
            this.gpbx_click_repeat.Controls.Add(this.rbtn_repeat);
            this.gpbx_click_repeat.Location = new System.Drawing.Point(208, 72);
            this.gpbx_click_repeat.Name = "gpbx_click_repeat";
            this.gpbx_click_repeat.Size = new System.Drawing.Size(216, 88);
            this.gpbx_click_repeat.TabIndex = 6;
            this.gpbx_click_repeat.TabStop = false;
            this.gpbx_click_repeat.Text = "Click repeat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "times";
            // 
            // num_times
            // 
            this.num_times.Location = new System.Drawing.Point(104, 24);
            this.num_times.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_times.Name = "num_times";
            this.num_times.Size = new System.Drawing.Size(56, 20);
            this.num_times.TabIndex = 9;
            this.num_times.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_times.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbtn_repeat_until_stopped
            // 
            this.rbtn_repeat_until_stopped.AutoSize = true;
            this.rbtn_repeat_until_stopped.Location = new System.Drawing.Point(8, 56);
            this.rbtn_repeat_until_stopped.Name = "rbtn_repeat_until_stopped";
            this.rbtn_repeat_until_stopped.Size = new System.Drawing.Size(123, 17);
            this.rbtn_repeat_until_stopped.TabIndex = 8;
            this.rbtn_repeat_until_stopped.Text = "Repeat until stopped";
            this.rbtn_repeat_until_stopped.UseVisualStyleBackColor = true;
            // 
            // rbtn_repeat
            // 
            this.rbtn_repeat.AutoSize = true;
            this.rbtn_repeat.Location = new System.Drawing.Point(8, 24);
            this.rbtn_repeat.Name = "rbtn_repeat";
            this.rbtn_repeat.Size = new System.Drawing.Size(60, 17);
            this.rbtn_repeat.TabIndex = 7;
            this.rbtn_repeat.Text = "Repeat";
            this.rbtn_repeat.UseVisualStyleBackColor = true;
            // 
            // gpbx_cursor_position
            // 
            this.gpbx_cursor_position.Controls.Add(this.label9);
            this.gpbx_cursor_position.Controls.Add(this.tbx_y_location);
            this.gpbx_cursor_position.Controls.Add(this.tbx_x_location);
            this.gpbx_cursor_position.Controls.Add(this.label8);
            this.gpbx_cursor_position.Controls.Add(this.btn_pick_location);
            this.gpbx_cursor_position.Controls.Add(this.rbtn_pick_location);
            this.gpbx_cursor_position.Controls.Add(this.rbtn_current_location);
            this.gpbx_cursor_position.Location = new System.Drawing.Point(8, 168);
            this.gpbx_cursor_position.Name = "gpbx_cursor_position";
            this.gpbx_cursor_position.Size = new System.Drawing.Size(416, 56);
            this.gpbx_cursor_position.TabIndex = 7;
            this.gpbx_cursor_position.TabStop = false;
            this.gpbx_cursor_position.Text = "Cursor position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Y";
            // 
            // tbx_y_location
            // 
            this.tbx_y_location.Location = new System.Drawing.Point(368, 24);
            this.tbx_y_location.Name = "tbx_y_location";
            this.tbx_y_location.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_y_location.Size = new System.Drawing.Size(40, 20);
            this.tbx_y_location.TabIndex = 12;
            this.tbx_y_location.Text = "0";
            // 
            // tbx_x_location
            // 
            this.tbx_x_location.Location = new System.Drawing.Point(296, 24);
            this.tbx_x_location.Name = "tbx_x_location";
            this.tbx_x_location.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbx_x_location.Size = new System.Drawing.Size(40, 20);
            this.tbx_x_location.TabIndex = 11;
            this.tbx_x_location.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "X";
            // 
            // btn_pick_location
            // 
            this.btn_pick_location.Location = new System.Drawing.Point(176, 16);
            this.btn_pick_location.Name = "btn_pick_location";
            this.btn_pick_location.Size = new System.Drawing.Size(96, 32);
            this.btn_pick_location.TabIndex = 8;
            this.btn_pick_location.Text = "Pick location";
            this.btn_pick_location.UseVisualStyleBackColor = true;
            // 
            // rbtn_pick_location
            // 
            this.rbtn_pick_location.AutoSize = true;
            this.rbtn_pick_location.Location = new System.Drawing.Point(160, 24);
            this.rbtn_pick_location.Name = "rbtn_pick_location";
            this.rbtn_pick_location.Size = new System.Drawing.Size(14, 13);
            this.rbtn_pick_location.TabIndex = 9;
            this.rbtn_pick_location.UseVisualStyleBackColor = true;
            // 
            // rbtn_current_location
            // 
            this.rbtn_current_location.AutoSize = true;
            this.rbtn_current_location.Location = new System.Drawing.Point(8, 24);
            this.rbtn_current_location.Name = "rbtn_current_location";
            this.rbtn_current_location.Size = new System.Drawing.Size(99, 17);
            this.rbtn_current_location.TabIndex = 8;
            this.rbtn_current_location.Text = "Current location";
            this.rbtn_current_location.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 330);
            this.Controls.Add(this.gpbx_cursor_position);
            this.Controls.Add(this.gpbx_click_repeat);
            this.Controls.Add(this.gpbx_click_options);
            this.Controls.Add(this.gpbx_click_interval);
            this.Controls.Add(this.btn_record_playback);
            this.Controls.Add(this.btn_hotkey_setting);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OP Auto Clicker 3.0";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.gpbx_click_interval.ResumeLayout(false);
            this.gpbx_click_interval.PerformLayout();
            this.gpbx_click_options.ResumeLayout(false);
            this.gpbx_click_options.PerformLayout();
            this.gpbx_click_repeat.ResumeLayout(false);
            this.gpbx_click_repeat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_times)).EndInit();
            this.gpbx_cursor_position.ResumeLayout(false);
            this.gpbx_cursor_position.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_hotkey_setting;
        private System.Windows.Forms.Button btn_record_playback;
        private System.Windows.Forms.GroupBox gpbx_click_interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_miliseconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_seconds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_minutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_hours;
        private System.Windows.Forms.GroupBox gpbx_click_options;
        private System.Windows.Forms.ComboBox cbx_click_type;
        private System.Windows.Forms.ComboBox cbx_mouse_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpbx_click_repeat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown num_times;
        private System.Windows.Forms.RadioButton rbtn_repeat_until_stopped;
        private System.Windows.Forms.RadioButton rbtn_repeat;
        private System.Windows.Forms.GroupBox gpbx_cursor_position;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbx_y_location;
        private System.Windows.Forms.TextBox tbx_x_location;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_pick_location;
        private System.Windows.Forms.RadioButton rbtn_pick_location;
        private System.Windows.Forms.RadioButton rbtn_current_location;
    }
}

