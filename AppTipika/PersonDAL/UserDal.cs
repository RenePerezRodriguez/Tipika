using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    public class UserDal
    {
        #region Methods
        /// <summary>
        /// Inserta un usaurio a la base de datos con transaccion
        /// </summary>
        /// <param name="user">Objeto usuario </param>
        /// <param name="transaction">Objeto transaccion</param>
        /// <param name="connection">Objeto conexion</param>
        public static void InsertTransaction(User user, SqlTransaction transaction, SqlConnection connection)
        {
            OperationsLogs.WriteLogsDebug("UserDal", "InsertTransaction", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Starting to execute the data access method to create a user"));

            SqlCommand command = null;

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuario(idUsuario,nombre,password,rol,eliminado,estadoPassword) 
                                    VALUES(@idUsuario,@nombre,@password,@rol,@eliminado,@estadoPassword)";
            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaction, connection);
                command.Parameters.AddWithValue("@idUsuario", user.IdUser);
                command.Parameters.AddWithValue("@nombre", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@rol", "repartidor");
                command.Parameters.AddWithValue("@estado", 1);
                command.Parameters.AddWithValue("@estadoPassword", 0);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "InsertTransaction", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "InsertTransaction", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UserDal", "InsertTransaction", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "I finish executing the data access method to insert user "));
        }
        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="user"></param>
        public static void ToUpdate(User user)
        {
            OperationsLogs.WriteLogsDebug("UserDal", "ToUpdate", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Starting to execute the data access method to delete a User"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET nombre=@nombre, password=@password
                                    WHERE idUsuario=@idUsuario";
            try
            {

                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@nombre", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@idUsuario", user.IdUser);
                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "ToUpdate", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "ToUpdate", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UserDal", "ToUpdate", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "I finish executing the data access method to Delete a Client"));
        }
        /// <summary>
        /// Borra usuario por id
        /// </summary>
        /// <param name="idPersona"></param>
        public static void DeleteByPersonIdWithTransaction(Guid idPersona, SqlTransaction transaccion, SqlConnection conexion)
        {
            OperationsLogs.WriteLogsDebug("UserDal", "DeleteByPersonId", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET estado=0
                                    WHERE idUsuario = (Select idUsuario FROM Persona WHERE idPersona = @idPersona)";
            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                OperationsSql.ExecuteBasicCommandWithTransaction(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "DeleteByPersonId", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "DeleteByPersonId", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UserDal", "DeleteByPersonId", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }
        #endregion
    }
}
