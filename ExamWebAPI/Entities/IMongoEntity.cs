using MongoDB.Bson;

namespace ExamWebAPI.Entities
{
    public interface IMongoEntity
    {
        ObjectId Id { get; set; }
    }
}
