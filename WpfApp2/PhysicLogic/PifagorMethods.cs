using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.PhysicLogic
{
    internal class PifagorMethods
    {

        static double CalculateHypotenuse(int a, int b, int angle)
        {
            double c = Math.Pow(a, 2) + Math.Pow(b, 2) - (2 * b * a) * Math.Cos(angle);
            return Math.Sqrt(c);
        }



    }
}
