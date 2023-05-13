using System.ComponentModel.DataAnnotations;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class Vehicle : Entity
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Owner { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NumberPlate { get; set; }
    }
}
