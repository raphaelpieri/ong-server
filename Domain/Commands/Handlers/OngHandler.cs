using System;
using Domain.Commands.Inputs;
using Domain.Commands.Result;
using Domain.Entitidades;
using Shared.Commands;

namespace Domain.Commands.Handlers
{
    public class OngHandler : ICommandHandler<OngInputCommand> 
    {
        public ICommandResult Handler(OngInputCommand command)
        {
            var ong = new Ong(command.Nome, command.Slogan, command.Site, command.Ativo);
            var ativo = ong.Ativo ? " checked=\"true\"" : "";
            var url = $"<tr>" +
                      $"<td>{ong.Nome}</td>" +
                      $"<td>{ong.Slogan}</td>" +
                      $"<td>{ong.Site}</td>" +
                      $"<td><input type=\"checkbox\"{ativo}>Ativo</td>" +
                      "<td>"+
                      "<button onclick=\"atualizarOng(this)\">Alterar</button> | "+
                      "<button onclick=\"excluirOng(this)\">Excluir</button></td>" +
                      "</tr>";
            
            
            return new OngResultCommand(url);
        }
    }
}

