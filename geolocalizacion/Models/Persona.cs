using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace geolocalizacion.Models
{
    public class Persona
    {
        [Key]
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipo_identificacion { get; set; }
        public int identificacion { get; set; }
        public string regimen { get; set; }
        public string tipo_persona { get; set; }
        public string estado_civil { get; set; }
        public string sexo { get; set; }
        public double latitud { get; set; }
        public double longitud { get; set; }
    }
}