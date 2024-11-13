namespace BeeKeeper.Models
{
    public class ProductoPanal
    {
        public int IdProductoPanel { get; set; }
        public int IdEspecie { get; set; }
        public int IdProducto { get; set; }

        public Especie Especie { get; set; }
        public Producto Producto { get; set; }
        public ICollection<Cosecha> Cosechas { get; set; }
    }
}
