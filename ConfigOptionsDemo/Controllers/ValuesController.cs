using ConfigOptionsDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace ConfigOptionsDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase 
    {
        private readonly MongoContext mongoContext;
        private readonly SqlContext sqlContext;
        public ValuesController(MongoContext mongoContext, SqlContext sqlContext)
        {
            this.mongoContext = mongoContext;
            this.sqlContext = sqlContext;
        }

        [HttpGet("InsertMongo")]
        public IActionResult InsertMongo() 
        {
            mongoContext.InsertMongo();

            return Ok();
        }

        [HttpGet("InsertSql")]
        public IActionResult InsertSql() 
        {
            sqlContext.InsertSql();

            return Ok();
        }

    }
}
