// Program.cs

using System;

namespace Learning03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear fracciones usando diferentes constructores
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction(6);
            Fraction fraction3 = new Fraction(6, 7);

            // Obtener y mostrar los valores de las fracciones
            Console.WriteLine("Fraction 1: " + fraction1.GetTop() + "/" + fraction1.GetBottom());
            Console.WriteLine("Fraction 2: " + fraction2.GetTop() + "/" + fraction2.GetBottom());
            Console.WriteLine("Fraction 3: " + fraction3.GetTop() + "/" + fraction3.GetBottom());

            // Cambiar los valores de las fracciones usando setters
            fraction1.SetTop(3);
            fraction1.SetBottom(4);
            fraction2.SetTop(1);
            fraction2.SetBottom(3);
            fraction3.SetTop(5);
            fraction3.SetBottom(8);

            // Obtener y mostrar las nuevas representaciones de las fracciones
            Console.WriteLine("Fraction 1: " + fraction1.GetTop() + "/" + fraction1.GetBottom());
            Console.WriteLine("Fraction 2: " + fraction2.GetTop() + "/" + fraction2.GetBottom());
            Console.WriteLine("Fraction 3: " + fraction3.GetTop() + "/" + fraction3.GetBottom());

            // Otros métodos de la clase Fraction se pueden probar de manera similar
        }
    }
}
