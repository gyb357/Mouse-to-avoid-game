using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            button2.Visible = false;
        }

        private void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X, Cursor.Position.Y);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            MoveCursor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.FromArgb(0,0,0);
            label1.Width = ClientSize.Width;
            label1.Height = ClientSize.Height;
            button1.Visible = false;
            button2.BringToFront();
            button2.Visible = true;
            label1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible =false;
            button2.Visible = false;
            button1.Visible = true;
            label2.Visible = true;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
            label1.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
        }
    }
}