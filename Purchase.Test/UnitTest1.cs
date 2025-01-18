namespace Purchase.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Console.WriteLine("Insira seu nome:");
            var nomeUsuario = Console.ReadLine();
            Console.WriteLine("Insira seu saldo:");
            double.TryParse(Console.ReadLine(), out double saldo);

            Console.WriteLine($"Olá, {nomeUsuario}.\n Seu saldo é de: R${saldo}");

            var produto = "chapeu";
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
                            Console.WriteLine("Você está comprando 1 (um) chapeu no valor de R$150,50.\n Confirmar compra?");
                            break;

                        case 2:
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