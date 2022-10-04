using System;

namespace CarrinhoDeCompra
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("1 - Adicionar item ao carrinho\n");
            Console.WriteLine("2 - Remover item do carrinho\n");
            Console.WriteLine("3 - Listar itens do carrinho\n");
            Console.WriteLine("4 - Exibir valor total do carrinho\n");
            Console.WriteLine("5 - Cadastrar novo usuário\n");
            int option = Convert.ToInt32(Console.ReadLine());

            //switch (option)
            //{
            //    case 1:
            //        AdicionarItem();
            //        break;
            //    case 2:
            //        RemoverItem();
            //        break;
            //    case 3:
            //        ListarItens();
            //        break;
            //    case 4:
            //        ExibirValorTotal();
            //        break;
            //    case 5:
            //        CadastrarUsuario();
            //        break;
            //}
        }
    }
}
