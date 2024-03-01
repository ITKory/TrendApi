using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TrendApi.Models;

namespace TrendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrendController(IConfiguration config) : ControllerBase
    {
 

        [HttpGet]
        public IResult Ping()
        {
            return TypedResults.Ok("pong");
        }        

        [HttpGet("total-chats-report")]
        public IResult TotalChats()
        {
            TotalChats totalChats = Reader<TotalChats>("Data/total_chats.json");
            return TypedResults.Ok(totalChats);
        } 
        [HttpGet("duration-report")]
        public IResult Duration()
        {
            Duration totalChats = Reader<Duration>("Data/duration.json");
            return TypedResults.Ok(totalChats);
        }
        [HttpGet("ratings-report")]
        public IResult Ratings()
        {
            Rating totalChats = Reader<Rating>("Data/ratings.json");
            return TypedResults.Ok(totalChats);
        }
        [HttpGet("response-time-report")]
        public IResult TimeReport()
        {
            ResponseTime totalChats = Reader<ResponseTime>("Data/response_time.json");
            return TypedResults.Ok(totalChats);
        }
        [HttpGet("tags-report")]
        public IResult Tags()
        {
            Tags totalChats = Reader<Tags>("Data/tags.json");
            return TypedResults.Ok(totalChats);
        }

        private static T Reader<T>(string fileName)
        {
            using (StreamReader r = new(fileName))
            {
                string json = r.ReadToEnd();
              return  JsonConvert.DeserializeObject<T>(json);
            }
              
        }
    }
}
