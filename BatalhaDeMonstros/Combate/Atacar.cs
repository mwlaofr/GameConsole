namespace BatalhaDeMonstros
{
    public class Atacar
    {
        public string Executar(Monstro atacante, Monstro defensor)
        {
            Random random = new Random();
            int dano = random.Next(10, 20);
            defensor.Vida -= dano;

            return $"{atacante.Nome} atacou {defensor.Nome} e causou {dano} de dano!";
        }
    }
}