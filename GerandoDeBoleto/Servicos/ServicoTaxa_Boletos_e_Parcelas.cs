using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerandoDeBoleto.Entidades;

namespace GerandoDeBoleto.Servicos
{
    class ServicoTaxa_Boletos_e_Parcelas
    {
        ServicoPaypal servicoPay = new ServicoPaypal();

        public void TaxasBoletos(ColetaDados coletaDados, int diaMes)
        {

            double valor = coletaDados.ValorTotalBoleto / diaMes;

            for (int i = 1; i <= diaMes; i++)
            {
                
                double taxaDasParcelas = valor + servicoPay.TaxaParcela(valor, i);
                double taxaDosPagamentos = taxaDasParcelas + servicoPay.TaxaPagamento(taxaDasParcelas);
                coletaDados.geraBoletos.Add(new GeraBoletos(coletaDados.DataBoleto.AddMonths(i),taxaDosPagamentos));
            }
            foreach (GeraBoletos obj in coletaDados.geraBoletos)
            {
                Console.WriteLine(obj);
            }

        }

    }
}
