using _2___Services;
using _4___Domain;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Crud crud = new Crud();

        // GET api/<ValuesController>/5
        [HttpGet]
        public List<ReturnApiCEPModel> Get(string cep)
        {
            var value = crud.getData(cep);
            return value;
        }

        // POST api/<ValuesController>
        [HttpPost]
        public ReturnApiCEPModel Post([FromBody] ReturnApiCEPModel value)
        {
            crud.insertData(value);
            return value;
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        public ReturnApiCEPModel Put([FromBody] ReturnApiCEPModel value)
        {
            crud.updateData(value);
            return value;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete]
        public string Delete(string cep)
        {
            crud.deleteData(cep);
            return "Dados deletados com sucesso!";
        }
    }
}
