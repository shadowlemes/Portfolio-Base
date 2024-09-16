using System;
using System.Threading.Channels;
using MainMenu;

namespace JogoForca
{
    public static class Program
    {
        public static void Inicio()
        {
            Console.WriteLine("JOGO DA FORCA");
            Console.WriteLine("Jogador 1\nDigita a palavra e pressiona ENTER\n");
            string palavraEscolhida = Console.ReadLine();
            string[] letrasIdentificadas = new string[palavraEscolhida.Length];
            int tamanhoPalavraEscolhida = palavraEscolhida.Length;


            Console.Clear();
            bool jogoEmAndamento = true;

            do
            {
                Console.Clear(); // inicia loop para exibição da tela de jogo
                Console.WriteLine($"Jogador 2\nA palavra escolhida tem {tamanhoPalavraEscolhida} letras.\n");

                Console.Write("A palavra escolhida é: \n");

                for (int i = 0; i < letrasIdentificadas.Length; i++)
                {
                    string letraAtual = letrasIdentificadas[i];
                    if (letraAtual[i] == null)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(letraAtual);
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Digite a letra para tentar adivinhar a palavra");
                Console.WriteLine("A letra escolhida é: ");
                string letraEscolhida = Console.ReadLine();

                for (int i = 0; i < tamanhoPalavraEscolhida; i++)
                {
                    string letraAtual = palavraEscolhida[i].ToString();
                    if (letraAtual == letraEscolhida)
                    {
                        letrasIdentificadas[i] = letraAtual;
                    }
                }
                bool todasLetrasIdentificadas = true;
                for (int i = 0; i < letrasIdentificadas.Length; i++)
                {
                    string letraAtual = letrasIdentificadas[i];
                    if (letraAtual[i] == null)
                    {
                        todasLetrasIdentificadas = false;
                    }
                }
                if (todasLetrasIdentificadas)
                {
                    jogoEmAndamento = false;
                };

            }
            while (jogoEmAndamento); 

            Console.WriteLine("Pressiona qualquer tecla para encerrar o jogo");
            Console.ReadKey();
        }
    }
}
