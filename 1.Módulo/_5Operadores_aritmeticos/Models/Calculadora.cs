using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5Operadores_aritmeticos.Models
{
    public class Calculadora
    {
        public static double Somar(double x, double y)
        {
            return x + y;
        }
        public static double Subtrair(double x, double y)
        {
            return x - y;
        }
        public static double Multiplicar(double x, double y)
        {
            return x * y;
        }
        public static double Dividir(double x, double y)
        {
            return x / y;
        }
        public static double Potencia(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public static double Seno(double angulo)
        {
            return Math.Round(Math.Sin(angulo * Math.PI / 180), 4);
        }
        public static double Cosseno(double angulo)
        {
            return Math.Round(Math.Cos(angulo * Math.PI / 180), 4);
        }
        public static double Tangente(double angulo)
        {
            return Math.Round(Math.Tan(angulo * Math.PI / 180), 4);
        }
        public static int Sucessor(int x)
        {
            return ++x;
        }
        public static int Antecessor(int x)
        {
            return --x;
        }
        public static double Raiz(double x)
        {
            return Math.Sqrt(x);
        }
    }
}