using System;
using System.Threading.Channels;
using MainMenu;

namespace JogoForca
{
    public static class Program
    {
        public static void Inicio()
        {
            Console.WriteLine("Jogador 1 escreve a palavra: ");
            string palavraEscolhida = Console.ReadLine();
            string[] letrasIdentificadas = new string[palavraEscolhida.Length];

            int tamanhoPalavraEscolhida = palavraEscolhida.Length;

            for (int i = 0; i < tamanhoPalavraEscolhida; i++)
            {
                Console.WriteLine("-");

            }
            Console.WriteLine();

            string letraEscolhida = Console.ReadLine();

            for (int i = 0; i < tamanhoPalavraEscolhida; i++)
            { 
            string letraAtual = palavraEscolhida[i].ToString();
                if (letraAtual == letraEscolhida)
                {
                    Console.WriteLine(letraEscolhida);
                }
            }




            //Console.WriteLine("Jogador 1: ");
            //Console.Write("Insira a palavra: ");
            //string palavraJogador1 = Console.ReadLine();
            //Console.WriteLine("Vez do jogador 2");

            //int tamanhoPalavra = palavraJogador1.Length;
            //char tamanhoCharPalavra = Convert.ToChar(tamanhoPalavra);

            //for (int i = 0; i < tamanhoCharPalavra; i++)
            //{
            //    Console.Write("-");
            //}

        }
    }
}
