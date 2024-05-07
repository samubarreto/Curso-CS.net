using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _6Tipos_especiais_cs.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int num) // extendendo o comportamento do inteiro
        {
            return num % 2 == 0;
        }
    }
}