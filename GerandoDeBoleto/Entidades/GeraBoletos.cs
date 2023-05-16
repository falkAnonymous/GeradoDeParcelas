using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace GerandoDeBoleto.Entidades
{
    class GeraBoletos // Gera o boleto
    {
        public DateTime DataVencimento { get; set; }
        public double Pagamento { get; set; }

        public GeraBoletos(DateTime dataVencimento, double pagamento)
        {
            DataVencimento = dataVencimento;
            Pagamento = pagamento;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{DataVencimento.ToString("dd/MM/yyyy")} - {Pagamento.ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();


        }
    }
}
