using Shared.Commands;

namespace Domain.Commands.Inputs
{
    public class OngInputCommand : ICommand
    {
        public string Nome { get; set; }
        public string Slogan { get; set; }
        public string Site { get; set; }
        public bool Ativo { get; set; }
    }
}