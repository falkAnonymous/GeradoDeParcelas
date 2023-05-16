using System;
using System.Globalization;
using GerandoDeBoleto.Entidades;
using GerandoDeBoleto.Servicos;

namespace GerandoDeBoleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numero do \u0022ID\u0022 do boleto: ");
            int nº = Convert.ToInt32(Console.ReadLine());
            Console.Write("Data gerado:  ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do boleto: ");
            double valorBoleto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantas vezes Pretende parcelar? ");
            int parcelas = int.Parse(Console.ReadLine());

            // instanciando as variaveis

            ColetaDados coletaDados = new ColetaDados(nº, data, valorBoleto);
            ServicoTaxa_Boletos_e_Parcelas servicoTaxa = new ServicoTaxa_Boletos_e_Parcelas();
            servicoTaxa.TaxasBoletos(coletaDados, parcelas);



        }
    }
}
