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
    public partial class 사용방법 : Form
    {
        public 사용방법()
        {
            InitializeComponent();
        }

        private void InitializeMyScrollBar()
        {
            // Create and initialize a VScrollBar.
            VScrollBar vScrollBar1 = new VScrollBar();

            // Dock the scroll bar to the right side of the form.
            vScrollBar1.Dock = DockStyle.Right;

            // Add the scroll bar to the form.
            Controls.Add(vScrollBar1);
        }

        private void 사용방법_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
