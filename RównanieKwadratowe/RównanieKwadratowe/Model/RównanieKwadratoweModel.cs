using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RównanieKwadratowe.Model
{
    public class RównanieKwadratoweModel
    {
        private double a;
        private double b;
        private double c;
        private double delta;
        public RównanieKwadratoweModel(double a,double b,double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            delta = b * b - 4 * a * c;
        }
        public double X1
        {
            get {
                if (delta >= 0)
                {
                    return (-b-Math.Sqrt(delta))/2*a;
                }
                return 0;
            }
        }       
        public double X2
        {
            get {
                if (delta > 0)
                {
                    return (-b + Math.Sqrt(delta)) / 2 * a;
                }
                return 0;
            }
        }
    }
}
