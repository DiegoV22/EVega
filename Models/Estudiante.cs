using System.ComponentModel.DataAnnotations;

namespace EVega.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Nota { get; set; }
        public Boolean Estado { get; set; }
        public DateTime Fecha { get; set; }

        



    }
}
