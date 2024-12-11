public class Dragao : Monstro
{
    public Dragao()
    {
        Nome = "Dragão";
        Vida = 120;
        ForcaAtaque = 30;
        Defesa = 8; // Defesa padrão
    }

    public override string UsarHabilidadeEspecial(Monstro alvo)
    {
        // Habilidade do Dragão: Ataque de Fogo
        int danoFogo = new Random().Next(20, 40);
        alvo.Vida -= danoFogo;
        return $"{Nome} usou Habilidade Especial: Ataque de Fogo! Causando {danoFogo} de dano ao {alvo.Nome}.";
    }
}