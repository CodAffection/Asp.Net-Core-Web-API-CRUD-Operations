using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Greetings()
        {
            //if
            return "Hello there"; //200 , 
            //else
            return NoContent();
        }

        //Specific Type : int, boolean, string, new Class1()
        //IActionResult
        //ActionResult<T>


        // CRUD
        // Create - a new record - POST
        // Read - retrieve a single/ list of record(s) - GET
        // Update - modify an existing record - PUT
        // Delete - remove an existing record - DELETE

        // HTTP Verbs
        // GET
        // POST
        // PUT or PATCH
        // DELETE
    }
}
