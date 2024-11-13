namespace BeeKeeper.Models
{
    public class Medicamento
    {
        public int IdMedicamento { get; set; }
        public string Nombre { get; set; }

        public ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
