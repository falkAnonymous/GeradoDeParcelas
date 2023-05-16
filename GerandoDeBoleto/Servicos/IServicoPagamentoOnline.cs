using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerandoDeBoleto.Servicos
{
    interface IServicoPagamentoOnline
    {
        public double TaxaParcela(double valor, int numeroMes);
        public double TaxaPagamento(double taxaParcela);
    }
}
