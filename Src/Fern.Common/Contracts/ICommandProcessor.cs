using Fern.Common.Types;

namespace Fern.Common.Contracts;

public interface ICommandProcessor<in TCommand, out TEvent>
    where TCommand : BaseCommand
    where TEvent : BaseEvent
{
    TEvent[] Process(TCommand command);
}
