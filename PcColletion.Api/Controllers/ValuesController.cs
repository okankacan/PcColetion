using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PcColletion.InfraStructure.Model;
using PcColletion.InfraStructure.Repository.Interface;

namespace PcColletion.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;

        public ValuesController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }



        // GET api/values
        [HttpGet]
        public ActionResult<List<string>> Get()
        {

            var result = _itemRepository.GetListAsync().Result;
            if (result == null)
                result = new List<Item>();

            return Ok(result);
         }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var result = _itemRepository.FindAsync(id).Result;
            if (result == null)
                result = new Item();

            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
