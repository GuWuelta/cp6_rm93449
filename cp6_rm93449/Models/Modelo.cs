using System.ComponentModel.DataAnnotations;

namespace cp6_rm93449.Models
{
    public class Modelo
    {
        [Key]
        public int ìd { get; set; }

        [Required]
        public string descricao { get; set; }
    }
}
