using System;

namespace Pizzaria
{
    public static class Menu
    {
        public static void Show(int number)
        {
            Pizzas[] itens = new Pizzas[]
            {
                new Pizzas ("1. Margherita", 35.00),
                new Pizzas ("2. Calabresa", 40.00),
                new Pizzas ("3. Quatro Queijos", 45.00),
                new Pizzas ("4. Portuguesa", 42.00),
                new Pizzas ("5. Frango com Catupiry", 48.00),
                new Pizzas ("6. Pepperoni", 50.00),
                new Pizzas ("7. Vegetariana", 45.00),
                new Pizzas ("8. Napolitana", 38.00),
                new Pizzas ("9. Bacon com Milho", 47.00),
                new Pizzas ("10. Especial da Casa", 55.00),
                new Pizzas ("11. Refrigerantes (Coca-Cola, Guaraná, Fanta, etc.)", 8.00),
                new Pizzas ("12. Água mineral", 5.00),
                new Pizzas ("13. Sucos naturais", 10.00),
            };

            foreach (var pizza in itens)
            {
                pizza.Info();        
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            double total = Order(itens);
            Final.Show(total, number);         
        }

        static double Order(Pizzas[] itens)
        {
            
            double total = 0;
            while (true)
            {
                Console.Write("Digite o pedido (0 para concluir o pedido): ");
                var order = Console.ReadLine();
                if (int.TryParse(order, out int number))
                {
                    if (number < 0 || number > 13)
                    {
                        Console.WriteLine("Item não consta no menu, tente novamente.");
                        continue;
                    }
                    else if (number == 0)
                    {
                        break;
                    }
                    for (var i = 0; i < itens.Length; i++)
                    {
                        if (number == i + 1)
                        {
                            total += itens[number - 1].Price;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Número invalido, tente novamente.");
                    Order(itens);
                }
            }
            return total;
        }
    }

    struct Pizzas
    {
        public string Name;
        public double Price;

        public Pizzas(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void Info()
        {
            Console.Write("{0} ", this.Name);
            Console.WriteLine("R${0}", this.Price);
        }
    }

    
    
}