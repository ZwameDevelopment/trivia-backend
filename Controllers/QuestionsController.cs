using Microsoft.AspNet.Mvc;
using Newtonsoft.Json;
using System.Linq;
using TriviaBackend.Models;

namespace TriviaBackend.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class QuestionsController : Controller
    {
        // GET: api/questions
        [HttpGet]
        public string Get()
        {
            return JsonConvert.SerializeObject(Question.questionSeed());
        }

        // GET api/questions/5
        [HttpGet("{id}")]
        public string Get(int? id = null)
        {   
            return JsonConvert
            .SerializeObject(
                Question.questionSeed().Where(q => q.QuestionId == id)
            );
        }
        
        // GET api/questions/topic/1
        [HttpGet("topic/{topic}")]
        public string getByTopic(Question.Topics topic){
            return JsonConvert
            .SerializeObject
            (
              Question.questionSeed().Where(q => q.Topic == topic)  
            );
        }
        
        // GET api/questions/difficulty/1
        [HttpGet("dificulty/{dificulty}")]
        public string getByDificulty(Question.Dificulties dificulty){
            return JsonConvert
            .SerializeObject
            (
              Question.questionSeed().Where(q => q.Dificulty == dificulty)  
            );
        }

//          // POST api/values
//          [HttpPost]  
//          public void Post([FromBody]string value)
//          {
//          }
//  
//          // PUT api/values/5
//          [HttpPut("{id}")]
//          public void Put(int id, [FromBody]string value)
//          {
//          }
//  
//          // DELETE api/values/5
//          [HttpDelete("{id}")]
//          public void Delete(int id)
//          {
//          }
    }
}
