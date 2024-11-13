namespace BeeKeeper.Models
{
    public class Evento
    {
        public int IdEvento { get; set; }
        public string Nombre { get; set; }

        public ICollection<PanalEvento> PanalEventos { get; set; }
    }
}
