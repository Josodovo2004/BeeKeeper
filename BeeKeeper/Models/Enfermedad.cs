namespace BeeKeeper.Models
{
    public class Enfermedad
    {
        public int IdEnfermedad { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
