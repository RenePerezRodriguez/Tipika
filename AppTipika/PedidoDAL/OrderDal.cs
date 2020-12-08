using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.OrderDAL
{
    public class OrderDal
    {
        public static void Insert(Order order)
        {
            OperationsLogs.WriteLogsDebug("VentaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear una Venta"));

            SqlCommand command = null;

            string query = @"INSERT INTO Pedido(idPedido, idCliente, idEmpleado, precioTotal, estadoPedido, fechaInicio, fechaEntrega, eliminado)
                            VALUES(@idPedido, @idCliente, @idEmpleado, @precioTotal, @estadoPedido, @fechaInicio, @fechaEntrega, @eliminado)";

            //Declaro e inicio la conexion
            SqlConnection conexion = OperationsSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                conexion.Open();

                transaccion = conexion.BeginTransaction();
                command = OperationsSql.CreateBasicCommand(query);
                command.Parameters.AddWithValue("@idPedido", order.IdPedido);
                command.Parameters.AddWithValue("@idCliente", order.IdCliente);
                command.Parameters.AddWithValue("@idEmpleado", order.IdEmpleado);
                command.Parameters.AddWithValue("@precioTotal", order.PrecioTotal);
                command.Parameters.AddWithValue("@estadoPedido", order.EstadoPedido);
                command.Parameters.AddWithValue("@fechaInicio", order.FechaInicio);
                command.Parameters.AddWithValue("@fechaEntrega", order.FechaEntrega);
                command.Parameters.AddWithValue("@eliminado", order.Eliminado);
                OperationsSql.ExecuteBasicCommand(command);

                foreach (Product_Order detalle in order.ProductOrder)
                {
                    Product_OrderDal.InsertTransaction(detalle, transaccion, conexion);

                }

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("VentaDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("VentaDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            OperationsLogs.WriteLogsDebug("VentaDal", "Insertar", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar venta"));
        }
        public static void Eliminar(Guid id)
        {
            OperationsLogs.WriteLogsDebug("VentaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Venta"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Pedido SET eliminado = 0
                                    WHERE idPedido = @idPedido";
            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idPedido", id);
                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("VentaDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("VentaDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("VentaDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }
    }
}