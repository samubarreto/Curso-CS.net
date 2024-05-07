using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Estruturas_de_repeticao.Models
{
    public class Tabuada
    {
        public static void TabuadaDo10For(double num)
        {
            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{num} x {contador} = {num * contador}");
            }
        }
        public static void TabuadaDo10While(double num)
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine($"{num} x {contador} = {num * contador}");
                contador++;
            }
        }
        public static void TabuadaDo10DoWhile(double num)
        {
            int contador = 1;
            do
            {
                Console.WriteLine($"{num} x {contador} = {num * contador}");
                contador++;

            } while (contador <= 10);
        }
    }
}