using System.Collections.Generic;
using System.Threading.Tasks;
using ExamWebAPI.Entities;

namespace ExamWebAPI.Services
{
    public interface IEntityService<T> where T : IMongoEntity
    {
        bool Save(T entity);
        Task<List<T>> GetList(int skip, int limit);
        Task<T> GetById(string Id);
    }
}