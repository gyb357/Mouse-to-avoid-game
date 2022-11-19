using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 다중지정폼
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.f.userControl31.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.f.userControl21.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.f.Close();
        }
    }
}
