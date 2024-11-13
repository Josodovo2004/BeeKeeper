namespace BeeKeeper.Models
{
    public class Panal
    {
        public int IdPanal { get; set; }
        public int IdEspecie { get; set; }
        public double CO2 { get; set; }
        public double Peso { get; set; }
        public string Estado { get; set; }

        public Especie Especie { get; set; }
        public ICollection<Tratamiento> Tratamientos { get; set; }
        public ICollection<PanalEvento> PanalEventos { get; set; }
    }
}
