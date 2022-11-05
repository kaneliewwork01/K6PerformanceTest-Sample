using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace K6APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        [HttpGet("reverse")]
        public string Reverse([FromQuery] string input)
        {
            var reverse = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse.Append(input[i]);
            }
            Thread.Sleep(500);
            return reverse.ToString();
        }               
    }
}
