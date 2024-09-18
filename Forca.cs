namespace JogoForca
{
    public static class Program
    {
        public static void Inicio()
        {
            Console.WriteLine("JOGO DA FORCA\n");
            Console.WriteLine("Vez do jogador 1\nDigita a palavra e pressiona ENTER:\n");
            string palavraEscolhida = Console.ReadLine();
            string[] letrasIdentificadas = new string[palavraEscolhida.Length];
            int tamanhoPalavraEscolhida = palavraEscolhida.Length;
            int vidas = palavraEscolhida.Length;
            bool letraEncontrada = false;

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
                    if (letrasIdentificadas[i] == null)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(letraAtual);
                    }
                }

                Console.WriteLine();

                Console.WriteLine($"Você tem {vidas} vidas\nDigite a letra para tentar adivinhar a palavra");
                Console.WriteLine("A letra escolhida é: ");
                string letraEscolhida = Console.ReadLine();

                for (int i = 0; i < tamanhoPalavraEscolhida; i++)
                {
                    string letraAtual = palavraEscolhida[i].ToString();
                    if (letraAtual == letraEscolhida)
                    {
                        letrasIdentificadas[i] = letraAtual;
                        letraEncontrada = true;
                    }
                    if (!letraEncontrada)
                    {
                        vidas--;
                    }
                }
                bool todasLetrasIdentificadas = true;             
                for (int i = 0; i < letrasIdentificadas.Length; i++)
                {
                   string letraAtual = letrasIdentificadas[i];
                    if (letrasIdentificadas[i] == null)
                    {                       
                        todasLetrasIdentificadas = false;
                    }
                }
                if (todasLetrasIdentificadas)
                {
                    Console.Clear();
                    Console.WriteLine(palavraEscolhida.ToUpper()) ;
                    Thread.Sleep(2000);
                    Console.WriteLine("Parabéns, você conseguiu!");
                    jogoEmAndamento = false;                    
                };

            }
            while (jogoEmAndamento);

            Console.WriteLine("Pressiona qualquer tecla para encerrar o jogo");
            Console.ReadKey();
        }
    }
}
