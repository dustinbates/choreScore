namespace choreScore.Controllers
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/chores")]
    public class ChoresController : ControllerBase
    {

        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService)
        {
            _choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetAll()
        {
            try 
            {
                return Ok(_choresService.GetAllChores());
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{name}")]
        public ActionResult<Chore>GetOneChore(string name)
        {
            try 
            {
              Chore chore = _choresService.GetOneChore(name);
              return Ok(chore);
            }
            catch (System.Exception e)
            {
              return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Chore>CreateChore([FromBody] Chore choreData)
        {
            try 
            {
              Chore chore = _choresService.CreateChore(choreData);
              return Ok(chore);
            }
            catch (System.Exception e)
            {
              return BadRequest(e.Message);
            }
        }
        

        [HttpDelete("{name}")]
        public ActionResult<string>RemoveChore(string name)
        {
            try 
            {
              string message = _choresService.RemoveChore(name);
              return Ok(message);
            }
            catch (System.Exception e)
            {
              return BadRequest(e.Message);
            }
        }

        [HttpPut("{name}/complete")]
        public ActionResult<Chore>CompleteChore(string name)
        {
            try 
            {
              Chore chore = _choresService.CompleteChore(name);
              return Ok(chore);
            }
            catch (System.Exception e)
            {
              return BadRequest(e.Message);
            }
        }
    }
}