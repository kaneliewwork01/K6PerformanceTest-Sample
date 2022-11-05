using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace K6APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        [HttpGet("login")]
        public string Login([FromQuery] string input)
        {
            var reverse = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse.Append(input[i]);
            }
            Thread.Sleep(500);
            return reverse.ToString();
        }

        [HttpGet("getProducts")]
        public string GetProducts([FromQuery] string input)
        {
            var random = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                random.Append(input[i]);
            }
            Thread.Sleep(500);
            return random.ToString();
        }

        [HttpGet("addProductToCart")]
        public string AddProductToCart([FromQuery] string input)
        {
            var random = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                random.Append(input[i]);
            }
            Thread.Sleep(500);
            return random.ToString();
        }

        [HttpGet("checkout")]
        public string Checkout([FromQuery] string input)
        {
            var random = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                random.Append(input[i]);
            }
            Thread.Sleep(500);
            return random.ToString();
        }

        [HttpGet("payment")]
        public string Payment([FromQuery] string input)
        {
            var random = new StringBuilder(input.Length);
            for (int i = input.Length - 1; i >= 0; i--)
            {
                random.Append(input[i]);
            }
            Thread.Sleep(500);
            return random.ToString();
        }
    }
}
