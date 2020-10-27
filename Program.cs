using System;

namespace AnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            double emprestimo, renda, porcentagemRenda, calcularCredito;
            int parcela;
            string emprestimoTexto, rendaTexto, parcelaTexto;
            bool emprestimoValido, parcelaValida, rendaValida;

            Console.Clear();
            Console.WriteLine("--- Análise de Crédito ");

            Console.Write("Digite o valor do empréstimo desejado........:");
            emprestimoTexto = Console.ReadLine();

            Console.Write("Digite em quantas parcelas deseja pagar..:");
            parcelaTexto = Console.ReadLine();

            Console.Write("Digite sua renda mensal......................:");
            rendaTexto = Console.ReadLine();

            emprestimoValido = double.TryParse(emprestimoTexto, out emprestimo);
            parcelaValida = int.TryParse(parcelaTexto, out parcela);
            rendaValida = double.TryParse(rendaTexto, out renda);
            
            porcentagemRenda = 0.3 * renda;
            calcularCredito = emprestimo / parcela;

            if (!emprestimoValido)
            {
                Console.WriteLine("Valor inválido");
            }
            else if (!parcelaValida)
            {
                Console.WriteLine("Valor inválido");
            }
            else if (!rendaValida)
            {
                Console.WriteLine("Valor inválido");
            }
            else if (porcentagemRenda > calcularCredito)
            {
                Console.WriteLine("Parabéns, seu empréstimo foi aprovado.");
            }
            else
            {
                Console.WriteLine("Desculpe, seu empréstimo não foi aprovado.");
            }
            

        }
    }
}
