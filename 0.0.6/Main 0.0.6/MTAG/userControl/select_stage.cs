using System;
using System.Drawing;
using System.Windows.Forms;



namespace MTAG
{
    public partial class select_stage : UserControl
    {
        public select_stage()
        {
            InitializeComponent();


            
            Buttons buttons = new Buttons();
            Button[] button = new Button[]
            {
                button1, button2, button3
            };

            buttons.InitializeSelectButton(button);



            label1.BackColor      = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
        }



        private int buttonIdx  = 6;
        private int borderSize = 4;



        private void Button_Click(object sender, EventArgs e)
        {
            Button b     = sender as Button;
            int    stage = Convert.ToUInt16(b.Name[buttonIdx].ToString());
            Form1.form1.buttonEnabled();
            if      (stage == 1) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_1; Form1.form1.buttonEnabled(); }
            else if (stage == 2) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_2; Form1.form1.buttonEnabled(); }
            else if (stage == 3) { Form1.form1.select_level1.label1.Image = Properties.Resources.스테이지_3; Form1.form1.buttonEnabled(); }

            Form1.form1.stage = stage;
            Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.main1, this);
        }



        private void Button_Move(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;

            b.FlatAppearance.BorderSize = borderSize;
        }
        private void Button_Leave(object sender, EventArgs e)
        {
            Button b = sender as Button;

            b.FlatAppearance.BorderSize = 0;
        }
    }
}
