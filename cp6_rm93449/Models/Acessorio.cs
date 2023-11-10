using System.ComponentModel.DataAnnotations;

namespace cp6_rm93449.Models
{
    public class Acessorio
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int carroId { get; set; }

        [Required]
        public string descricao { get; set; }
    }
}
