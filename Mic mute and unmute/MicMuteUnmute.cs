using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace Mic_mute_and_unmute
{
    public partial class MicMuteUnmute : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        const int MYACTION_HOTKEY_ID0 = 0;
        const int MYACTION_HOTKEY_ID1 = 1;

        

        public MicMuteUnmute()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();
            label1.Visible = false;
            label2.Visible = false;
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID0, 0, (int)Keys.NumPad0);
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID1, 0, (int)Keys.NumPad1);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID1)
            {
                btn_mute_Click(null,EventArgs.Empty);
            }

            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID0)
            {
                btn_Unmute_Click(null, EventArgs.Empty);
            }
            base.WndProc(ref m);
        }

        private void btn_mute_Click(object sender, EventArgs e)
        {
            WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();
            micMute.MuteMic();

            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "Muted";
        }

        private void btn_Unmute_Click(object sender, EventArgs e)
        {
            WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();
            micMute.UnMuteMic();

            label1.Visible = true;
            label2.Visible = true;
            label2.Text = "UnMuted";
        }

        private void btn_abt_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
