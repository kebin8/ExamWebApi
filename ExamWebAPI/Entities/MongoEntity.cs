using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExamWebAPI.Entities
{
    public class MongoEntity : IMongoEntity
    {
        [BsonId]
        public ObjectId Id { get; set; }
    }
}