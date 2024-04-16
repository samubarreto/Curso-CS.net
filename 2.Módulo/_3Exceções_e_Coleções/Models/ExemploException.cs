using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3Exceções_e_Coleções.Models
{
    public class ExemploException
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Deu exceção, mas tá tratada.");
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    }
}