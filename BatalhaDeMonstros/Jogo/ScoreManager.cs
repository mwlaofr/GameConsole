namespace BatalhaDeMonstros
{
    public class ScoreManager
    {
        private Dictionary<string, int> pontuacoes;

        public ScoreManager()
        {
            pontuacoes = new Dictionary<string, int>();
        }

        public void AdicionarJogador(string nomeJogador)
        {
            if (!pontuacoes.ContainsKey(nomeJogador))
            {
                pontuacoes[nomeJogador] = 0;
            }
        }

        public void AdicionarPontos(string nomeJogador, int pontosGanhados)
        {
            if (pontuacoes.ContainsKey(nomeJogador))
            {
                pontuacoes[nomeJogador] += pontosGanhados;
                Console.WriteLine($"{nomeJogador} ganhou {pontosGanhados} pontos! Total: {pontuacoes[nomeJogador]}");
            }
        }

        public void ExibirPontuacao(string nomeJogador)
        {
            if (pontuacoes.ContainsKey(nomeJogador))
            {
                Console.WriteLine($"Pontuação de {nomeJogador}: {pontuacoes[nomeJogador]}");
            }
        }

        public void ExibirTodasPontuacoes()
        {
            Console.WriteLine("Pontuações finais:");
            foreach (var jogador in pontuacoes)
            {
                Console.WriteLine($"{jogador.Key}: {jogador.Value} pontos");
            }
        }
    }
}
