using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace Balon
{
    class Balon
    {
        Random r=new Random();
        int x, y;
        public Balon(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Crtaj(Graphics g)
        {
            int a = 15;
            SolidBrush cetkica = new SolidBrush(Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)));
            Pen olovka = new Pen(Color.Black, 1);
            PointF[] points ={new PointF(x,y-3),new PointF(x-a,y+a), new PointF(x+a,y+a)};
            g.FillEllipse(cetkica,x-3*a,y-8*a,6*a,8*a);
            g.FillPolygon(cetkica, points);
            
            g.DrawLine(olovka,x,y+a,x-a,y+2*a);
            g.DrawLine(olovka, x - a, y + 2 * a, x + a, y + 3 * a);
            g.DrawLine(olovka, x + a, y + 3 * a, x - a, y + 4 * a);
            g.DrawLine(olovka, x - a, y + 4 * a,x+a,y+5*a);
        }
       
    }
}
