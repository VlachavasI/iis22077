using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace YpalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YpalController : ControllerBase
    {
        private readonly List<Ypal> _ypals = new List<Ypal>
        {
            new Ypal { Id = 1, Name = "Υπάλληλος 1" },
            new Ypal { Id = 2, Name = "Υπάλληλος 2" },
            new Ypal { Id = 3, Name = "Υπάλληλος 3" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Ypal>> GetAllYpal()
        {
            return Ok(_ypals);
        }

        [HttpGet("{id}")]
        public ActionResult<Ypal> GetYpal(int id)
        {
            var ypal = _ypals.Find(x => x.Id == id);

            if (ypal == null)
            {
                return NotFound();
            }

            return Ok(ypal);
        }

        [HttpPost]
        public ActionResult<Ypal> UpdateYpal([FromBody] Ypal ypal)
        {
            if (ypal == null)
            {
                return BadRequest();
            }

            var existingYpal = _ypals.Find(x => x.Id == ypal.Id);

            if (existingYpal == null)
            {
                return NotFound();
            }

            existingYpal.Name = ypal.Name;

            return Ok(existingYpal);
        }
    }

}