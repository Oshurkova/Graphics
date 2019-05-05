using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
      
    
        int[] m_p = new int[5];
        int index;
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Круг");
            comboBox1.Items.Add("Прямоугольник");
            comboBox1.Items.Add("Линия");
            comboBox1.Items.Add("Точка");
            comboBox1.Items.Add("Текст");

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Рисовать";
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  pictureBox1.Paint -= new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);

            switch (comboBox1.Text) {
                case "Круг": index=0; break;
                case "Прямоугольник": index = 1; break;
                case "Линия": index = 2; break;
                case "Точка": index = 3; break;
                case "Текст": index = 4; break;
                default: break;
            }


            m_p[1] = Convert.ToInt32(textBox1.Text);
            m_p[2] = Convert.ToInt32(textBox2.Text);
            m_p[3] = Convert.ToInt32(textBox3.Text);
            m_p[4] = Convert.ToInt32(textBox4.Text);
          //  DrawSm();
           
            pictureBox1.Refresh();

        
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
          //  pictureBox1.Image = null;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Pen currentPen = new Pen(colorDialog1.Color);
                currentPen.Width = Convert.ToInt32(textBox5.Text);
               SolidBrush crBr = new SolidBrush(currentPen.Color);
                if (checkBox1.Checked)
                {
                    
                     switch (index)
                    {
                        case 0:
                            e.Graphics.FillEllipse(crBr, m_p[1], m_p[2], m_p[3], m_p[4]);
                            break;
                        case 1:
                            e.Graphics.FillRectangle(crBr, m_p[1], m_p[2], m_p[3], m_p[4]);
                            break;
                        case 2:
                            e.Graphics.DrawLine(currentPen, m_p[1], m_p[2], m_p[3], m_p[4]);
                            break;
                        case 3:
                            e.Graphics.FillRectangle(crBr, m_p[1], m_p[2], 1, 1);
                            break;
                        case 4: e.Graphics.DrawString(textBox6.Text, new Font("Arial", Convert.ToInt32(textBox5.Text)), crBr, new Point(m_p[1], m_p[2]));

                            break;

                    }


                }
                else
                {
                    switch (index)
                    {
                        case 0:
                            e.Graphics.DrawEllipse(currentPen, m_p[1], m_p[2], m_p[3], m_p[4]);
                            break;
                        case 1:
                            e.Graphics.DrawRectangle(currentPen, m_p[1], m_p[2], m_p[3], m_p[4]);
                            break;
                        case 2:
                            e.Graphics.DrawLine(currentPen, m_p[1], m_p[2], m_p[3], m_p[4]);
                            break;
                        case 3:
                            e.Graphics.DrawRectangle(currentPen, m_p[1], m_p[2], 1, 1);

                            break;
                        case 4: e.Graphics.DrawString(textBox6.Text, new Font("Arial", Convert.ToInt32(textBox5.Text)), crBr, new Point(m_p[1], m_p[2]));

                            break;

                    }
                }
            }
 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      
       
   
        
    }
}
