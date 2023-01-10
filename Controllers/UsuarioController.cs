using Microsoft.AspNetCore.Mvc;

namespace SistemaTarefas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Models.UsuarioModel>> BuscarTodosUsuarios()
        {
            return Ok();
        }
    }
}