using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x = 0;
        public int x5 = 650;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Stretches the image to fit the pictureBox.
            Bitmap MyImage;
            string fileToDisplay = @"C:\Users\student\source\repos\Cs_praktiks\praktika7\offTop\Risovat_na_Canvas\Resources\PRO_C#_7.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            MyImage = new Bitmap(fileToDisplay);

            // Create pen.
            Pen blackPen = new Pen(Color.Red, 30);
            // Create coordinates of points that define line.
            x+=40;
            int x1 = x-10;   //topleft to topright
            int y1 = x;
            int x2 = x+100;
            int y2 = x+100;
            x5 -= 40;
            int x3 = x5-10;   //topleft to topright
            int y3 = x5;
            int x4 = x5+100;
            int y4 = x5+100;

      // Draw line to screen.
      using (var graphics = Graphics.FromImage(MyImage))
            {
              
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
                graphics.DrawLine(blackPen, x3, y3, x4, y4);
              
            }


            pictureBox1.ClientSize = new Size(400, 400);
            pictureBox1.Image = (Image)MyImage;
        }
    }
}
