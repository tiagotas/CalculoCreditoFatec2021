using System;
using System.Globalization;

namespace CalculoCredito
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Definindo o formato de número brasileiro.
             */
            NumberFormatInfo nfi = new CultureInfo("es-AG").NumberFormat;

            /**
             * $1,000.00 => en-US
             * R$ 1.000,00 => pt-BR
             * E 1.000,00 => pt-PT
             */ 

            /**
             * 5) A CEF concederá um crédito especial com juros de 2% aos seus clientes de acordo com 
             *    o saldo médio no último ano. Fazer um programa que leia o saldo médio de 
             *    um cliente e calcule o valor do crédito de acordo com a tabela a seguir. Imprimir 
             *    uma mensagem informando o saldo médio e o valor de crédito. 

                Saldo Médio           Percentual
                De 0 a 500            Nenhum crédito
                De 501 a 1000         30% do valor do saldo médio
                De 1001 a 3000        40% do valor do saldo médio
                Acima de 3001         50% do valor do saldo médio 
             */
            double saldo_medio, valor_credito = 0;
      
            Console.WriteLine("Informe o saldo médio da sua conta no último ano: ");
            saldo_medio = Convert.ToDouble(Console.ReadLine());

            // saldo = 1000;

            if(saldo_medio >= 501 && saldo_medio <= 1000)
            {
                valor_credito = saldo_medio * 0.3;

            } else if(saldo_medio >= 1001 && saldo_medio <= 3000)
            {
                valor_credito = saldo_medio * 0.4;

            } else if(saldo_medio >= 3001)
            {
                valor_credito = saldo_medio * 0.5;
            }

            Console.WriteLine("O saldo médio informado é: {0}", saldo_medio.ToString("C", nfi) );
            Console.WriteLine("O valor do seu Crédito é: {0}", valor_credito.ToString("C", nfi) );


            Console.ReadKey();
        }
    }
}
