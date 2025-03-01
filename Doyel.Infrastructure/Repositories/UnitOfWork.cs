using Doyel.Domain.Interfaces;
using Doyel.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Doyel.Infrastructure.Repositories;

class UnitOfWork : IUnitOfWork
{
	private readonly ApplicationDbContext _context;
	private readonly Dictionary<Type, object> _repositories;
	private bool _disposed;
	public UnitOfWork(ApplicationDbContext context)
	{
		_context = context;
		_repositories = new Dictionary<Type, object>();
	}
	public void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}

	public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
	{
		var type = typeof(TEntity);

		if (!_repositories.ContainsKey(type))
		{
			_repositories[type] = new GenericRepository<TEntity>(_context);
		}

		return (IGenericRepository<TEntity>)_repositories[type];
	}

	public async Task<int> SaveChangesAsync()
	{
		return await _context.SaveChangesAsync();
	}

	protected virtual void Dispose(bool disposing)
	{
		if (!_disposed && disposing)
		{
			_context.Dispose();
		}
		_disposed = true;
	}
}
