using Com.Products.Service.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.Products.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IRepository prdServ;

        public ProductsController(IRepository serv)
        {
            prdServ = serv;
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(prdServ.GetProducts());
        }
    }
}
