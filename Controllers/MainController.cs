using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tour_logistic.DataAccess;

namespace tour_logistic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoreController : ControllerBase
    {
        DbContext _context;
        public CoreController(RepositoryContext context){
            _context = context;
        }
        
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
