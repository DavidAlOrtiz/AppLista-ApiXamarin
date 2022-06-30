using System;
using System.Collections.Generic;
using System.Text;

namespace AppAp.Models
{
    public  class Municipios
    {
        public int IdMunicipio { get; set; }
        public string Nombre { get; set; }
        public virtual Estados estadoM { get; set; }
    }
}
