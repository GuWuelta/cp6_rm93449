using System.ComponentModel.DataAnnotations;

namespace cp6_rm93449.Models
{
    public class Carro
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int modeloId { get; set; }

        [Required]
        public string placa { get; set; }

        [Required]
        public string cor { get; set; }
    }
}
