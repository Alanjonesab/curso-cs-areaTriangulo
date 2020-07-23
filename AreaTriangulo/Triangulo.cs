using System;
using System.Collections.Generic;
using System.Text;

namespace AreaTriangulo {
    class Triangulo {

        public double A;
        public double B;
        public double C;

        public double CalculaArea() {
            double area, p;

            p = (A + B + C) / 2;
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
            
        }
    }
}
