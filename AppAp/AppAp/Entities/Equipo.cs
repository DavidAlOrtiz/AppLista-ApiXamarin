using System;
using System.Collections.Generic;
using System.Text;

namespace AppAp.Entities
{
    public class Equipo
    {
        public string Nombre { get; set; }
        public string Liga { get; set; }
        public string ImagenUrl { get; set; }

        public int Campeonatos { get; set; }
        public override string ToString()
        {
            return Nombre;
        }

    }
}
