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
        /// Inserta un Usuario a la base de datos 
        /// </summary>
        /// <param name="user"></param>
        public static void Insert(User user)
        {
            OperationsLogs.WriteLogsDebug("UserDal", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "starting to execute the data access method to create a user"));

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuario(idUsuario, nombre, password, rol, eliminado, estadoPassword) 
                                    VALUES(@idUsuario, @nombre, @password, @rol, @eliminado, @estadoPassword)";
            try
            {
                SqlCommand command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", user.IdUser);
                command.Parameters.AddWithValue("@nombre", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@rol", "cliente");
                command.Parameters.AddWithValue("@eliminado", 1);
                command.Parameters.AddWithValue("@estadoPassword", 0);

                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "Insert", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UserDal", "Insert", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UserDal", "Insert", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "I finish executing the data access method to insert user"));
        }

        /// <summary>
        /// Inserta un usaurio a la base de datos con transaccion
        /// </summary>
        /// <param name="user">Objeto usuario </param>
        /// <param name="transaccion">Objeto transaccion</param>
        /// <param name="conexion">Objeto conexion</param>
        public static void InsertTransaction(User user, SqlTransaction transaccion, SqlConnection conexion)
        {
            OperationsLogs.WriteLogsDebug("UserDal", "InsertTransaction", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Starting to execute the data access method to create a user"));

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuario(idUsuario, nombre, password, rol, estado, estadoPassword) 
                                    VALUES(@idUsuario, @nombre, @password, @rol, @estado, @estadoPassword)";
            try
            {
                SqlCommand command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idUsuario", user.IdUser);
                command.Parameters.AddWithValue("@nombreUsuario", user.UserName);
                command.Parameters.AddWithValue("@password", user.Password);
                command.Parameters.AddWithValue("@rol", "cliente");
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
                "I finish executing the data access method to insert user"));
        }

        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="user"></param>
        public static void ToUpdate(User user)
        {
            OperationsLogs.WriteLogsDebug("UserDal", "ToUpdate", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Starting to execute the data access method to delete a User"));

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET nombre=@nombre, password=@password
                                    WHERE idUsuario=@idUsuario";
            try
            {

                SqlCommand command = OperationsSql.CreateBasicCommand(queryString);
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

        #endregion
    }
}
