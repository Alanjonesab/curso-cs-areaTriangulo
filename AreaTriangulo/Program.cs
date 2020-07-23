using System;


namespace AreaTriangulo {
    class Program {
        static void Main(string[] args) {

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.CalculaArea();
            double areaY = y.CalculaArea();

            Console.WriteLine("As área do triângulo X é {0} e a do triângulo Y é {1}", areaX, areaY);
        }
    }
}
