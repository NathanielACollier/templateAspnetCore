using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace templateAspnetCore.Controllers{
    public class GeneralController : Controller{

        [HttpGet,Route("api/General/HelloWorld")]
        public string GetHelloWorld(){
            return "Hello World!";
        }

    }

    
}