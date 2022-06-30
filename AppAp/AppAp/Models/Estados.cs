using System;
using System.Collections.Generic;
using System.Text;

namespace AppAp.Models
{
    public  class Estados
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }

        public virtual ICollection<Municipios> VMs { get; set; }
    }
}
