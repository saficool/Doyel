﻿using System.Linq.Expressions;

namespace Doyel.Domain.Interfaces;

public interface IGenericRepository<T> where T : class
{
	Task<T?> GetByIdAsync(string id);
	Task<IEnumerable<T>> GetAllAsync();
	Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);
	Task<T> AddAsync(T entity);
	Task UpdateAsync(T entity);
	Task DeleteAsync(T entity);
	Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate);
}
