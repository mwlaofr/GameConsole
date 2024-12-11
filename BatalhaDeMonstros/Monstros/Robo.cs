public class Robo : Monstro
{
    public Robo()
    {
        Nome = "Robô";
        Vida = 100;
        ForcaAtaque = 25;
        Defesa = 5; // Defesa padrão
    }

    public override string UsarHabilidadeEspecial(Monstro alvo)
    {
        // Habilidade do Robô: Super Ataque
        int danoExtra = new Random().Next(20, 30);
        alvo.Vida -= danoExtra;
        return $"{Nome} usou Habilidade Especial: Super Raio Laser! Causando {danoExtra} de dano corrosivo.";
    }
}
