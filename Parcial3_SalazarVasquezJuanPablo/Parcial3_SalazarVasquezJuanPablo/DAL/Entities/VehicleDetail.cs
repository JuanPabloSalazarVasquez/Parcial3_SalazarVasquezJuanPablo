using System.ComponentModel.DataAnnotations;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class VehicleDetail : Entity
    {
        [Display(Name = "Fecha de creacion")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string CreationDate { get; set; }

        [Display(Name = "Fecha de entrega")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string DeliveryDate { get; set; }

        [Display(Name = "Vehiculo")]
        public Vehicle vehicle { get; set; }
    }
}
