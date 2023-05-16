using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerandoDeBoleto.Servicos
{
    class ServicoPaypal : IServicoPagamentoOnline
    {
        // Taxa de 1%

        public double TaxaParcela(double valor, int numeroMes)
        {
            return valor * 1 / 100 * numeroMes;
        }
        // Taxa de 2%
        public double TaxaPagamento(double taxaParcela)
        {
            return taxaParcela * 2 / 100;
        }
    }
}
