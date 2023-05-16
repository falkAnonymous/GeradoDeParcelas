using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerandoDeBoleto.Entidades
{
    class ColetaDados
    {
        public int NumeroID_Boleto { get; set; } // Numero do Identificador do Boleto
        public DateTime DataBoleto { get; set; } // Data gerada do boleto
        public double ValorTotalBoleto { get;  private set; } // Valor Total do Boleto
        public List<GeraBoletos> geraBoletos { get; set; } = new List<GeraBoletos>();

        public ColetaDados(int numeroID_Boleto, DateTime dataBoleto, double valorTotalBoleto)
        {
            NumeroID_Boleto = numeroID_Boleto;
            DataBoleto = dataBoleto;
            ValorTotalBoleto = valorTotalBoleto;
        }


    }
}
