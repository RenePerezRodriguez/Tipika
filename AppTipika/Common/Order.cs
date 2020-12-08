using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace AppTipika.Common
{
    public class Order
    {
        public Guid IdPedido { get; set; }
        public Guid IdCliente { get; set; }
        public Guid IdEmpleado { get; set; }
        public SqlMoney PrecioTotal { get; set; }
        public byte EstadoPedido { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEntrega { get; set; }
        public byte Eliminado { get; set; }
        public List<Product_Order> ProductOrder { get; set; }
    }
}
