using AppTipika.Common;
using AppTipika.OrderDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.OrderBRL
{
    public class OrderBrl
    {
        public static void Insert(Order order)
        {
            OperationsLogs.WriteLogsDebug("VentaBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un Venta"));

            try
            {
                OrderDal.Insert(order);
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
