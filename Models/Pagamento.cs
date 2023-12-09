using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace otilio_dotnet.Models
{
    public class Pagamento
    {
        public int Id {get; set;}

        [DataType(DataType.Date)]
        [Display(Name = "Data Limite")]
        public DateTime DataLimite {get; set;}

        public double Valor {get; set;}
        public bool Pago {get; set;}

        [Display(Name = "Nota de Venda")]
        [ForeignKey("NotaDeVenda")]
        public int NotaDeVendaId {get; set;}
        public NotaDeVenda? NotaDeVenda {get; set;}
    }
}