using Commander.Models;
using Commander.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : Controller
    {
        private readonly IRepository<Command> repository;

        public CommandsController(IRepository<Command> repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAll()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet("{id}")]
        public ActionResult<Command> Get(int id)
        {
            return Ok(repository.Get(id));
        }
    }
}
