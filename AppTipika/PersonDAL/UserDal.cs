using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    public class UserDal
    {
        /// <summary>
        /// Inserta un Usuario a la base de datos 
        /// </summary>
        /// <param name="usuario"></param>
        public static void Insertar(User usuario)
        {
            OperationsLogs.WriteLogsDebug("UsuarioDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un usuario"));

            SqlCommand command = null;

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuario(idUsuario, nombre, password, rol, eliminado, estadoPassword) 
                                    VALUES(@idUsuario, @nombre, @password, @rol, @eliminado, @estadoPassword)";
            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUser);
                command.Parameters.AddWithValue("@nombre", usuario.UserName);
                command.Parameters.AddWithValue("@password", usuario.Password);
                command.Parameters.AddWithValue("@rol", usuario.Role);
                command.Parameters.AddWithValue("@eliminado", usuario.State);
                command.Parameters.AddWithValue("@estadoPassword", usuario.PasswordState);

                OperationsSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioDal", "Insertar", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar usuario"));
        }

        /// <summary>
        /// Inserta un usaurio a la base de datos con transaccion
        /// </summary>
        /// <param name="usuario">Objeto usuario </param>
        /// <param name="transaccion">Objeto transaccion</param>
        /// <param name="conexion">Objeto conexion</param>
        public static void InsertarTransaccion(User usuario, SqlTransaction transaccion, SqlConnection conexion)
        {
            OperationsLogs.WriteLogsDebug("UsuarioDal", "InsertarTransaccion", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un usuario"));

            SqlCommand command = null;

            //Consulta para insertar usuarios
            string queryString = @"INSERT INTO Usuario(idUsuario, nombre, password, rol, eliminado, estadoPassword) 
                                    VALUES(@idUsuario, @nombre, @password, @rol, @eliminado, @estadoPassword)";
            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idUsuario", usuario.IdUser);
                command.Parameters.AddWithValue("@nombre", usuario.UserName);
                command.Parameters.AddWithValue("@password", usuario.Password);
                command.Parameters.AddWithValue("@rol", "cliente");
                command.Parameters.AddWithValue("@eliminado", (byte)1);
                command.Parameters.AddWithValue("@estadoPassword", (byte)1);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioDal", "InsertarTransaccion", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar usuario"));
        }

        /// <summary>
        /// Elimina Usuario de la base de datos
        /// </summary>
        /// <param name="idUsuario"></param>
        public static void Eliminar(Guid idUsuario)
        {
            OperationsLogs.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET eliminado = 0
                                    WHERE idUsuario = @idUsuario";
            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idUsuario", idUsuario);
                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idPersona"></param>
        public static void EliminarPorIdPersonaConTransaccion(Guid idPersona, SqlTransaction transaccion, SqlConnection conexion)
        {
            OperationsLogs.WriteLogsDebug("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET eliminado = 0
                                    WHERE idUsuario = (Select idUsuario FROM Persona WHERE idPersona = @idPersona)";
            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                OperationsSql.ExecuteBasicCommandWithTransaction(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioDal", "EliminarPorIdPersona", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="Usuario"></param>
        public static void Actualizar(User user)
        {
            OperationsLogs.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Usuario"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Usuario SET nombre = @nombre, password = @password
                                    WHERE idUsuario = @idUsuario";
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
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Actualizar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioDal", "Actualizar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }
        /// <summary>
        /// Obtiene un Usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User Obtener(Guid id)
        {
            User res = new User();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idUsuario, nombre, password, rol, eliminado 
                             FROM Usuarios 
                             WHERE idUsuario = @id and eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new User()
                    {
                        IdUser = dr.GetGuid(0),
                        UserName = dr.GetString(1),
                        Password = dr.GetString(2),
                        Role = dr.GetString(3),
                        State = dr.GetByte(4)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "Obtenet(Get)", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
        /// <summary>
        /// Obtiene un Usuario de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User ObtenerSession(string nombreUsuario, string password)
        {
            User res = new User();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idUsuario, nombre, rol
                             FROM Usuario";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                cmd.Parameters.AddWithValue("@password", password);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new User()
                    {
                        IdUser = dr.GetGuid(0),
                        UserName = dr.GetString(1),
                        Role = dr.GetString(2)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "ObtenerSession(Get)", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
        public static User ObtenerIdUsuario(string nombreUsuario)
        {
            User res = new User();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idUsuario
                             FROM Usuario 
                             WHERE nombre = @nombre and eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@nombre", nombreUsuario);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new User()
                    {
                        IdUser = dr.GetGuid(0)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioDal", "ObtenerIdUsuario(Get)", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }

        /// <summary>
        /// Metodo que ejecuta una consulta UPDATE en la tabla Usuario para cambiar contraseña
        /// </summary>
        public static void CambiarPassword(User user)
        {
            string query = @"UPDATE Usuario 
                             set password = @password, estadoPassword = 1
                             WHERE idUsuario = @idUsuario";
            try
            {
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Inicio del Metodo de Cambiar Contraseña de Empleado Usuario", DateTime.Now));
                SqlCommand cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@password", user.Password).SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.AddWithValue("@idUsuario", user.IdUser);

                OperationsSql.ExecuteBasicCommand(cmd);
                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Contraseña Cambiada, Nombre Empleado: {1}", DateTime.Now, Session.userSession));
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(string.Format("{0} Info: Error al Cambiar Contraseña:  {1} Usuario: {2}", DateTime.Now, ex.Message, Session.userSession));
            }
        }


    }
}
