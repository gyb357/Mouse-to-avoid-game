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
    public partial class game_success : UserControl
    {
        public game_success()
        {
            InitializeComponent();
        }



        private void label_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;


            // back 을 눌렀을 경우
            if (label == label2) {
                MTAG.form1.level = 0;


                // select_level1.cs (레벨 선택 화면) 로 이동
                MTAG.form1.UserControlVisible(MTAG.form1.select_level1, this);
                MTAG.form1.buttonEnabled();
            }


            // retry 를 눌렀을 경우 stage_level1.cs (게임 화면) 로 이동
            if (label == label3) { MTAG.form1.UserControlVisible(MTAG.form1.stage_level1, this); MTAG.form1.cursorPosition(); }


            // next stage 를 눌렀을 경우
            if (label == label4)
            {
                if (MTAG.form1.stage <= 3)
                {
                    if (MTAG.form1.level > 5)
                    {
                        if (MTAG.form1.stage < 3)
                        {
                            MTAG.form1.stage++;
                            MTAG.form1.level = 1;
                            if(MTAG.form1.stage == 1)MTAG.form1.select_level1.label1.Text = "Stage 1";
                            else if (MTAG.form1.stage == 2)MTAG.form1.select_level1.label1.Text = "Stage 2";
                            else if (MTAG.form1.stage == 3)MTAG.form1.select_level1.label1.Text = "Stage 3";
                        }
                        else
                        {
                            MTAG.form1.UserControlVisible(MTAG.form1.main1, this);
                            MessageBox.Show("클리어"); // 수정 필요
                            MTAG.form1.stage = 0;
                            MTAG.form1.level = 0;
                            return;//if문 탈출
                        }
                    }
                    else
                    {
                        MTAG.form1.level++;
                    }


                    // stage_level1.cs (게임 화면) 로 이동
                    MTAG.form1.UserControlVisible(MTAG.form1.stage_level1, this);
                    MTAG.form1.cursorPosition();
                }
            }
            /*
             * 스테이지4 레벨1로 들어가지는 버그 있음
             * 
             * 조건문 고쳐야 함
             */
        }



        private void label_MouseMove(object sender, MouseEventArgs e)
        {
            MouseEvent.mouseEvent.SetCursorModel();
        }
    }
}
