using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4Tuplas_Operador_Ternario_Desconstrucao_obj.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] linhasArquivo, int quantidadeLinhas) LerArquivo(string caminho) // lê um arquivo e retorna uma tupla com oq deu
        {
            try
            {
                return (true, File.ReadAllLines(caminho), File.ReadAllLines(caminho).Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}