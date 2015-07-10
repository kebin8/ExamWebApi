using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExamWebAPI.Entities;
using ExamWebAPI.Services;
using System.Threading.Tasks;
using System.Web.Http.Results;

namespace ExamWebAPI.Controllers
{
    public class QuestionController : ApiController
    {
        QuestionnaireService qs = new QuestionnaireService();
        // GET: api/Question
        public async Task<JsonResult<List<Question>>> Get(bool random = false, int limit = -1, int skip = 0)
        {
            List<Question> result;
            if (random == true)
            {
                limit = limit == -1 ? 40 : limit;
                result = await qs.GetRandomList(limit);
            }
            else
            {
                result = await qs.GetList(skip, limit);
            }
            return Json(result);
        }

        // GET: api/Question/5
        public async Task<JsonResult<Question>> Get(string id)
        {
            var result = await qs.GetById(id);
            return Json(result);
        }

        // POST: api/Question
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Question/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Question/5
        public void Delete(int id)
        {
        }
    }
}
