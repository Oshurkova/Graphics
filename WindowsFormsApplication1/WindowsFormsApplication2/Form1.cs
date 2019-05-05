using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {   int index;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4"); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            switch (comboBox1.Text)
            {
                case "1": index = 0; break;
                case "2": index = 1; break;
                case "3": index = 2; break;
                case "4": index = 3; break;
                default: break;
            }



            pictureBox1.Refresh();

        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
          //  pictureBox1.Image = null;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               
                Graphics g = pictureBox1.CreateGraphics();
                Pen c = new Pen(colorDialog1.Color);
                Pen cc = new Pen(Color.Black);
                SolidBrush p = new SolidBrush(c.Color);
                SolidBrush pp = new SolidBrush(Color.Black);
                     switch (index)
                    {   
                           
                        case 0:
                            
                            e.Graphics.FillRectangle(pp, 35, 100, 50, 30);
                            e.Graphics.FillEllipse(p, 10, 10, 100, 100);
                            e.Graphics.DrawLine(cc, 60, 120, 60, 50);
                            
                            break;
                        case 1:
                            e.Graphics.FillRectangle(pp, 35, 100, 50, 30);
                            e.Graphics.FillEllipse(p, 10, 10, 100, 100);
                            e.Graphics.DrawLine(cc, 60, 120, 60, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 40, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 80, 50);
                            break;
                        case 2:
                            e.Graphics.FillRectangle(pp, 35, 100, 50, 30);
                            e.Graphics.FillEllipse(p, 10, 10, 100, 100);
                            e.Graphics.DrawLine(cc, 60, 120, 60, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 40, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 80, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 20, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 100, 50);
                            break;
                        case 3:
                            e.Graphics.FillRectangle(pp, 35, 100, 50, 30);
                            e.Graphics.FillEllipse(p, 10, 10, 100, 100);
                            e.Graphics.DrawLine(cc, 60, 120, 60, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 40, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 80, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 20, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 100, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 0, 50);
                            e.Graphics.DrawLine(cc, 60, 120, 120, 50);
                            break;
                       

                    }

                
      
                
                  
                
            }
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Refresh();


        }
    }
}
