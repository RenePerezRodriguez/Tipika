using System;
using System.Data.SqlTypes;

namespace AppTipika.Common
{
    public class Product
    {
        public Guid IdProduct { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Description { get; set; }
        public byte Offer { get; set; }
        public SqlMoney Price { get; set; }
        public byte State { get; set; }
    }
}
