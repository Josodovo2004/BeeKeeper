namespace BeeKeeper.Models
{
    public class Enfermedad
    {
        public int IdEnfermedad { get; set; }  // Se considera la clave primaria automáticamente.
        public string Descripcion { get; set; }

        public ICollection<Tratamiento> Tratamientos { get; set; }
    }
}
