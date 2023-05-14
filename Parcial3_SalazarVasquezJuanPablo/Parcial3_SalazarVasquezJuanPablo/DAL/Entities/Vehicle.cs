using System.ComponentModel.DataAnnotations;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class Vehicle : Entity
    {
        [Display(Name = "Propietario")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Owner { get; set; }

        [Display(Name = "Placa")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NumberPlate { get; set; }

        [Display(Name = "Detalle de Vehiculos")]
        public ICollection<VehicleDetail> VehicleDetails { get; set; }
    }
}
