using System.ComponentModel.DataAnnotations;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
    }
}
