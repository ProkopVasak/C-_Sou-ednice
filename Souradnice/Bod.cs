using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Souradnice
{
    internal class Bod 
    {
        public Bod(int x, int y )
        {
            X = x;
            Y = y;

        }
        public int X { get; set; }
        public int Y { get; set; }
        public double Size { get { return Math.Sqrt(X * X + Y * Y); } }
        /*public Bod Násobení(int z)
        {
            Bod c = new Bod(X * z, Y * z);
            return c;
        }
        public Bod Sčítání(Bod x,Bod y)
        {
            Bod d = new Bod(x.X+y.X,x.Y+y.Y);
            return d;
        }
        public static bool Equals(Bod x , Bod y)
        {
            if (x.X.Equals(y.X) && x.Y.Equals(y.Y)) return true;
            else return false;
        }
        public static string KdoJeDál(Bod x,Bod y)
        {
            if (x.Size > y.Size) return "1. bod je dále od počátku.";
            else if (Equals(x, y)) return "Body jsou stejně daleko od počátku.";
            else return "2. bod je dále od počátku.";
        }*/
    } 
}
