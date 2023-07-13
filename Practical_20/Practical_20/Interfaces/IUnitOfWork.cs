﻿namespace Practical_20.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

		Task SaveChangesAsync();
	}
}
