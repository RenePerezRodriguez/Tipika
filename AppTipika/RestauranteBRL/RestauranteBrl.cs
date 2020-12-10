using AppTipika.Common;
using AppTipika.RestaurantDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.RestauranteBRL
{
    public class RestauranteBrl
    {
        public static void Insert(Restaurant restaurant)
        {
            OperationsLogs.WriteLogsDebug("VentaBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un Venta"));

            try
            {
                RestaurantDal.Insert(restaurant);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("VentaBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("VentaBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("VentaBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar Venta"));

        }
    }
}
