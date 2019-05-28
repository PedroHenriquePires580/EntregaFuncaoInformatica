﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebAtividadeEntrevista.Models.ValidationAttributes;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Cliente
    /// </summary>
    public class ClienteModel
    {
        public ClienteModel()
        {
            Beneficiarios = new List<BeneficiarioModel>();
            BeneficiariosAlterar = new List<BeneficiarioModel>();
            BeneficiariosExcluir = new List<BeneficiarioModel>();
        }

        public long Id { get; set; }
        
        /// <summary>
        /// CEP
        /// </summary>
        [Required]
        public string CEP { get; set; }

        /// <summary>
        /// Cidade
        /// </summary>
        [Required]
        public string Cidade { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Digite um e-mail válido")]
        public string Email { get; set; }

        /// <summary>
        /// Estado
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        /// <summary>
        /// Logradouro
        /// </summary>
        [Required]
        public string Logradouro { get; set; }

        /// <summary>
        /// Nacionalidade
        /// </summary>
        [Required]
        public string Nacionalidade { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [Required]
        public string Nome { get; set; }

        /// <summary>
        /// Sobrenome
        /// </summary>
        [Required(ErrorMessage ="Sobrenome é obrigatório")]
        public string Sobrenome { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Telefone { get; set; }


        /// <summary>
        /// CPF
        /// </summary>
        [Required(ErrorMessage ="CPF é obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$",ErrorMessage ="CPF não está no formato válido")]
        [MaxLength(15,ErrorMessage ="Tamanho máximo é 15")]
        [ValidaCPF(ErrorMessage = "O CPF não está no formato válido")]
        public string CPF { get; set; }

        public List<BeneficiarioModel> Beneficiarios { get; set; }
        public List<BeneficiarioModel> BeneficiariosAlterar { get; set; }
        public List<BeneficiarioModel> BeneficiariosExcluir { get; set; }
    }    
}