namespace BatalhaDeMonstros
{
    public class Defender
    {
        public string Executar(Monstro defensor, int danoRecebido)
        {
            if (danoRecebido > 0)
            {
                // Calcula o dano bloqueado com base na defesa do monstro
                int danoBloqueado = Math.Min(defensor.Defesa, danoRecebido);
                // Reduz a vida do defensor com o dano não bloqueado
                int danoFinal = danoRecebido - danoBloqueado;
                defensor.Vida -= danoFinal;

                return $"{defensor.Nome} defendeu e bloqueou {danoBloqueado} de dano! {defensor.Nome} sofreu {danoFinal} de dano.";
            }
            else
            {
                return $"{defensor.Nome} está se preparando para defender!";
            }
        }
    }
}