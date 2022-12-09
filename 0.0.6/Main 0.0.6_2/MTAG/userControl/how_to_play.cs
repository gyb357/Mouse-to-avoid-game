using System;
using System.Drawing;
using System.Windows.Forms;



namespace MTAG
{
    public partial class how_to_play : UserControl
    {
        public how_to_play()
        {
            InitializeComponent();



            label1.BackColor      = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            label2.Text = "노란색 영역으로 마우스를 이동해보세요.";
        }



        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.main1, this);
        }
    }
}
