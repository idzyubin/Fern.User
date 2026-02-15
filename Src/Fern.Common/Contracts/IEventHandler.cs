using Fern.Common.Types;

namespace Fern.Common.Contracts;

public interface IEventHandler<in TEvent> where TEvent : BaseEvent
{
    Task HandleAsync(TEvent command, CancellationToken cancellationToken);
}
