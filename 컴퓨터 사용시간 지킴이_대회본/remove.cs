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
    public partial class remove : Form
    {
       
        private Timer _timer;

        public remove()
        {

            FileStream writeStream;
            try
            {
                writeStream = new FileStream("C:\\Program Files (x86)\\Young-in Samgye Software Club\\컴퓨터 사용시간 지킴이\\tcode.txt", FileMode.Open);
                BinaryWriter writeBinay = new BinaryWriter(writeStream);
                writeBinay.Write("remove");
                writeBinay.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            InitializeComponent();
            _timer = new Timer();
            _timer.Interval = 0500; // interval in milliseconds here.
            _timer.Tick += (s, e) => this.Close();
            _timer.Start();
        }

        private void remove_Load(object sender, EventArgs e)
        {
         
        }
    }
}
