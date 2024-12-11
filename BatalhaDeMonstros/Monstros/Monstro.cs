public abstract class Monstro
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public int ForcaAtaque { get; set; }
    public int Defesa { get; set; }
    public virtual string UsarHabilidadeEspecial(Monstro oponente)
    {
        return $"{Nome} tentou usar uma habilidade especial, mas nada aconteceu.";
    }
}
