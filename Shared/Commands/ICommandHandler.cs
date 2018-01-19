namespace Shared.Commands
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        ICommandResult Handler(T command);
    }
}