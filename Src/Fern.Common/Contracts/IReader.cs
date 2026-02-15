namespace Fern.Common.Contracts;

public interface IReader<T>
{
    Task<T?> GetAsync(Guid id, CancellationToken cancellationToken);

    Task<T[]> GetAsync(ReaderContext context, CancellationToken cancellationToken);
}

public sealed record ReaderContext;
