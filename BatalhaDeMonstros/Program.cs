using System;

namespace BatalhaDeMonstros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameController gameController = new GameController();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1. Novo Jogo");
            Console.WriteLine("2. Sair");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                gameController.IniciarJogo();
            }
            else
            {
                Console.WriteLine("Saindo do jogo...");
            }
        }
    }

}
