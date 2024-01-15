using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_app
{
    public class ogpanel : Panel
    {
        public ogpanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        private void InitializeComponent2()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }

       
    }








    public partial class Form1 : Form
    {
        public Point cursor = new Point();
        public Point cursor1 = new Point();

        public Pen pen = new Pen(Color.White);

        public Graphics g;
        public Pen rubber = new Pen(Color.Black, 15);
        public Brush brush = new SolidBrush(Color.White);
        public Bitmap son;
        public Image jo;
    
        public int lupin = 0;
        public int u = 0;
        public bool ji = false;










        public Form1()
        {
            InitializeComponent();

            g = panel4.CreateGraphics();
            son = new Bitmap(panel4.Width, panel4.Height);
            g = Graphics.FromImage(son);
            panel4.BackgroundImage = son;
            panel4.BackgroundImageLayout = ImageLayout.None;
            button1.Text = "Colour change";
            button2.Text = "Rubber";
            button3.Text = "Size";
            button4.Text = "Rectangle(filled)";
            button8.Text = "Circle(filled ellipse)";
            button7.Text = "Draw Image";
            button9.Text = "Save Image";
            button6.Text = "Rectangle";
            button5.Text = "Circle(ellipse)";
            button10.Text = "Arc";
            button3.Click += button3_Click;
            button4.Click += button4_Click;
            button8.Click += button8_Click;
            button7.Click += button7_Click;
            button6.Click += button6_Click;
            button5.Click += button5_Click;
            button10.Click += button10_Click;
            


            panel4.MouseClick += panel4_MouseClick;






        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog ui = new ColorDialog();
            if (ui.ShowDialog() == DialogResult.OK)
            {
                pen.Color = ui.Color;
                brush = new SolidBrush(ui.Color);

            }




        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {






















        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lupin != 1)
            {
                u = lupin;
                lupin = 1;

            }
            else
            {
                lupin = u;

            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {



        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            cursor1 = e.Location;

        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)

        {

            if (lupin == 0 & e.Button == MouseButtons.Left)
            {
                cursor = e.Location;
                g.DrawLine(pen, cursor1, cursor);
                cursor1 = cursor;
                panel4.Invalidate();
            }
            if (lupin == 1 & e.Button == MouseButtons.Left)
            {
                cursor = e.Location;
                g.DrawLine(rubber, cursor1, cursor);
                cursor1 = cursor;
                panel4.Invalidate();

            }


        }

        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {

            try
            {
                if (lupin == 2 & e.Button == MouseButtons.Right)
                {
                    string u2 = textbox1.Text;

                    string[] re = u2.Split(",".ToCharArray());

                    cursor = e.Location;
                    g.FillRectangle(brush, cursor1.X, cursor.Y, int.Parse(re[0]), int.Parse(re[1]));
                    cursor1 = cursor;
                    panel4.Invalidate();
                }

                if (lupin == 3 & e.Button == MouseButtons.Right)
                {
                    string u2 = textbox1.Text;

                    string[] re = u2.Split(",".ToCharArray());

                    cursor = e.Location;
                    g.FillEllipse(brush, cursor1.X, cursor.Y, int.Parse(re[0]), int.Parse(re[1]));
                    cursor1 = cursor;
                    panel4.Invalidate();
                }
                if (lupin == 4 & e.Button == MouseButtons.Right)
                {
                    string u2 = textbox1.Text;

                    string[] re = u2.Split(",".ToCharArray());

                    cursor = e.Location;
                    g.DrawImage(jo, cursor1.X, cursor.Y, int.Parse(re[0]), int.Parse(re[1]));
                    cursor1 = cursor;
                    panel4.Invalidate();
                }
                if (lupin == 5 & e.Button == MouseButtons.Right)
                {
                    string u2 = textbox1.Text;

                    string[] re = u2.Split(",".ToCharArray());

                    cursor = e.Location;
                   
                    
                        g.DrawRectangle(pen, cursor.X, cursor.Y, int.Parse(re[0]), int.Parse(re[1]));
              
                    
                    
                    cursor1 = cursor;
                    panel4.Invalidate();
                }
                if (lupin == 6 & e.Button == MouseButtons.Right)
                {
                    string u2 = textbox1.Text;

                    string[] re = u2.Split(",".ToCharArray());

                    cursor = e.Location;


                    g.DrawEllipse(pen, cursor.X, cursor.Y, int.Parse(re[0]), int.Parse(re[1]));



                    cursor1 = cursor;
                    panel4.Invalidate();
                }
                if (lupin == 7 & e.Button == MouseButtons.Right)
                {
                    string u2 = textbox1.Text;

                    string[] re = u2.Split(",".ToCharArray());

                    cursor = e.Location;


                    g.DrawArc(pen, cursor.X, cursor.Y, int.Parse(re[0]), int.Parse(re[1]), int.Parse(re[2]), int.Parse(re[3]));



                    cursor1 = cursor;
                    panel4.Invalidate();
                }


            }
            catch
            {
                MessageBox.Show("Input Measurement Correctly");
            }



        }


        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Input the name ");
            string p = textbox1.Text;
            son.Save(p, System.Drawing.Imaging.ImageFormat.Png);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (lupin == 0)
            {
                try
                {


                    if (ji == false)
                    {
                        int u2 = int.Parse(textbox1.Text);
                        pen.Width = u2;
                        ji = true;

                    }
                    else
                    {
                        pen.Width = 2;
                        ji = false;
                    }


                }
                catch
                {
                    MessageBox.Show("type a number ");

                }
            }
           
            if (lupin == 1)
            {
                try
                {
                    if (ji == false)
                    {
                        int u2 = int.Parse(textbox1.Text);
                        rubber.Width = u2;
                        ji = true;

                    }
                    else
                    {
                        rubber.Width = 15;
                        ji = false;
                    }
                }
                catch
                {
                    MessageBox.Show("type a number ");

                }
            }






        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (lupin != 2)
            {
              
                lupin = 2;
                MessageBox.Show("You need to intput height,width (in this order and using commas) ");

            }
            else
            {
                lupin = 0;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (lupin != 3)
            {
          
                lupin = 3;
               MessageBox.Show("You need to intput height,width (in this order and using commas) ");

            }
            else
            {
                lupin = 0;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (lupin != 4)
            {
                
                lupin = 4;
                MessageBox.Show("You need to intput height,width (in this order and using commas) ");
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    jo = Image.FromFile(op.FileName);
                }

            }
            else
            {
                lupin = 0;
            }
        }  
        private void button6_Click(object sender, EventArgs e)
        {
            if (lupin != 5)
            {
                
                lupin = 5;
                MessageBox.Show("You need to intput height,width (in this order and using commas) ");
            }
            else
            {
                lupin = 0;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (lupin != 6)
            {
                
                lupin = 6;
                MessageBox.Show("You need to intput height,width (in this order and using commas) ");

            }
            else
            {
                lupin = 0;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (lupin != 7)
            {
              
                lupin = 7;
                MessageBox.Show("You need to intput height,width,start angle,sweep angle (in this order and using commas)");
            }
            else
            {
                lupin = 0;
            }
            
        }
    }
}
    