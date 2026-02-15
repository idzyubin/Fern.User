using Fern.Common.Types;

namespace Fern.Common.Contracts;

public interface IEventApplier<in TEvent, out TDomainModel>
    where TDomainModel : BaseDomainModel
    where TEvent : BaseEvent
{
    TDomainModel Apply(TEvent @event);
}