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
            label2.BackColor = Color.Transparent;
            label2.Parent = pictureBox4;
            label1.BackColor      = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            
        }



        private void PictureBox_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.main1, this);
        }

        private void pictureBox2_Move(object sender, EventArgs e)
        {
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox p = sender as PictureBox;
            if (p == pictureBox3)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                label2.Text = "잘하셨습니다.\n" +
                    "노란색 영역에 마우스를 이동하시면 해당 레벨을 클리어하실 수 있습니다.\n" +
                    "이번에는 빨간색 영역으로 마우스를 이동해보세요.";
            }
            else if (p == pictureBox2)
            {
                pictureBox2.Visible = false;
                label2.Text = "잘하셨습니다. \n" +
                    "빨간색 영역은 장애물으로 마우스가 장애물에 닿을 경우 게임 오버됩니다.\n" +
                    "기본적인 게임 설명은 여기까지입니다.\n" +
                    "뒤로가기 버튼을 누르시고 게임을 시작하시면 됩니다.\n";
            }
        }
    }
}
