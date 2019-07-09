using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 컴퓨터_사용시간_지킴이_대회본
{
    public partial class write : Form
    {
       
        private Timer _timer;


        public write()
        {
            InitializeComponent();

            TextWriter txt = new StreamWriter("C:\\Program Files (x86)\\Young-in Samgye Software Club\\컴퓨터 사용시간 지킴이\\tcode.txt");
            txt.Write("");
            txt.Close();


            _timer = new Timer();
            _timer.Interval = 0500; // interval in milliseconds here.
            _timer.Tick += (s, e) => this.Close();
            _timer.Start();
        }
    

        private void write_Load(object sender, EventArgs e)
        {

        }
    }
}
