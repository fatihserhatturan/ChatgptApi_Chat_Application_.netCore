using Chat_AI_API.Models;
using Microsoft.AspNetCore.Mvc;
using ChatGPT.Net;
using Azure.Core;

namespace Chat_AI_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
      

        // POST: api/sample
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Message message)
        {

            var openAiKey = "";
            var openai = new ChatGpt(openAiKey);

            var answer = await openai.Ask($"Bu soruya arkadaşça bir cevap Ver: {message.Text}");

            if (answer == null)
            {
                return NotFound("unable to call chat gpt");
            }

            Console.WriteLine(answer);
            return Ok();
        }


    }
}
