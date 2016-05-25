using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace geolocalizacion.Models
{
    public class CtxContext : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
    }
}