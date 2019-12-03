using Microsoft.Extensions.Options;
using MongoDB.Driver;
using SectorOrgange.API.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SectorOrange.API.DAL
{
    public interface IBaseMongoRepository<T>
    {
        Task Add(T item);
        Task<List<T>> GetAll();
    }

    public class BaseMongoRepository<T> : IBaseMongoRepository<T>
    {
        protected BaseMongoContext<T> _context;

        public BaseMongoRepository()
        {
        }

        public async Task Add(T item)
        {
            try
            {
                await _context.Entity.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return (await _context.Entity.FindAsync<T>(Builders<T>.Filter.Empty)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
