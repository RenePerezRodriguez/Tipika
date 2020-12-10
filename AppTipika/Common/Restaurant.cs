using System;
using System.Collections.Generic;

namespace AppTipika.Common
{
    public class Restaurant
    {
        public Guid IdRestaurante { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdUbicacion { get; set; }
        public string NombreRestaurante { get; set; }
        public string Direccion { get; set; }
        public byte Eliminado { get; set; }

    }
}
