using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia
            double raio = 4.5;
            const double PI = 3.14;
            // const não permite mudar o valor da variavel durante o processo
            raio = 5.5;
            // PI = 3.1415;
            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorInt = int.MinValue; //Mais usado dos inteiros!
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_60_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorlLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorlLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundia " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço do Computador " + precoComputador);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curdo de C#";
            Console.WriteLine(texto);
        }
    }
}
