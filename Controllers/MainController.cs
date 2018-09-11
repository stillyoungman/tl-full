using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tour_logistic.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // MainController(){

        // }

        [HttpGet]
        public ActionResult<object> Returner(){
            return new { mess = "it works!!!"};
        }

        [HttpPost]
        public void SaveObject([FromBody] Object content){
            Console.WriteLine("#####------\nReceived\n------#####");
        }
    }
}
