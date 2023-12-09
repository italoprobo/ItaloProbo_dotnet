using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otilio_dotnet.Models

{
    public class Item
    {
        public int Id { get; set; }

        [Display(Name = "Preço")]
        public double Preco { get; set; }
        public int Percentual { get; set; }
        public int Qtd { get; set; }

        [Display(Name = "Nota de Venda")]
        [ForeignKey("NotaDeVenda")]
        public int NotaDeVendaId { get; set; }
        public NotaDeVenda? NotaDeVenda { get; set; }

        [ForeignKey("Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

    }

}