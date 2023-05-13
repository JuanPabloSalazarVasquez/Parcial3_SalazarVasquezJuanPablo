using System.ComponentModel.DataAnnotations;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class VehicleDetail
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string CreationDate { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string DeliveryDate { get; set; }
    }
}
