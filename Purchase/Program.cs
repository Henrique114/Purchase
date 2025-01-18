using System;
using System.Diagnostics;

namespace Purchase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome:");
            string nome_usuario = Console.ReadLine();
            Console.WriteLine("Insira seu saldo:");
            int saldo = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Olá, {nome_usuario}.\n Seu saldo é de: R${saldo}");

            string produto = "chapeu";
            float valor_produto = 150.5f;


            bool cond = false;
            while (cond == false)
            {
                Console.WriteLine("Digite o numero do item que deseja comprar. \n Item 1: \n Chapeu \n Preço: R$ 150,50\n \n Item 2:\n Produto Indisponivel!");
                string item = Console.ReadLine();
                if (item == "1" || item == "2")
                {
                    cond = true;
                   int item_n = Int32.Parse(item);   
                    switch (item_n)
                    {
                        case 1:
                            Console.WriteLine(" Você está comprando 1 (um) chapeu no valor de R$150,50.\n Confirmar compra?");
                            break;

                        case 2:
                            Console.WriteLine("Sem produto no estoque!");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                    cond = false;
                }
            }
        }
    }
}
