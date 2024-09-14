using System;
using System.ComponentModel.Design;
using MainMenu;

namespace JogoAdivinhacao
{
    public class Program
    {
        static int vidas = 3;
        static Random aleatorio = new Random();
        
        public static void MenuJogo()
        {
            Jogo();
        }

        static void GameOver()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Não restaram mais vidas\nGame over!");
            Console.ResetColor();
            Thread.Sleep(3000);
            Console.Clear();
            MainMenu.Program.Main();
        }

        public static void Jogo()
        {
            int numeroAleatorio = aleatorio.Next(1, 11);

            while (true)
            {
                Console.WriteLine($"Vidas {vidas}\nAdivinhe o número aleatório:\n");
                try
                {
                    if (vidas == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Última chance!\n");
                        Console.ResetColor();
                    }

                    int tentativa = int.Parse(Console.ReadLine()!);

                    if (vidas == 1)
                    {
                        GameOver();
                    }

                    if (tentativa > numeroAleatorio)
                    {
                        vidas--;
                        Console.WriteLine("O número aleatório é maior que o inserido.\nTente novamente\n\n");
                    }
                    else if (tentativa < numeroAleatorio)
                    {
                        vidas--;
                        Console.WriteLine("O número aleatório é menor que o inserido.\nTente novamente\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"Parabéns você acertou, restaram {vidas} vidas.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        MainMenu.Program.Main();                        
                    }

                    Thread.Sleep(2000);
                    Console.Clear();
                }
                catch (FormatException )
                {
                    Console.Clear() ;
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"Tente um valor númerico de 1 até 10");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}