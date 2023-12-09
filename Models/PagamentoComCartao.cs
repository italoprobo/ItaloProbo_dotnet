using System.ComponentModel.DataAnnotations;

namespace otilio_dotnet.Models
{
    public class PagamentoComCartao : TipoDePagamento
    {
        [Display(Name = "Número do Cartão")]
        public String? NumeroDoCartao {get; set;}
        public String? Bandeira {get; set;}
    }
}