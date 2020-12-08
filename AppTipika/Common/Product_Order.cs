using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace AppTipika.Common
{
    public class Product_Order
    {
        public Guid IdProducto { get; set; }
        public Guid IdPedido { get; set; }
        public int Cantidad { get; set; }
        public SqlMoney PrecioUnitario { get; set; }
    }
}
