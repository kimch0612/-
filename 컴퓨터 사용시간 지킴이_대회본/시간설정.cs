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
    public partial class 시간설정 : Form
    {
        private Timer _timer;

        public 시간설정()
        {
            InitializeComponent();
        }

        public class Timer : Component
        {


        }

        private void 시간설정_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            _30s fr = new _30s();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _2h fr = new _2h();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _3h fr = new _3h();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test fr = new test();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _60m fr = new _60m();
            fr.Show();
        }
    }
}
