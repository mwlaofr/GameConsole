public class Zumbi : Monstro
{
    public Zumbi()
    {
        Nome = "Zumbi";
        Vida = 80;
        ForcaAtaque = 20;
        Defesa = 10; // Defesa padrão
    }

    public override string UsarHabilidadeEspecial(Monstro alvo)
    {
        // Habilidade do Zumbi: Cura
        int cura = new Random().Next(10, 20);
        Vida += cura;
        return $"{Nome} usou Habilidade Especial: Cura! {cura} de vida recuperados.";
    }
}