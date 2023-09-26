using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entre a quantidade de cartas para serem escolhidas: ");
        string linha = Console.ReadLine();
        if (int.TryParse(linha, out int numeroDeCartas))
        {
            foreach (string carta in CartaAleatoria.EscolherCarta(numeroDeCartas))
            {
                Console.WriteLine(carta);
            }
        }
        else
        {
            Console.WriteLine("Por favor, entre um valor inteiro válido.");
        }
        Console.ReadLine();
    }
}

