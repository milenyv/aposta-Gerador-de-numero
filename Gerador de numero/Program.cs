using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int quantidadeNumeros = 6;
        int valorMinimo = 1;
        int valorMaximo = 60;

        List<int> aposta = GerarNumeroAposta(quantidadeNumeros, valorMinimo, valorMaximo);

        Console.WriteLine("Números da aposta:");
        foreach (int numero in aposta)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }

    static List<int> GerarNumeroAposta(int qtdNumeros, int minValor, int maxValor)
    {
        List<int> numerosAposta = new List<int>();
        Random random = new Random();

        while (numerosAposta.Count < qtdNumeros)
        {
            int numero = random.Next(minValor, maxValor + 1);
            if (!numerosAposta.Contains(numero))
            {
                numerosAposta.Add(numero);
            }
        }

        numerosAposta.Sort();
        return numerosAposta;
    }
}
