using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.BLL
{
    public class BoBeneficiario
    {
        /// <summary>
        /// Inclui um novo beneficiario
        /// </summary>
        /// <param name="beneficiario">Objeto de beneficiario</param>
        public long Incluir(DML.Beneficiario beneficiario)
        {
            DAL.DaoBeneficiario bene = new DAL.DaoBeneficiario();
            return bene.Incluir(beneficiario);
        }


        /// <summary>
        /// Inclui um ou mais novos beneficiarios
        /// </summary>
        /// <param name="beneficiario">Objeto de beneficiario</param>
        public List<long> Incluir(List<DML.Beneficiario> beneficiarios)
        {
            List<long> Ids = new List<long>();
            foreach (DML.Beneficiario beneficiario in beneficiarios)
            {
                Ids.Add(Incluir(beneficiario));
            }
            return Ids;
        }


        /// <summary>
        /// Altera um beneficiario
        /// </summary>
        /// <param name="beneficiario">Objeto de cliente</param>
        public void Alterar(DML.Beneficiario beneficiario)
        {
            DAL.DaoBeneficiario bene = new DAL.DaoBeneficiario();
            bene.Alterar(beneficiario);
        }


        /// <summary>
        /// Altera um ou mais beneficiarios
        /// </summary>
        /// <param name="beneficiario">Objeto de cliente</param>
        public void Alterar(List<DML.Beneficiario> beneficiarios)
        {
            foreach (var beneficiario in beneficiarios)
            {
                Alterar(beneficiario);
            }            
        }

        /// <summary>
        /// Excluir o beneficiario pelo id
        /// </summary>
        /// <param name="id">id do beneficiario</param>
        /// <returns></returns>
        public void Excluir(long id)
        {
            DAL.DaoBeneficiario bene = new DAL.DaoBeneficiario();
            bene.Excluir(id);
        }

        /// <summary>
        /// Excluir o beneficiario pelo id em lote
        /// </summary>
        /// <param name="id">id do beneficiario</param>
        /// <returns></returns>
        public void Excluir(List<long> ids)
        {
            foreach (var id in ids)
            {
                Excluir(id);
            }            
        }

        /// <summary>
        /// Lista os beneficiario
        /// </summary>
        public List<DML.Beneficiario> Listar(long Id)
        {
            DAL.DaoBeneficiario bene = new DAL.DaoBeneficiario();
            return bene.Listar(Id);
        }

        /// <summary>
        /// VerificaExistencia
        /// </summary>
        /// <param name="CPF"></param>
        /// <returns></returns>
        public bool VerificarExistencia(string CPF, long IdCliente)
        {
            DAL.DaoBeneficiario bene = new DAL.DaoBeneficiario();
            return bene.VerificarExistencia(CPF, IdCliente);
        }
    }
}
