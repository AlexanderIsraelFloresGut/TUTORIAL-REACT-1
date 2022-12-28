using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TUTORIAL_REACT_1.Models;

namespace TUTORIAL_REACT_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly BCFOODS_2022Context _bcfcontext;

        public EmpleadoController(BCFOODS_2022Context context)
        {
            _bcfcontext = context;
        }

        [HttpGet]
        [Route("ObtenerEmpleado")]
        public IActionResult ObtenerEmpleado()
        {
            List<Empleado> listaemp = _bcfcontext.Empleados.ToList();
            return StatusCode(StatusCodes.Status200OK, listaemp);
        }
    }
}
