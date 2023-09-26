using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class CartaAleatoria
{
    static Random random = new Random();

    public static string[] EscolherCarta(int numeroDeCartas)
    {
        string[] cartasEscolhidas = new string[numeroDeCartas];
        for (int i = 0; i < numeroDeCartas; i++)
        {
            cartasEscolhidas[i] = ValorAleatorio() + " de " + NaipeAleatorio();
        }
        return cartasEscolhidas;
    }

    private static string ValorAleatorio()
    {
        int valor = random.Next(1, 14); // Retorna de 1 a 13
        if (valor == 1) return "Ás";
        if (valor == 11) return "Valete";
        if (valor == 12) return "Dama";
        if (valor == 13) return "Rei";
        return valor.ToString();
    }

    private static string NaipeAleatorio()
    {
        int valor = random.Next(1, 5);
        if (valor == 1) return "Espadas";
        if (valor == 2) return "Copas";
        if (valor == 3) return "Ouros";
        return "Paus";
    }
}
