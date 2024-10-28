using System.ComponentModel.DataAnnotations;

namespace CarvajalJose_ExamenProgreso1.Models
{
    public class Carvajal
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(2)]
        public string Nombre { get; set; }

        [Range(0, 2.5)]
        public decimal Altura { get; set; }

        public bool Trabajando { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime Fecha { get; set; }



    }
}
