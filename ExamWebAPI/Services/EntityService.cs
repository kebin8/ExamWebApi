using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExamWebAPI.Entities;

namespace ExamWebAPI.Services
{
    public abstract class EntityService<T> : IEntityService<T> where T : IMongoEntity
    {
        protected readonly ConnectionService<T> connectionService;
        public virtual async Task<T> GetById(string Id)
        {
            var filter = Builders<T>.Filter.Eq("Id", new ObjectId(Id));
            return await this.connectionService.MongoCollection.Find<T>(filter).FirstOrDefaultAsync();
        }

        public virtual async Task<List<T>> GetList(int skip = -1, int limit = -1)
        {
            var result = this.connectionService.MongoCollection.Find<T>(new BsonDocument());
            if (skip != -1)
                result = result.Skip(skip);
            if (limit != -1)
                result.Limit(limit);
            return await result.ToListAsync();
        }

        public virtual bool Save(T entity)
        {
            throw new NotImplementedException();
        }

        public EntityService()
        {
            connectionService = new ConnectionService<T>();
        }
    }
}