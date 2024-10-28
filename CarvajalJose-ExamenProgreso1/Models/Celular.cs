using System.ComponentModel.DataAnnotations;

namespace CarvajalJose_ExamenProgreso1.Models
{
    public class Celular
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        [MinLength(2)]
        public string Modelo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{yyyy}")]
        public int Año { get; set; }

        [MinLength(1)]
        public decimal Precio { get; set; }

    }
}
