using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UserControl0
{
    public partial class game_over : UserControl
    {
        public game_over()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            // retry 를 눌렀을 경우 stage_level1.cs (게임 화면) 로 이동
            if (label == label2) { Form1.form1.UserControlVisible(Form1.form1.stage_level1, this); }


            // back 을 눌렀을 경우
            if (label == label3) {
                Form1.form1.level = 0;


                // select_level1.cs (레벨 선택 화면) 로 이동
                Form1.form1.UserControlVisible(Form1.form1.select_level1, this);
            }
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}
