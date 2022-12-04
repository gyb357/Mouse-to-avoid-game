using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MTAG
{
    public partial class stage_level : UserControl
    {
        public stage_level()
        {
            InitializeComponent();
        }

        public  int    temp      = 0;
        private string fp_folder = "\\image\\backGround\\stage_level\\"; // 배경 이미지 경로

        private void Key_Down(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Form1.form1.state = 0;
                    Form1.form1.mousePoint = Cursor.Position;
                    Form1.form1.UserControlVisible(Form1.form1.game_pause1, this);

                    temp = 1;
                    break;
            }
        }

        // 배경 이미지 호풀
        private void stage_level_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string fp_image = Form1.form1.stage + "-" + Form1.form1.level + ".jpg";

                Graphics     g = e.Graphics;
                Image        i = new Bitmap(Form1.form1.fp_Project + fp_folder + fp_image);
                TextureBrush b = new TextureBrush(i);

                i = new Bitmap(i);
                b = new TextureBrush(i);
                g.FillRectangle(b, ClientRectangle);
                b.Dispose();
                i.Dispose();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.game_over1, Form1.form1.stage_level1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.form1.UserControlVisible(Form1.form1.game_success1, Form1.form1.stage_level1);
        }
    }
}
