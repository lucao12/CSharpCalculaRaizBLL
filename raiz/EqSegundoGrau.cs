using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace raiz
{
    internal class EqSegundoGrau
    {
        private string a;
        private string b;
        private string c;
        private double Aa;
        private double Bb;
        private double Cc;

        public void setA(string A) { a = A; Aa = double.Parse(A); }
        public String getA() { return a; }
        public void setB(string B) { b = B; Bb = double.Parse(B); }
        public String getB() { return b; }
        public void setC(string C) { c = C; Cc = double.Parse(C); }
        public String getC() { return c; }
        public String getCalcDelta() { return ((Math.Pow(Bb, 2)) - (4 * Aa * Cc)).ToString(); }
        

        public String getCalcA() { return ((-Bb + Math.Sqrt(double.Parse(getCalcDelta()))) / (2 * Aa)).ToString("F5"); }
        public String getCalcB() { return ((-Bb - Math.Sqrt(double.Parse(getCalcDelta()))) / (2 * Aa)).ToString("F5"); }
        

    }
}
