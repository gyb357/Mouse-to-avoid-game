using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load(object sender, EventArgs e)
        {
            MessageBox.Show("This form is load");

            this.ActiveControl = button3;
        }

        private void closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("This form is closed");
        }

        private void closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You want to close?", "Prompt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 _Form2 = new Form2();
            _Form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            int x = R.Next(0, ClientSize.Width - button2.Width);
            int y = R.Next(0, ClientSize.Height - button2.Height);
            int r = R.Next(0, 255);
            int g = R.Next(0, 255);
            int b = R.Next(0, 255);
            button2.Location = new Point(x, y);
            button2.BackColor = Color.FromArgb(r, g, b);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "아이디를 입력 하시오") textBox1.Text = "";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "아이디를 입력 하시오";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("윈도우프로그래밍실습") && textBox2.Text.Equals("1234"))
            {
                Form3 _Form3 = new Form3();
                _Form3.Owner = this;
                _Form3.Show();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 잘못되었습니다");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                comboBox1.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("콤보박스로 보낼 아이템을 선택해 주세요");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex > -1)
            {
                listBox1.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("리스트박스로 보낼 아이템을 선택해 주새요");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                listBox1.Items.Add(textBox3.Text);
                textBox3.Text = "";
            }
            else
            {
                MessageBox.Show("추가할 아이템을 입력해 주세요");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("삭제할 부분을 선택해 주세요");
            }
        }
    }
}
