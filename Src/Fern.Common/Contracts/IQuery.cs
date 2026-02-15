namespace Fern.Common.Contracts;

public interface ISingleQuery<in TQuery, TResult>
{
    Task<TResult?> HandleAsync(TQuery query, CancellationToken cancellationToken);
}

public interface IBatchQuery<in TQuery, TResult>
{
    Task<TResult[]> HandleAsync(TQuery query, CancellationToken cancellationToken);
}