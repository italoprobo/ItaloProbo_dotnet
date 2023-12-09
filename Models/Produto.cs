using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otilio_dotnet.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string? Nome {get; set;}

        [Display(Name = "Descrição")]
        public string? Descricao {get; set;}
        
        [Display(Name = "Preço")]
        public double Preco {get; set;}
        public int Quantidade {get; set;}

        [ForeignKey("Marca")]
        public int MarcaId {get; set;}
        public Marca? Marca {get; set;}   
    }
}