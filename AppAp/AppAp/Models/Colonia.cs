using System;
using System.Collections.Generic;
using System.Text;

namespace AppAp.Models
{
    public class Colonia
    {
        public int IdColonia { get; set; }
        public string Nombre { get; set; }

        public virtual Municipios MunicipiosVmV { get; set; }
    }
}
