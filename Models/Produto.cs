using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace APIExemplo.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        [JsonIgnore]
        public ICollection<VendaProduto> VendaProdutos { get; set; }
    }
}
