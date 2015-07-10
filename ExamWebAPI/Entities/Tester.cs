using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ExamWebAPI.Entities
{
    public class Tester : MongoEntity
    {
        public string Name { get; set; }
        [BsonRepresentation(BsonType.String)]
        public Gender Gender { get; set; }
    }
}
