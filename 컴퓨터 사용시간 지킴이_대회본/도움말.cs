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
    public partial class 도움말 : Form
    {
        public 도움말()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1학년) 김창환\n(2학년) 오성민,이예원,임나연 ", "개발진");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            사용방법 fr = new 사용방법();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            투명도 fr = new 투명도();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            프로그램제거 fr = new 프로그램제거();
            fr.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            저작권 fr = new 저작권();
            fr.Show();
        }
    }
}
