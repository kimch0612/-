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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;


namespace 컴퓨터_사용시간_지킴이_대회본
{
    public partial class Form1 : Form
    {
        private const int SC_CLOSE = 0xF060;
        private const int MF_ENABLED = 0x0;
        private const int MF_GRAYED = 0x1;
        private const int MF_DISABLED = 0x2;
       

        [DllImport("user32.dll")]
        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32.dll")]
        private static extern int EnableMenuItem(IntPtr hMenu, int wIDEnableItem, int wEnable);

        public Form1()
        {
        
            InitializeComponent();
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.notifyIcon1.Visible = true;
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            EnableMenuItem(GetSystemMenu(this.Handle, false), SC_CLOSE, MF_GRAYED);
           
        }
        bool myButtonWasClicked = false;

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                e.Handled = true;
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)

        {
            시간설정 fr = new 시간설정();
            fr.Show();
            
        }

    private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            날짜 fr = new 날짜();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            도움말 fr = new 도움말();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.Hide();
           백그라운드 fr = new 백그라운드();
           fr.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("컴퓨터 사용시간 지킴이", Application.ExecutablePath.ToString());
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void 종료ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void 켜기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            사용제한 fr = new 사용제한();
            fr.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}