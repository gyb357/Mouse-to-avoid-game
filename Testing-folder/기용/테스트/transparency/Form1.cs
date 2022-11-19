using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transparency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SetImage(string fileName)

        {

            try

            {

                Image img = Image.FromFile(fileName);

                this.pictureBox1.Image = ChangeOpacity(img, 0.5f);

                img.Dispose();

            }

            catch (Exception ex)

            {

                throw ex;

            }

        }
        public Bitmap ChangeOpacity(Image img, float opacityvalue)

        {

            Bitmap bmp = new Bitmap(img.Width, img.Height);

            Graphics graphics = Graphics.FromImage(bmp);

            ColorMatrix colormatrix = new ColorMatrix();

            colormatrix.Matrix33 = opacityvalue;

            ImageAttributes imgAttribute = new ImageAttributes();

            imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            graphics.DrawImage(img, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);

            graphics.Dispose();

            return bmp;

        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.FromArgb(70,0,0,0))
            {
                label1.BackColor = Color.FromArgb(255, 255, 255);
                label1.Parent = pictureBox1;
            }
            else
            {
                label2.BackColor = Color.Red;
                label1.BackColor = Color.FromArgb(70, 0, 0, 0);
            }        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
