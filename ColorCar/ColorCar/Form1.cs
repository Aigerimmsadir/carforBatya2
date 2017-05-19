using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
     
            InitializeComponent();
      

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackColor = Color.Black;
            
        }

   
        Pen pen1 = new Pen(Color.Red);
        Pen pen2 = new Pen(Color.Blue);

      static int x = 10, y = 110;
        Car car = new Car();
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        if(color==Colors.Blue)    e.Graphics.FillPath(pen2.Brush, car.gp);
        else e.Graphics.FillPath(pen1.Brush, car.gp);

        }
enum Colors
        {
            Blue,Red
        }
        Colors color = Colors.Blue;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (color == Colors.Blue)
            {
                x = x + 5;
                car.gp.Reset();
                car.Draw(x, y);
            }
            if (x == 520) color = Colors.Red;
            Refresh();
        }
    }
}
