using Microsoft.AspNetCore.Mvc;
using System;
using Pago.DTOs;


    
    [ApiController]
    [Route("api/[controller]")]
    public class PagoController : ControllerBase
    {
        [HttpPost]
        public IActionResult Pay([FromBody] PagoRequestDto dto)
        {
            if (dto.Amount <= 0 || string.IsNullOrWhiteSpace(dto.CardNumber))
                return BadRequest("Invalid payment data");

            // Simulación de resultado exitoso
            return Ok(new
            {
                Status = "Success",
                TransactionId = Guid.NewGuid(),
                Message = "Payment processed successfully"
            });
        }
}
