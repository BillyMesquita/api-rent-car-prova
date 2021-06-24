using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_rent_car_prova.Models
{
    public class VeiculoViewModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "{0} é requerido")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "{0} é requerido")]
        public int Ano { get; set; }
        [Required(ErrorMessage = "{0} é requerido")]
        public float Quilometragem { get; set; }

    }
}
