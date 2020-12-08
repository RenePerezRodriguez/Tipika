using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    public class ClientDal
    {
        /// <summary>
        /// Inserta una Cliente a la base de datos 
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Insertar(Client client)
        {
            OperationsLogs.WriteLogsDebug("ClienteDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un Cliente"));

            SqlCommand command = null;

            //Consulta para insertar Clientes
            string queryString = @"INSERT INTO Cliente(idPersona, idUbicacion) 
                                   VALUES(@idCliente, @idUbicacion)";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperationsSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Inicio la transaccion
                transaccion = conexion.BeginTransaction();

                //Inserto a la persona
                PersonDal.InsertarConTransaccionNoUser(client as Person, transaccion, conexion);

                //Inserto al Cliente
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idCliente", client.IdPerson);
                command.Parameters.AddWithValue("@idUbicacion", client.Location);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Insertar", string.Format("{0} Error: {1} ",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            OperationsLogs.WriteLogsDebug("ClienteDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar Cliente"));
        }

        /// <summary>
        /// Metodo para obtener  un Cliente
        /// </summary>
        /// <param name="id">Identificado del Cliente </param>
        /// <returns>Cliente</returns>
        public static Client Obtener(Guid id)
        {
            Client cliente = null;
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT c.idPersona, c.idUbicacion
                             FROM Cliente c
                             INNER JOIN Persona p ON p.idPersona = c.idPersona
                             WHERE c.idPersona = @id and p.eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                cliente = PersonDal.ObtenerCliente(id);
                while (dr.Read())
                {
                    cliente.IdPerson = dr.GetGuid(0);
                    cliente.Location = LocationDal.Obtener(dr.GetGuid(1));
                }

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Obtenet", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Obtenet", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return cliente;
        }

        /// <summary>
        /// Método para actulizar la ubicacion de un cliente
        /// </summary>
        /// <param name="Cliente"></param>
        public static void ActualizarUbicacionCliente(Location location)
        {
            OperationsLogs.WriteLogsDebug("ClienteDal", "ActualizarUbicacionCliente", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Ubicacion SET latitud = @latitud, longitud = @longitud
                                    WHERE idUbicacion=@idUbicacion";
            try
            {

                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@latitud", location.Latitude);
                command.Parameters.AddWithValue("@longitud", location.Length);
                
                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "ActualizarUbicacionCliente", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "ActualizarUbicacionCliente", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ClienteDal", "ActualActualizarUbicacionClienteizar", string.Format("{0}  Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }

        /// <summary>
        /// Método para eliminar a un Cliente
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Eliminar(Guid idCliente)
        {
            OperationsLogs.WriteLogsDebug("ClienteDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Cliente SET idPersona = @id
                                    WHERE idPersona=@id";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperationsSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Inicio la transaccion
                transaccion = conexion.BeginTransaction();

                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@id", idCliente);

                //Elimino a la persona
                PersonDal.EliminarConTransaccion(idCliente, transaccion, conexion);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Eliminar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Eliminar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            OperationsLogs.WriteLogsDebug("ClienteDal", "Eliminar", string.Format("{0}  Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }
    }
}
