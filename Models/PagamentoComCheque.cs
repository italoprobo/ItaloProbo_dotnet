using System.ComponentModel.DataAnnotations;

namespace otilio_dotnet.Models
{
    public class PagamentoComCheque : TipoDePagamento
    {
        [Display(Name = "Nome do Banco")]
        public string? NomeDoBanco {get; set;}
    }
}