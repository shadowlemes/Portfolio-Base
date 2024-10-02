using System;
using JogoAdivinhacao;
using CronometroOpcao;
using JogoForca;

namespace MainMenu
{
    public class Program
    {
        public static void Main()
        {
            Inicio();
        }

        static void Transicao()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Redirecionando...");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
        public static void Inicio()
        {
            while (true)
            {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("╔════════════════════╗");
            Console.WriteLine("║     Portfólio      ║");
            Console.WriteLine("╚════════════════════╝\n");
            Console.ResetColor();
            OpcoesMenu();
        }
        

        
        static void OpcoesMenu()
        {
   
            Console.WriteLine("1 - Jogo Adivinhação");
            Console.WriteLine("2 - Cronômetro");
            Console.WriteLine("3 - Forca");
            Console.WriteLine("4 - ToDo Lista");
            Console.WriteLine("5 - Conversor de Temperatura");
            Console.WriteLine("0 - Sair");

                try
                {
                    int escolha = int.Parse(Console.ReadLine()!);

                    switch (escolha)
                    {
                        case 1:
                            Transicao();
                            JogoAdivinhacao.Program.MenuJogo();
                            break;

                        case 2:
                            Transicao();
                            CronometroOpcao.Program.Inicio();
                            break;
                        case 3: Transicao();
                            JogoForca.Program.Inicio();
                            break;
                        case 4: Console.WriteLine("Em construção"); break;
                        case 5: Console.WriteLine("Em construção"); break;
                        default: Console.WriteLine("Insira uma opção válida"); break;
                    }
                }

                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escolha uma opção disponível");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                    Console.Clear();                    
                }
            }
            
        }
    }
}