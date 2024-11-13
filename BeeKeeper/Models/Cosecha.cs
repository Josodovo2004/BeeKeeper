namespace BeeKeeper.Models
{
    public class Cosecha
    {
        public int IdCosecha { get; set; }
        public int IdProductoPanal { get; set; }
        public DateTime FechaCosecha { get; set; }
        public double Cantidad { get; set; }

        public ProductoPanal ProductoPanal { get; set; }
    }
}
