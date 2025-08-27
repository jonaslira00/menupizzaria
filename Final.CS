using System;

namespace Pizzaria
{
    public static class Final
    {
        public static void Show(Double total, int number)
        {
            Console.WriteLine($"O valor total do pedido foi de R${total} dividido para {number} fica de {total / number}");
        }
    }
}