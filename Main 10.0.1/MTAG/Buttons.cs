using System.Windows.Forms;
using System.Drawing;



namespace MTAG
{
    internal class Buttons
    {
        public static Buttons buttons;
        public Buttons()
        {
            buttons = this;
        }



        public void InitializeSelectButton(Button[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                SetButtonBorder(b[i], Color.Red, 0);
            }
        }
        public void SetButtonBorder(Button b, Color c, int s)
        {
            b.FlatAppearance.BorderColor = c;
            b.FlatAppearance.BorderSize  = s;
        }
    }
}
