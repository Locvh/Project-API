﻿using Project_API.Models;
using System;
using System.Linq;
using System.Threading.Tasks;


namespace UnitOfWorkPattern.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly CarRentalContext CarRentalContext;

        public Repository(CarRentalContext carRentalContext)
        {
            CarRentalContext = carRentalContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return CarRentalContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                await CarRentalContext.AddAsync(entity);
                await CarRentalContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                CarRentalContext.Update(entity);
                await CarRentalContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }
    }
}