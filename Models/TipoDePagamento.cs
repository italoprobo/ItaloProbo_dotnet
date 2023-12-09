using System.ComponentModel.DataAnnotations;

namespace otilio_dotnet.Models
{
    public class TipoDePagamento
    {
        public int Id {get; set;}

        [Display(Name = "Nome do Cobrado")]
        public string? NomeDoCobrado {get; set;}
        
        [Display(Name = "Informações Adicionais")]
        public string? InformacoesAdicionais {get; set;}
    }
}