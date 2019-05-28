using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    /// <summary>
    /// Classe de beneficiario que representa o registo na tabela Beneficiario do Banco de Dados
    /// </summary>
    public class Beneficiario
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// Id de quem o beneficiário é dependente
        /// </summary>
        public long IdCliente { get; set; }

        /// <summary>
        /// Nome do beneficiário
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// CPF do beneficiário
        /// </summary>
        public string CPF { get; set; }
    }
}
