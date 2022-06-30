using System;
using System.Collections.Generic;
using System.Text;

namespace AppAp.Models
{
    public  class Persona
    {
        public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Telefono { get; set; }
        public string Direcion { get; set; }
        public int IdEstado { get; set; }
    }
}
