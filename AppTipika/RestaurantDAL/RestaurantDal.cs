using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.RestaurantDAL
{
    public class RestaurantDal
    {
        public static void Insert(Restaurant restaurant)
        {
            OperationsLogs.WriteLogsDebug("RestaurantDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un Producto"));

            SqlCommand command = null;

            //Consulta para insertar Productos
            string queryString = @"INSERT INTO Restaurante(idRestaurante, idCliente, idUbicacion, nombre, direccion, eliminado)
                                   VALUES(@idRestaurante, @idCliente, @idUbicacion, @nombre, @direccion, @eliminado)";

            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);

                command.Parameters.AddWithValue("@idRestaurante", restaurant.IdRestaurante);
                command.Parameters.AddWithValue("@idCliente", restaurant.IdCliente);
                command.Parameters.AddWithValue("@idUbicacion", restaurant.IdUbicacion);
                command.Parameters.AddWithValue("@nombre", restaurant.NombreRestaurante);
                command.Parameters.AddWithValue("@direccion", restaurant.Direccion);
                command.Parameters.AddWithValue("@eliminado", 1);

                OperationsSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("RestaurantDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("RestaurantDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("RestaurantDal", "Insertar", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar Producto"));
        }

        public static void Eliminar(int id)
        {
            OperationsLogs.WriteLogsDebug("RestaurantDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Venta"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Restaurante SET eliminado=0
                                    WHERE idRestaurante = @idRestaurante";
            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idRestaurante", id);
                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("RestaurantDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("RestaurantDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("RestaurantDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }
    }
}
