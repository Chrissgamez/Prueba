namespace Servicio.Models
{
    public class Orden
    {
        public Guid Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
