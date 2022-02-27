using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return Content("<h1>Hello World</h1>", "text/html");
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public IActionResult GoodBye()
        {
            return Content("<h1>Goodbye</h1>", "text/html");
        }
    }
}