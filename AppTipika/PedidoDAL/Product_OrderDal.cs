using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.OrderDAL
{
    public class Product_OrderDal
    {
        public static void InsertTransaction(Product_Order product_Order, SqlTransaction transaction, SqlConnection connection)
        {
            OperationsLogs.WriteLogsDebug("DetalleVentaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un DetalleVenta"));

            SqlCommand command = null;

            //Consulta para insertar DetalleVentas
            string queryString = @"INSERT INTO DetalleVenta(idProducto, idPedido, cantidad, precioUnitario) 
                                    VALUES(@idProducto, @idPedido, @cantidad, @precioUnitario)";

            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaction, connection);

                command.Parameters.AddWithValue("@idProducto", product_Order.IdProducto);
                command.Parameters.AddWithValue("@idPedido", product_Order.IdPedido);
                command.Parameters.AddWithValue("@cantidad", product_Order.Cantidad);
                command.Parameters.AddWithValue("@precioUnitario", product_Order.PrecioUnitario);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("DetalleVentaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("DetalleVentaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("DetalleVentaDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar DetalleVenta"));
        } 
    }
}