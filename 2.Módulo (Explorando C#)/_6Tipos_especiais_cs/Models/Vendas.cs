using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace _6Tipos_especiais_cs.Models
{
    public class Venda(int? _IdVenda, string? _Produto, decimal? _Preco, DateTime? _DataVenda)
    {
        public int? IdVenda { get; set; } = _IdVenda;
        // [JsonProperty("Nome_Produto")]
        public string? Produto { get; set; } = _Produto;
        public decimal? Preco { get; set; } = _Preco;
        public DateTime? DataVenda { get; set; } = _DataVenda;
        public decimal? Desconto { get; set; }
    }
}