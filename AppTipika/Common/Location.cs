using System;
using System.Collections.Generic;
using System.Text;

namespace AppTipika.Common
{
    public class Location
    {
        #region Properties
        /// <summary>
        /// Propiedad para el idUbicacion
        /// </summary>
        public Guid IdLocation { get; set; }
        /// <summary>
        /// propiedad para la latitud
        /// </summary>
        public int Latitude { get; set; }
        /// <summary>
        /// propiedad para la longitud
        /// </summary>
        public int Length { get; set; }
        #endregion
    }
}
