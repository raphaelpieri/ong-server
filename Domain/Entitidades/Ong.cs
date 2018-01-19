namespace Domain.Entitidades
{
    public class Ong
    {
        public Ong(string nome, string slogan, string site, bool ativo)
        {
            Nome = nome;
            Slogan = slogan;
            Site = site;
            Ativo = ativo;
        }

        public string Nome { get; private set; }
        public string Slogan { get; private set; }
        public string Site { get; private set; }
        public bool Ativo { get; private set; }
    }
}