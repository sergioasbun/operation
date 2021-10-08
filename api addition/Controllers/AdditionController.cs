using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_addition.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdditionController : ControllerBase
    {
        [HttpGet]
        [Route("Add")]
        public int Add(int NumA, int NumB)
        {
        return (NumA + NumB);
        }
        [HttpGet]
        [Route("Mult")]
        public int Mult(int NumA, int NumB)
        {
            return (NumA * NumB);
        }

    }
}
