using Doyel.Domain.Interfaces;
using Doyel.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Doyel.Infrastructure.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
	private readonly ApplicationDbContext _context;
	private readonly DbSet<T> _dbSet;
	public GenericRepository(ApplicationDbContext context)
	{
		_context = context;
		_dbSet = context.Set<T>();
	}
	public async Task<T> AddAsync(T entity)
	{
		await _dbSet.AddAsync(entity);
		return entity;
	}

	public Task DeleteAsync(T entity)
	{
		_dbSet.Remove(entity);
		return Task.CompletedTask;
	}

	public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
	{
		return await _dbSet.AnyAsync(predicate);
	}

	public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
	{
		return await _dbSet.Where(predicate).ToListAsync();
	}

	public async Task<IEnumerable<T>> GetAllAsync()
	{
		return await _dbSet.ToListAsync();
	}

	public async Task<T?> GetByIdAsync(string id)
	{
		return await _dbSet.FindAsync(id);
	}

	public Task UpdateAsync(T entity)
	{
		_dbSet.Attach(entity);
		_context.Entry(entity).State = EntityState.Modified;
		return Task.CompletedTask;
	}
}
