using System.ComponentModel.DataAnnotations;
using FI.WebAtividadeEntrevista.Validators;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        public long Id { get; set; }

        /// <summary>
        /// CPF
        /// </summary>
        [Required]
        [StringLength(11)]
        [CPF]
        public string CPF { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        public long IdCliente { get; set; }
    }
}