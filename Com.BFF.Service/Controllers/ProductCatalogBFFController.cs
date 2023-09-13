using Com.BFF.Service.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Com.BFF.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCatalogBFFController : ControllerBase
    {
        Logic logic;

        public ProductCatalogBFFController(Logic logic)
        {
            this.logic = logic;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var productCatalog = await logic.GetProductCatalog();
            return Ok(productCatalog);
        }
    }
}
