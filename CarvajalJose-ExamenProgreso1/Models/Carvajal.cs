using System.ComponentModel.DataAnnotations;

namespace CarvajalJose_ExamenProgreso1.Models
{
    public class Carvajal
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal Altura { get; set; }

        public bool Trabajando { get; set; }
        public DateTime Fecha { get; set; }



    }
}
