using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace 컴퓨터_사용시간_지킴이_대회본
{
    public partial class 프로그램제거 : Form
    {
        public 프로그램제거()
        {
            InitializeComponent();
        }

        private void 프로그램제거_Load(object sender, EventArgs e)
        {

            Process proc = new Process();
            proc.StartInfo.FileName = "cmd.exe";
            proc.StartInfo.Arguments = "/c \"C:\\Program Files (x86)\\Young-in Samgye Software Club\\컴퓨터 사용시간 지킴이\\uninstaller.msi\"";
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            bool result = proc.Start();

            Application.ExitThread();
            Environment.Exit(0);


        }
    }
}
