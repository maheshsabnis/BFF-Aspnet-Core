using Com.Manufacturer.Service.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.Manufacturer.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturersController : ControllerBase
    {
        IRepository manuServ;
        public ManufacturersController(IRepository serv)
        {
            manuServ = serv;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(manuServ.GetManufacturers());
        }
    }
}
