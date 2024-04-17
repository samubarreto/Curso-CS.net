using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5Nuget_Serializar_Atributos_no_cs.Models
{
    public class DesserializarVenda
    {
        public int IdVenda { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}