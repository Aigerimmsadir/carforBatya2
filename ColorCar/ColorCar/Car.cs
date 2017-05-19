using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCar
{
   public class Car
    {

       public GraphicsPath gp = new GraphicsPath();
      public void Draw(int x, int y)
        {
            Rectangle r = new Rectangle(x, y, 30, 20);
            Rectangle r2 = new Rectangle(x + 30, y + 10, 10, 10);
            Rectangle r3 = new Rectangle(x + 4, y + 19, 10, 10);
            Rectangle r4 = new Rectangle(x + 16, y + 19, 10, 10);
            gp.AddRectangle(r);
            gp.AddRectangle(r2);
            gp.AddEllipse(r3);
            gp.AddEllipse(r4);
        }
        
    }
}
