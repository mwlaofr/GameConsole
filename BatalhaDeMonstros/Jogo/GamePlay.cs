using System;

namespace BatalhaDeMonstros
{
    public class GamePlay
{
    private Atacar atacar;
    private Defender defender;
    private ScoreManager scoreManager;

    public GamePlay()
    {
        atacar = new Atacar();
        defender = new Defender();
        scoreManager = new ScoreManager();
    }

    public void IniciarBatalha(Monstro jogador1, Monstro jogador2)
    {
        // Adiciona os jogadores ao ScoreManager
        scoreManager.AdicionarJogador(jogador1.Nome);
        scoreManager.AdicionarJogador(jogador2.Nome);

        while (jogador1.Vida > 0 && jogador2.Vida > 0)
        {
            // Turno do Jogador 1
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"**Turno de {jogador1.Nome}!**");
            Console.ForegroundColor = ConsoleColor.White;
            ExibirStatus(jogador1, jogador2);
            int acaoJogador1 = ObterAcaoDoJogador();
            string resultadoJogador1 = ExecutarAcao(jogador1, jogador2, acaoJogador1);
            Console.WriteLine(resultadoJogador1);

            if (acaoJogador1 == 1) // Exemplo: ataque bem-sucedido
            {
                scoreManager.AdicionarPontos(jogador1.Nome, 10);
            }

            if (jogador2.Vida <= 0)
            {
                ExibirMensagemDeVitoria(jogador1, jogador2);
                break;
            }

            Console.WriteLine(); // Linha em branco para separar os turnos

            // Turno do Jogador 2
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"**Turno de {jogador2.Nome}!**");
            Console.ForegroundColor = ConsoleColor.White;
            ExibirStatus(jogador1, jogador2);
            int acaoJogador2 = ObterAcaoDoJogador();
            string resultadoJogador2 = ExecutarAcao(jogador2, jogador1, acaoJogador2);
            Console.WriteLine(resultadoJogador2);

            if (acaoJogador2 == 1) // Exemplo: ataque bem-sucedido
            {
                scoreManager.AdicionarPontos(jogador2.Nome, 10);
            }

            if (jogador1.Vida <= 0)
            {
                ExibirMensagemDeVitoria(jogador2, jogador1);
                break;
            }

            Console.WriteLine(); // Linha em branco para separar os turnos
        }

        // Exibe todas as pontuações no final da batalha
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("A batalha acabou!");
        scoreManager.ExibirTodasPontuacoes();
        Console.ForegroundColor = ConsoleColor.White;
    }

    private void ExibirStatus(Monstro jogador, Monstro oponente)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{jogador.Nome} tem {jogador.Vida} de vida.");
        Console.WriteLine($"{oponente.Nome} tem {oponente.Vida} de vida.");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

    private int ObterAcaoDoJogador()
    {
        int acao;
        do
        {
            Console.WriteLine("Escolha sua ação:");
            Console.WriteLine("1. Atacar");
            Console.WriteLine("2. Defender");
            Console.WriteLine("3. Usar Habilidade Especial");

            string input = Console.ReadLine();

            if (int.TryParse(input, out acao) && acao >= 1 && acao <= 3)
            {
                return acao;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Entrada inválida! Escolha um número entre 1 e 3.");
            Console.ForegroundColor = ConsoleColor.White;
        } while (true);
    }

    private string ExecutarAcao(Monstro jogador, Monstro oponente, int acao)
    {
        string resultado = string.Empty;

        switch (acao)
        {
            case 1: // Atacar
                Console.ForegroundColor = ConsoleColor.Green;
                resultado = atacar.Executar(jogador, oponente);
                break;
            case 2: // Defender
                Console.ForegroundColor = ConsoleColor.Blue;
                resultado = "Defesa ativada!"; // Lógica de defesa placeholder
                break;
            case 3: // Habilidade Especial
                Console.ForegroundColor = ConsoleColor.Yellow;
                resultado = jogador.UsarHabilidadeEspecial(oponente);
                break;
            default:
                Console.ForegroundColor = ConsoleColor.White;
                resultado = "Ação inválida! Turno perdido.";
                break;
        }

        Console.ForegroundColor = ConsoleColor.White;
        return resultado;
    }

    private void ExibirMensagemDeVitoria(Monstro vencedor, Monstro derrotado)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{derrotado.Nome} foi derrotado! {vencedor.Nome} venceu!");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

}
