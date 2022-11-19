using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 테스트
{
    public partial class Form1 : Form
    {

        DateTime tempDateTime = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = timer1.ToString();
            MessageBox.Show(timer1.ToString());
        }
        

        int x = 0;
        int y = 0;
        int temp = 0;       

        private void timer1_Tick(object sender, EventArgs e)
        {
            String saveTempString = String.Empty;
            TimeSpan diff = DateTime.Now - tempDateTime; ;
            saveTempString = string.Format("{0:hh\\:mm\\:ss}",diff);
            label2.Text = saveTempString.ToString();
            if (x == 0 && y == 0)
            {
                temp = 0;
            }
            else if(x == 50 && y == 50)
            {
                temp = 1;
            }
            if (temp == 0)
            {
                x++;
                y++;
            }
            else if (temp == 1)
            {
                x--;
                y--;
            }

            label1.Location = new Point(x,y);
        }

        private void label1_Move(object sender, EventArgs e)
        {
        }
    }
}
