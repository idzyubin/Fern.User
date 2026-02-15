using Fern.Common.Types;

namespace Fern.Common.Contracts;

public interface IBus<in TEvent> where TEvent : BaseEvent
{
    Task SendEventAsync(TEvent[] events, CancellationToken cancellationToken);
}
