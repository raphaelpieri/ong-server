using Shared.Commands;

namespace Domain.Commands.Result
{
    public class OngResultCommand : ICommandResult
    {
        public OngResultCommand(string html)
        {
            Html = html;
        }

        public string Html { get; private set; }
    }
}