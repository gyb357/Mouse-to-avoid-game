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
    public partial class game_pause : UserControl
    {
        public game_pause()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            // back 을 눌렀을 경우 stage_level1.cs (게임 화면) 로 이동
            if (label == label2)
            {
                // Ecs (pause) 누르기 전 마우스 위치로 이동
                MouseEvent.mouseEvent.SetMousePosition(MTAG.form1.mousePoint);


                // stage_level1.cs (게임 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.stage_level1, this);
            }


            // select level 을 눌렀을 경우
            if (label == label3) {
                MTAG.form1.level = 0;


                // select_level1.cs (레벨 선택 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.select_level1, this);
            }
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}
