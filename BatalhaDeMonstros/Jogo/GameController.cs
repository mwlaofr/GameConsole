using System;

namespace BatalhaDeMonstros
{
    public class GameController
    {
        private Monstro jogador;
        private Monstro oponente;
        private GamePlay gameplay;
        private ScoreManager scoreManager;

        public GameController()
        {
            gameplay = new GamePlay();
            scoreManager = new ScoreManager();
        }

        public void IniciarJogo()
        {
            // Escolha do jogador
            Console.WriteLine("Escolha seu monstro (Dragão, Zumbi, Robo):");
            jogador = EscolherMonstro();

            // Escolha do oponente
            Console.WriteLine("Escolha o monstro do oponente (Dragão, Zumbi, Robo):");
            oponente = EscolherMonstro();

            // Exibir informações iniciais
            Console.Clear();
            Console.WriteLine($"Jogador 1: {jogador.Nome}, Vida: {jogador.Vida}");
            Console.WriteLine($"Jogador 2: {oponente.Nome}, Vida: {oponente.Vida}");
            Console.WriteLine();

            // Iniciar a batalha
            gameplay.IniciarBatalha(jogador, oponente);
        }

        private Monstro EscolherMonstro()
        {
            while (true)
            {
                try
                {
                    string tipo = Console.ReadLine();
                    return MonstroFactory.CriarMonstro(tipo);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tipo de monstro inválido. Tente novamente (Dragão, Zumbi, Robo):");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
