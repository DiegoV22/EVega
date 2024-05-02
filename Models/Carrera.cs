using System.ComponentModel.DataAnnotations;

namespace EVega.Models
{
    public class Carrera
    {
        [Key]
        public int IdCarrera { get; set; }
        [Required]
        public string NombreCarrera { get; set; }
        public string Campus {  get; set; }
        public int NumeroSemestre { get; set; }

    }
}
