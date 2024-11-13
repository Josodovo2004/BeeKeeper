namespace BeeKeeper.Models
{
    public class PanalEvento
    {
        public int IdPanal { get; set; }
        public int IdEspecie { get; set; }
        public int IdEvento { get; set; }
        public DateTime FechaProgramada { get; set; }
        public bool Concluido { get; set; }

        public Panal Panal { get; set; }
        public Especie Especie { get; set; }
        public Evento Evento { get; set; }
    }
}
