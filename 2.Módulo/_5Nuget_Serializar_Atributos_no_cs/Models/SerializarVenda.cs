using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _5Nuget_Serializar_Atributos_no_cs.Models
{
    public class Venda
    {
        public Venda(int _IdVenda, string _Produto, decimal _Preco, DateTime _DataVenda)
        {
            IdVenda = _IdVenda;
            Produto = _Produto;
            Preco = _Preco;
            DataVenda = _DataVenda;
        }
        public int IdVenda { get; set; }
        // [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}