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
using System.IO;

namespace 컴퓨터_사용시간_지킴이_대회본
{
    public partial class _3h : Form
    {
        private const int SC_CLOSE = 0xF060;
        private const int MF_ENABLED = 0x0;
        private const int MF_GRAYED = 0x1;
        private const int MF_DISABLED = 0x2;

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);

        private Timer _timer;
        public _3h()
        {
            _timer = new Timer();
            _timer.Interval = 10800000; // interval in milliseconds here.
            _timer.Tick += (s, e) => { 사용제한 fr = new 사용제한(); fr.Show(); _timer.Stop(); this.Close(); };
            _timer.Start();
            InitializeComponent();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }
        private void _3h_Load(object sender, EventArgs e)
        {
           
        }
    }
}
