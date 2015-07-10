using MongoDB.Bson.Serialization.Attributes;
using System;

namespace ExamWebAPI.Entities
{
    public class Examination : MongoEntity
    {
        public Tester Tester { get; set; }
        public int Score { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime TestTime { get; set; }
    }
}