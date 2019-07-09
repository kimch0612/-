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
    public partial class _60m : Form
    {
        private Timer _timer;
        public _60m()
        {
            _timer = new Timer();
            _timer.Interval = 3600000; // interval in milliseconds here.
            _timer.Tick += (s, e) => { 사용제한 fr = new 사용제한(); fr.Show(); _timer.Stop(); this.Close(); };
            _timer.Start();
            InitializeComponent();
        }

        private void _60m_Load(object sender, EventArgs e)
        {

        }
    }
}
