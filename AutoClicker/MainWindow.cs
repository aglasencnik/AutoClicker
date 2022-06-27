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
            cbx_mouse_button.SelectedItem = 0;
            cbx_click_type.SelectedItem = 0;
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
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            isActive = true;
        }

        private void stopBot()
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            isActive = false;
            //botThread.Abort();
        }

        private void autoclicker(int _interval, string _mouseButton, string _clickType, int _clickNTimes, Point _location)
        {
            if (_location.X != -1)
            {
                SetCursorPos(_location.X, _location.Y);
            }

            if (_clickNTimes == -1)
            {
                while (true)
                {
                    if (_mouseButton == "Left")
                    {

                    }
                    else
                    {

                    }

                }
            }
            else
            {
                for (int i = 0; i < _clickNTimes; i++)
                {

                }
            }
        }
    }
}
