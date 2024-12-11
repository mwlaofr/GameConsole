namespace BatalhaDeMonstros
{
    // Define o contrato para ações de combate.
    public interface IAcaoDeCombate
    {
        // Executa a ação entre atacante e defensor.
        string Executar(Monstro atacante, Monstro defensor);
    }
}
