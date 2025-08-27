using System;

namespace Pizzaria
{
    public static class Register
    {
        public static void Show()
        {
            Console.Write("Nome do cliente: ");
            var name = Console.ReadLine();            
            Table();
            
        }
        public static void Table()
        {
            Console.Write("A conta será dividida para quantas pessoas? ");
            var table = Console.ReadLine();
            if (int.TryParse(table, out int number))
            {
                Console.WriteLine("Abrindo o menu...");                
                Thread.Sleep(1000);
                Console.WriteLine("------------------------------");
                Menu.Show(number);
            }
            else
            {
                Console.WriteLine("Formato inválido! Tente novamente.");
                Table();
            }
        }
    }
}