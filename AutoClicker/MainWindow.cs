using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class MainWindow : Form
    {
        bool isActive;
        Thread botThread;
        int interval;
        string mouseButton;
        string clickType;
        int repeatNTimes;
        Point location;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x0002,
            LEFTUP = 0x0004,
            RIGHTDOWN = 0x0008,
            RIGHTUP = 0x0010
        }

        public MainWindow()
        {
            InitializeComponent();
            
            isActive = false;
            interval = 100;
            mouseButton = "Left";
            clickType = "Single";
            repeatNTimes = -1;
            location = new Point(-1, -1);

            int UniqueHotkeyId = 1;
            int HotKeyCode = (int)Keys.F6;
            Boolean F6Registered = RegisterHotKey(
                this.Handle, UniqueHotkeyId, 0x0000, HotKeyCode
            );
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            tbx_miliseconds.Text = "100";
            cbx_mouse_button.SelectedItem = "Left";
            cbx_click_type.SelectedItem = "Single";
            rbtn_repeat_until_stopped.Checked = true;
            rbtn_current_location.Checked = true;
            btn_stop.Enabled = false;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();

                if (id == 1)
                {
                    start_stop();
                }
            }

            base.WndProc(ref m);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            start_stop();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            start_stop();
        }

        private void btn_hotkey_setting_Click(object sender, EventArgs e)
        {

        }

        private void btn_record_playback_Click(object sender, EventArgs e)
        {

        }

        private void start_stop()
        {
            if (isActive)
            {
                stopBot();
            }
            else
            {
                startBot();
            }
        }

        private void startBot()
        {
            if (checkRequirements())
            {
                this.WindowState = FormWindowState.Minimized;
                btn_start.Enabled = false;
                btn_stop.Enabled = true;
                isActive = true;
                botThread = new Thread(autoclicker);
                botThread.Start();
            }
            else
            {
                MessageBox.Show("Requirements not satisfied!", "Invalid Requirements!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void stopBot()
        {
            this.WindowState = FormWindowState.Normal;
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            isActive = false;
            botThread.Abort();
        }

        private void autoclicker()
        {
            if (location.X != -1)
            {
                SetCursorPos(location.X, location.Y);
            }

            if (repeatNTimes == -1)
            {
                if (mouseButton == "Left")
                {
                    if (clickType == "Single")
                    {
                        while (true)
                        {
                            leftClickSingle();
                            Thread.Sleep(interval);
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            leftClickDouble();
                            Thread.Sleep(interval);
                        }
                    }
                }
                else
                {
                    if (clickType == "Single")
                    {
                        while (true)
                        {
                            rightClickSingle();
                            Thread.Sleep(interval);
                        }
                    }
                    else
                    {
                        while (true)
                        {
                            rightClickSingle();
                            Thread.Sleep(interval);
                        }
                    }
                }
            }
            else
            {
                if (mouseButton == "Left")
                {
                    if (clickType == "Single")
                    {
                        for (int i = 0; i < repeatNTimes; i++)
                        {
                            leftClickSingle();
                            Thread.Sleep(interval);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < repeatNTimes; i++)
                        {
                            leftClickDouble();
                            Thread.Sleep(interval);
                        }
                    }
                }
                else
                {
                    if (clickType == "Single")
                    {
                        for (int i = 0; i < repeatNTimes; i++)
                        {
                            rightClickSingle();
                            Thread.Sleep(interval);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < repeatNTimes; i++)
                        {
                            rightClickDouble();
                            Thread.Sleep(interval);
                        }
                    }
                }
            }
        }

        private void leftClickSingle()
        {
            mouse_event((int)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        }

        private void leftClickDouble()
        {
            mouse_event((int)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        }

        private void rightClickSingle()
        {
            mouse_event((int)MouseEventFlags.RIGHTDOWN, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
        }

        private void rightClickDouble()
        {
            mouse_event((int)MouseEventFlags.RIGHTDOWN, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.RIGHTDOWN, 0, 0, 0, 0);
            mouse_event((int)MouseEventFlags.RIGHTUP, 0, 0, 0, 0);
        }

        private bool checkRequirements()
        {
            try
            {
                int hours = int.Parse(tbx_hours.Text);
                int mins = int.Parse(tbx_minutes.Text);
                int secs = int.Parse(tbx_seconds.Text);
                int miliseconds = int.Parse(tbx_miliseconds.Text);
                int _interval = ((hours * 3600) + (mins * 60) + secs) * 1000;
                interval = (_interval < 1) ? 1 : _interval;
                mouseButton = (cbx_mouse_button.SelectedItem == "Left") ? "Left" : "Right";
                clickType = (cbx_click_type.SelectedItem == "Single") ? "Single" : "Double";
                repeatNTimes = (rbtn_repeat.Checked && num_times.Value >= 1) ? (int)num_times.Value : -1;
                location = (rbtn_pick_location.Checked && int.Parse(tbx_x_location.Text) >= 0 && int.Parse(tbx_y_location.Text) >= 0) ? new Point(int.Parse(tbx_x_location.Text), int.Parse(tbx_y_location.Text)) : new Point(-1, -1);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
