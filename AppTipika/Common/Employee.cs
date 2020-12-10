using System;
using System.Collections.Generic;
using System.Text;

namespace AppTipika.Common
{
    public class Employee:Person
    {
        #region properties
        /// <summary>
        /// Propertie for Idvehiculo
        /// </summary>
        public Vehicle Vehicle { get; set; }
        /// <summary>
        /// Propertie for salary
        /// </summary>
        public double Salary { get; set; }
        #endregion
    }
}
