namespace BeeKeeper.Models
{
    public class Tratamiento
    {
        public int IdPanal { get; set; }
        public int IdEspecie { get; set; }
        public int IdEnfermedad { get; set; }
        public int IdMedicamento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? SiguienteDosis { get; set; }
        public DateTime? FechaFinal { get; set; }

        public Panal Panal { get; set; }
        public Especie Especie { get; set; }
        public Enfermedad Enfermedad { get; set; }
        public Medicamento Medicamento { get; set; }
    }
}
