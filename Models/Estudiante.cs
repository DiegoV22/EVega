using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EVega.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public float Nota { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Fecha { get; set; }

        [ForeignKey("CarreraId")]
        public int IdCarrera { get; set; }
        public Carrera Carrera { get; set; }
        

        



    }
}
