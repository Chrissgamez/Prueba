
using Microsoft.AspNetCore.Mvc;
using Servicio.DTOs;
using Servicio.Models;


namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdenController : ControllerBase
    {
        // Simulación de almacenamiento en memoria
        private static readonly List<Orden> Orders = new();

        [HttpPost]
        public IActionResult Create([FromBody] CreateOrdenDto dto)
        {
            var order = new Orden
            {
                Id = Guid.NewGuid(),
                ProductId = dto.ProductId,
                Quantity = dto.Quantity
            };

            Orders.Add(order);
            return Ok(order);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var order = Orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return Ok(order);
        }
    }
}
