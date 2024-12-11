namespace BatalhaDeMonstros
{
    public static class MonstroFactory
    {
        public static Monstro CriarMonstro(string tipo)
        {
            if (tipo.ToLower() == "dragao")
                return new Dragao();
            if (tipo.ToLower() == "zumbi")
                return new Zumbi();
            if (tipo.ToLower() == "robo")
                return new Robo();

            throw new Exception("Tipo de monstro desconhecido.");
        }
    }
}
