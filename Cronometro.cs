using System;
using MainMenu;

namespace CronometroOpcao
{
    public class Program
    {
        public static void Inicio()
        {
            Console.WriteLine("Insira o valor para Cronometrar: ");

            try
            {
                int contagem = int.Parse(Console.ReadLine()!);
                while (true)

                {
                    for (int i = contagem; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                        Thread.Sleep(1000);
                        Console.Clear();
                        if (i == 0)
                        {
                            Console.WriteLine("O tempo acabou");
                            Thread.Sleep(2000);
                            Console.Clear();
                            MainMenu.Program.Main();
                        }
                        if (i < 11)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Insira um valor numerico");
                Console.ResetColor();
                Thread.Sleep(3000);
                Inicio();
                
            }
        }
    }
}
            
