using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamWebAPI.Entities;

namespace ExamWebAPI.Services
{
    public class QuestionnaireService : EntityService<Question>
    {
        public async Task<List<Question>> GetRandomList(int number)
        {
            var dataset = await this.GetList();
            var array = this.GetRandomArray(number, dataset.Count);
            var result = from b in array
                    from q in dataset
                    where b == q.No
                    select q;
            return result.ToList();
        }

        private List<int> GetRandomArray(int seed, int total)
        {
            Random rd = new Random(total - 1);
            long tick = DateTime.Now.Ticks;
            Random ran = new Random((int)(tick & 0xffffffffL) | (int)(tick >> 32));

            List<int> result = new List<int>();
            while (result.Count < seed)
            {
                var num = ran.Next(total - 1);
                if (!result.Contains(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }
    }
}