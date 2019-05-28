using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAtividadeEntrevista.Models.ValidationAttributes;

namespace WebAtividadeEntrevista.Models
{
    public class BeneficiarioModel
    {
        /// <summary>
        /// Id do beneficiario
        /// </summary>
        public long Id { get; set; }
        
        /// <summary>
        /// Id do Cliente
        /// </summary>
        public long IdCliente { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }


        /// <summary>
        /// CPF
        /// </summary>
        [Required(ErrorMessage = "CPF é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$", ErrorMessage ="O CPF não esta no formato válido")]
        [MaxLength(15, ErrorMessage = "Tamanho máximo é 15")]
        [ValidaCPF(ErrorMessage ="O CPF não está no formato válido")]
        public string CPF { get; set; }


    }
}