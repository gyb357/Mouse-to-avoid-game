using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Font0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            // 객체 생성
            PrivateFontCollection privateFonts = new PrivateFontCollection();


            // font 객체에 폰트 추가
            privateFonts.AddFontFile("BMJUA_ttf.ttf");


            Font font = new Font(privateFonts.Families[0], 24f);


            // 라벨에 폰트 적용
            label1.Font = font;
            label2.Font = font;
            label3.Text = privateFonts.Families[0].ToString();
        }
        /*
        * 1. 참조에 폰트파일을 드래그 해서 추가
        * 2. 추가한 해당 폰트를 누르고 "출력 디렉터리에 복사"를 "새 버전이면 복사"로 지정
        * 3. 위 코드 작성 후 폰트 적용
        */
    }
}
