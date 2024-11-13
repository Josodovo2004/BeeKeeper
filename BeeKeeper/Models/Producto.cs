namespace BeeKeeper.Models
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }

        public ICollection<ProductoPanal> ProductoPanals { get; set; }
    }
}
