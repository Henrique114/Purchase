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
            double.TryParse(Console.ReadLine(), out double saldo);

            Console.WriteLine($"Olá, {nome_usuario}.\n Seu saldo é de: R${saldo}");

            string produto = "chapeu";
            double valor_produto = 150.5d;
            var saldoAtual = 0d ;


            bool ehValidacaoItemSelecionado = true;
            while (ehValidacaoItemSelecionado == true)
            {
                //mostrar os produtos disponiveis
                Console.WriteLine($"Digite o numero do item que deseja comprar. \n Item 1: \n Chapeu \n Preço: R$ {valor_produto}\n \n Item 2:\n Produto Indisponivel!");

                // selecionar um produto
                var produtoSelecionado = Console.ReadLine();

                // verificar se o item selecionado é um item válido.
                if (produtoSelecionado == "1" || produtoSelecionado == "2")
                {
                    // verivificar qual produto selecionado
                    switch (produtoSelecionado)
                    {
                        case "1":
                            Console.WriteLine($"Você está comprando 1 (um) chapeu no valor de R${valor_produto}.\n Confirmar compra?");

                             //input para qual produto o usuario quer
                             //var produtoSelecionado = Console.ReadLine();
                             Console.WriteLine("Digite 'Sim' para confirmar ou 'Nao' para voltar.");
                             var valorDigitado = Console.ReadLine();
                             if (valorDigitado == "Sim")
                             {
                                 //enter -> continua o processo
                                 saldoAtual = saldo - valor_produto;
                                 Console.WriteLine("Compra finalizada!!");
                                 Console.WriteLine("1 - Chapeu");
                                 Console.WriteLine($"Valor da compra: R$ {valor_produto}.");
                                 Console.WriteLine($"Seu saldo atual é de:{saldoAtual}");
     
                                 //como saber o que sobrou do saldo do cliente
                                 //pega o salto
                                 //menos o valor do produto
                                 //salva isso numa variavel saldo atual
                                 // mostrar em tela a compra finalizada com informaçoes do produto
                                 // e saldo final
                                ehValidacaoItemSelecionado = false;

                            }
                            else if (valorDigitado == "Nao")
                             {
                                //retorna para a selecao do item da lista
                             }
                             else {
                                //tratamento para entrada invalida.
                                //informar que deve ser digitado "sim" ou "não".
                                Console.WriteLine("Opçao digitada invalida, tente novamente");
                             }
                            break;

                        case "2":
                            Console.WriteLine("Sem produto no estoque!");
                            break;
                    }
                }
                else 
                { 
                    Console.WriteLine("Opção invalida!");
                }
            }
        }
    }
}
