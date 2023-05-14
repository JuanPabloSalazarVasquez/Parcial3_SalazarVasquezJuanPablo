﻿using System.ComponentModel.DataAnnotations;

namespace Parcial3_SalazarVasquezJuanPablo.DAL.Entities
{
    public class Service : Entity
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Price { get; set; }

        [Display(Name = "Usuario")]
        public User User { get; set; }

        [Display(Name = "Vehiculos")]
        public ICollection<Vehicle> vehicles { get; set; }
    }
}
