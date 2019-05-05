using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {   int c = 0;
        int angle;
        int a, b, d1;
        public Form1()
        {
                
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c = 0;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            d1 = Convert.ToInt32(textBox4.Text);
            a = a + d1 / 2;
            b = b + d1 / 2;
            pictureBox1.Refresh();
            

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
         
            //  pictureBox1.Image = null;
            Pen currentPen = new Pen(Color.Black);
            e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
            e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
            if (c == 0)
            {

                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b-20);
                e.Graphics.DrawLine(currentPen, a+20, b-20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20,a+120, b-40);
                e.Graphics.DrawLine(currentPen, a + 120, b - 40,a+160,b);
                e.Graphics.DrawLine(currentPen, a + 160, b, a+140,b+20);



                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);

            }
            if (c == 1)
            {
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);

                e.Graphics.DrawLine(currentPen, a, b, a - 20, b - 20);
                e.Graphics.DrawLine(currentPen, a - 20, b - 20, a - 100, b - 20);
                e.Graphics.DrawLine(currentPen, a - 100, b - 20, a - 120, b - 40);
                e.Graphics.DrawLine(currentPen, a - 120, b - 40, a - 160, b);
                e.Graphics.DrawLine(currentPen, a - 160, b, a - 140, b + 20);


                e.Graphics.DrawLine(currentPen, a, b, a - 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a - 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a - 20, b + 20);
                e.Graphics.DrawLine(currentPen, a - 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a - 100, b + 40);
                e.Graphics.DrawLine(currentPen, a - 100, b + 40, a - 100, b + 60);
                e.Graphics.DrawLine(currentPen, a - 100, b + 60, a - 140, b + 20);
                e.Graphics.DrawLine(currentPen, a - 140, b + 20, a - 100, b - 20);
                e.Graphics.DrawLine(currentPen, a - 100, b - 20, a - 100, b);

            }
            if (c == 2)
            {
                b += 80;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                e.Graphics.DrawLine(currentPen, a, b+40, a + 20, b+60);
                e.Graphics.DrawLine(currentPen, a + 20, b+60, a + 100, b+60);
                e.Graphics.DrawLine(currentPen, a + 100, b+60, a + 120, b + 80);
                e.Graphics.DrawLine(currentPen, a + 120, b + 80, a + 160, b+40);
                e.Graphics.DrawLine(currentPen, a + 160, b+40, a + 140, b + 20);


                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);
            }
            if (c == 3)
            {
                    angle += Convert.ToInt32(textBox3.Text);
                    //e.Graphics.TranslateTransform(a, b);
                    int a1=a;
                    int b1=b;
                    e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                    e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                    e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                    /*
                    a = Convert.ToInt32((a1-100)*Math.Cos(angle)-(b1-100)*Math.Sin(angle)+100);
                    b = Convert.ToInt32((a1-100)*Math.Sin(angle)+(b1-100)*Math.Cos(angle)+100);
                    */
                    e.Graphics.TranslateTransform(100, 100);
                    e.Graphics.RotateTransform(angle);
                    a = 0;
                    b = 0;

                    currentPen = new Pen(Color.Black);
           
                    e.Graphics.DrawLine(currentPen, a, b, a + 20, b - 20);
                    e.Graphics.DrawLine(currentPen, a + 20, b - 20, a + 100, b - 20);
                    e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 120, b - 40);
                    e.Graphics.DrawLine(currentPen, a + 120, b - 40, a + 160, b);
                    e.Graphics.DrawLine(currentPen, a + 160, b, a + 140, b + 20);



                    e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                    e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                    e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                    e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                    e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                    e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                    e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                    e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                    e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);

                
            }
            if (c == 5)
            {
                int d = 50;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);

                e.Graphics.DrawLine(currentPen, a, b, a + 20 + d, b - 20);
                e.Graphics.DrawLine(currentPen, a + 20 + d, b - 20, a + 100 + d, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100 + d, b - 20, a + 120 + d, b - 40);
                e.Graphics.DrawLine(currentPen, a + 120 + d, b - 40, a + 220 + d - 10, b);
                e.Graphics.DrawLine(currentPen, a + 220 + d - 10, b, a + 260 - 20, b + 20);


                e.Graphics.DrawLine(currentPen, a, b, a + 100+d, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100+d, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20+d, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20+d, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100+d, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100+d, b + 40, a + 100+d, b + 60);
                e.Graphics.DrawLine(currentPen,a + 100+d, b + 60, a + 140+d+d, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140+d+d, b + 20, a + 100+d, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100+d, b - 20, a + 100+d, b);

            }
            if (c == 6)
            {
                int d = -10;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);

                e.Graphics.DrawLine(currentPen, a, b, a + 20+d, b - 20);
                e.Graphics.DrawLine(currentPen, a + 20+d, b - 20, a + 100+d, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100+d, b - 20, a + 120+d, b - 40);
                e.Graphics.DrawLine(currentPen, a + 120+d, b - 40, a + 160+d-10, b);
                e.Graphics.DrawLine(currentPen, a + 160+d-10, b, a + 140-20, b + 20);

                e.Graphics.DrawLine(currentPen, a, b, a + 100 + d, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100 + d, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20 + d, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20 + d, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100 + d, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100 + d, b + 40, a + 100 + d, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100 + d, b + 60, a + 140 + d + d, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140 + d + d, b + 20, a + 100 + d, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100 + d, b - 20, a + 100 + d, b);

            }
            if (c == 7)
            {
                int v=10;
                int d = 0;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);

                e.Graphics.DrawLine(currentPen, a, b, a + 20, b - 20-v);
                e.Graphics.DrawLine(currentPen, a + 20, b - 20-v, a + 100, b - 20-v);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20-v, a + 120, b - 40-v);
                e.Graphics.DrawLine(currentPen, a + 120, b - 40-v, a + 160, b-v+20);
                e.Graphics.DrawLine(currentPen, a + 160, b-v+20, a + 140, b + 30);


                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 25);
                e.Graphics.DrawLine(currentPen, a + 20, b + 25, a, b + 40+v);
                e.Graphics.DrawLine(currentPen, a, b + 40+v, a + 100, b + 40+v);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40+v, a + 100, b + 60+v+v);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60+v+v, a + 140, b + 20+v);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20+v, a + 100, b - 20-v);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20-v, a + 100, b);
            }
            if (c == 8)
            {
                int v = -10;
                int d = 0;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);

                e.Graphics.DrawLine(currentPen, a, b, a + 20, b - 20 - v);
                e.Graphics.DrawLine(currentPen, a + 20, b - 20 - v, a + 100, b - 20 - v);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20 - v, a + 120, b - 30 - v);
                e.Graphics.DrawLine(currentPen, a + 120, b - 30 - v, a + 150, b);
                e.Graphics.DrawLine(currentPen, a + 150, b, a + 140, b +10);

                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 15);
                e.Graphics.DrawLine(currentPen, a + 20, b + 15, a, b + 40 + v);
                e.Graphics.DrawLine(currentPen, a, b + 40 + v, a + 100, b + 40 + v);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40 + v, a + 100, b + 60 + v + v);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60 + v + v, a + 140, b + 20 + v);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20 + v, a + 100, b - 20 - v);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20 - v, a + 100, b);
            }
            if (c == 9)
            {

                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                e.Graphics.DrawLine(currentPen, a, b, a - 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a - 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a - 20, b - 20);
                e.Graphics.DrawLine(currentPen, a - 20, b - 20, a, b - 40);
                e.Graphics.DrawLine(currentPen, a, b - 40, a - 100, b - 40);
                e.Graphics.DrawLine(currentPen, a - 100, b - 40, a - 100, b - 60);
                e.Graphics.DrawLine(currentPen, a - 100, b - 60, a - 140, b - 20);
                e.Graphics.DrawLine(currentPen, a - 140, b - 20, a - 100, b + 20);
                e.Graphics.DrawLine(currentPen, a - 100, b + 20, a - 100, b);

            }
            if (c == 10)
            {
                int r = -10;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                e.Graphics.DrawLine(currentPen, a, b, a + 20+r, b - 20+r);
                e.Graphics.DrawLine(currentPen, a + 20+r, b - 20+r, a + 100+r+10, b - 20+r);
                e.Graphics.DrawLine(currentPen, a + 100+r+10, b - 20+r, a + 120+r, b - 40+r);
                e.Graphics.DrawLine(currentPen, a + 120+r, b - 40+r, a + 160+r, b+r);
                e.Graphics.DrawLine(currentPen, a + 160+r, b+r, a + 140, b + 20);



                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);
            }
            if (c == 11)
            {
                int r = 10;
                currentPen = new Pen(Color.Black);
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                e.Graphics.DrawLine(currentPen, a, b, a + 20 + r, b - 20 + r);
                e.Graphics.DrawLine(currentPen, a + 20 + r, b - 20 + r, a + 100 + r + 10-20, b - 20 + r);
                e.Graphics.DrawLine(currentPen, a + 100 + r-20 + 10, b - 20 + r, a + 120 + r-20+5, b - 40 + r+10);
                e.Graphics.DrawLine(currentPen, a + 120 + r-20+5, b - 40 + r+10, a + 160 + r-20, b + r);
                e.Graphics.DrawLine(currentPen, a + 160 + r-20, b + r, a + 140, b + 20);



                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);
            }
            if (c == 12)
            {
                angle += Convert.ToInt32(textBox3.Text);
                //e.Graphics.TranslateTransform(a, b);
                int a1 = a;
                int b1 = b;
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                
                a = Convert.ToInt32((a1)*Math.Cos(angle)-(b1)*Math.Sin(angle));
                b = Convert.ToInt32((a1)*Math.Sin(angle)+(b1)*Math.Cos(angle));
                /*
                e.Graphics.RotateTransform(-angle);
                e.Graphics.TranslateTransform(0.0F-20, 0.0F-20);
                */
                currentPen = new Pen(Color.Black);
                e.Graphics.TranslateTransform(150, 150);
                e.Graphics.RotateTransform(-angle);
                a = 0;
                b = 0;

                e.Graphics.DrawLine(currentPen, a, b, a + 20, b - 20);
                e.Graphics.DrawLine(currentPen, a + 20, b - 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 120, b - 40);
                e.Graphics.DrawLine(currentPen, a + 120, b - 40, a + 160, b);
                e.Graphics.DrawLine(currentPen, a + 160, b, a + 140, b + 20);



                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);


            }
            if (c == 13)
            {
                angle += Convert.ToInt32(textBox3.Text);
                
                int a1 = a;
                int b1 = b;
                e.Graphics.DrawLine(currentPen, 190, 0, 190, 1000);
                e.Graphics.DrawLine(currentPen, 0, 110, 1000, 110);
                e.Graphics.DrawLine(currentPen, 0, 210, 400, 0);
                
                a = Convert.ToInt32((a1)*Math.Cos(angle)-(b1)*Math.Sin(angle));
                b = Convert.ToInt32((a1)*Math.Sin(angle)+(b1)*Math.Cos(angle));
                
                /*
                e.Graphics.RotateTransform(-angle);
                e.Graphics.TranslateTransform(0.0F + 20, 0.0F - 20);
                e.Graphics.TranslateTransform(a, b);
                */
                e.Graphics.TranslateTransform(130, 130);
                e.Graphics.RotateTransform(angle);
                a = 0;
                b = 0;
                currentPen = new Pen(Color.Black);

                e.Graphics.DrawLine(currentPen, a, b, a + 20, b - 20);
                e.Graphics.DrawLine(currentPen, a + 20, b - 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 120, b - 40);
                e.Graphics.DrawLine(currentPen, a + 120, b - 40, a + 160, b);
                e.Graphics.DrawLine(currentPen, a + 160, b, a + 140, b + 20);



                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 100, b);
                e.Graphics.DrawLine(currentPen, a, b, a + 20, b + 20);
                e.Graphics.DrawLine(currentPen, a + 20, b + 20, a, b + 40);
                e.Graphics.DrawLine(currentPen, a, b + 40, a + 100, b + 40);
                e.Graphics.DrawLine(currentPen, a + 100, b + 40, a + 100, b + 60);
                e.Graphics.DrawLine(currentPen, a + 100, b + 60, a + 140, b + 20);
                e.Graphics.DrawLine(currentPen, a + 140, b + 20, a + 100, b - 20);
                e.Graphics.DrawLine(currentPen, a + 100, b - 20, a + 100, b);


            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            c = 1;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            
        
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a -= 3;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a += 3;
            pictureBox1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            b += 3;
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b -= 3;
            pictureBox1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            c = 2;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            c = 7;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            c = 6;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            c = 3;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // X more
            c = 5;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            c = 8;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            d1 += 3;
            a = a + 3;
            b = b - 3;
            pictureBox1.Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            d1 -= 3;
            a = a - 3;
            b = b + 3;
            pictureBox1.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            c = 9;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            c = 10;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            c = 11;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            c = 12;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            c = 13;
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            pictureBox1.Refresh();
        }
    }
}
