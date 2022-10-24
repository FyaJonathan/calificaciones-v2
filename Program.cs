using System;

namespace Calificaciones
{
    internal class Calificaciones
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Firmas());
            Console.Read();
        }

        public static int Firmas()
        {
            //variables
            int n1, n2;

            System.Console.Write("Ingrese las firmas maximas: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Ingrese sus firmas optenidas: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            //proceso

            int c = n1 + n2;
            return c;

        }

    }

    public static float ser(float pts, float ptsop)
    {
        float x = 5 / pts;
        x = x * ptsop;
        return x;
    }
}