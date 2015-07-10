using System.Collections.Generic;

namespace ExamWebAPI.Entities
{
    public class Question : MongoEntity
    {
        public Question()
        {
            Options = new List<string>();
            Description = new List<string>();
        }

        public int No { get; set; }
        public string Title { get; set; }
        public List<string> Options { get; set; }
        public List<string> Description { get; set; }
        public string Answer { get; set; }
    }
}
