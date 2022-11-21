using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 색_아웃
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (Control c in this.Controls) { 
                if (c.BackColor == Color.Red)
                {
                    label1.Text = "아웃";
                }
                else if (c.BackColor == Color.Blue)
                {
                    label1.Text = "파랑";
                }
                else if (c.BackColor == Color.Green)
                {
                    label1.Text = "초록";
                }
                else if (c.BackColor == Color.Purple)
                {
                    label1.Text = "보라색";
                }
                else if (c.BackColor == Color.Pink)
                {
                    label1.Text = "분홍";
                }
                else if (c.BackColor == Color.White)
                {
                    label1.Text = "Form Color";
                }
                else
                {
                    label1.Text = "등록되지 않은 색입니다.";
                }
            }
        }
    }
}
