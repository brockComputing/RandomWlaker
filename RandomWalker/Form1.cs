using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomWalker
{
    
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        class Walker
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Walker(int x, int y)
            {
                X = x;
                Y = y;
            }

            public void Display(Graphics graphics)
            {
                graphics.FillEllipse(Brushes.BlueViolet ,X,Y,5,5);

            }

            public void Step()
            {
                int choice = rnd.Next(0, 4);
                if (choice == 0)
                {
                    X++;
                }
                else if (choice == 1)
                {
                    X--;
                }
                else if (choice == 2)
                {
                    Y++;
                }
                else
                {
                    Y--;
                }
            }
        }
        public Form1()
        {         
            InitializeComponent();
        }
        Walker walker = new Walker(200,200);
        private void Form1_Load(object sender, EventArgs e)
        {
            Timer timer1 = new Timer();
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
            timer1.Interval = 1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            walker.Step();
            walker.Display(graphics);

        }
    }
}
