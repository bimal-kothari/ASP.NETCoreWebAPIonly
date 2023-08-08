using ASP.NETCoreWebAPI_only.Domain.Entities;

namespace ASP.NETCoreWebAPI_only.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
