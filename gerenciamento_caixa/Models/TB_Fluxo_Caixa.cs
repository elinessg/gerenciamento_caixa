using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gerenciamento_caixa.Models
{
    [Table("TB_Fluxo_Caixa")]
    public class TB_Fluxo_Caixa
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(1)]
        [Display(Name = "Tipo Movimento")]
        public string TipoMovimento { get; set; }
        [Display(Name = "Valor")]
        public decimal ValorMovimentacao { get; set; }
        [Display(Name = "Data")]
        public DateTime DataMovimentacao { get; set; }
        [Display(Name = "Descrição")]
        [MaxLength(250)]
        public string DescricaoMovimentacao { get; set; }

        public decimal Saldo { get; set; }
    }
}
