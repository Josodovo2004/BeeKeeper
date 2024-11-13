namespace BeeKeeper.Models
{
    public class Especie
    {
        public int IdEspecie { get; set; }
        public string Nombre { get; set; }

        public ICollection<Panal> Panales { get; set; }
        public ICollection<ProductoPanal> ProductoPanales { get; set; }
    }
}
