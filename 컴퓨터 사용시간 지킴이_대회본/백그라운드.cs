using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 컴퓨터_사용시간_지킴이_대회본
{


    public partial class 백그라운드 : Form
    {
        private Timer _timer;

        public 백그라운드()
        {
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 2000; // interval in milliseconds here.
            _timer.Tick += (s, e) => this.Close();
            _timer.Start();

            this.ControlBox = false;
            this.Text = string.Empty;

        }

        

        
            
            

        private void 백그라운드_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
