using MongoDB.Driver;
using ExamWebAPI.Entities;

namespace ExamWebAPI.Services
{

    public class ConnectionService<T> where T : IMongoEntity
    {
        public IMongoCollection<T> MongoCollection { get; private set; }

        public ConnectionService()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            var mongoClient = new MongoClient(settings);
            var db = mongoClient.GetDatabase("ITILQuestions");

            MongoCollection = db.GetCollection<T>(typeof(T).Name.ToLower() + "s");
        }
    }
}