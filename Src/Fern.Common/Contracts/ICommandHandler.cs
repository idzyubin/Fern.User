using Fern.Common.Types;

namespace Fern.Common.Contracts;

public interface ICommandHandler<in TCommand> where TCommand : BaseCommand
{
    Task HandleAsync(TCommand command, CancellationToken cancellationToken);
}