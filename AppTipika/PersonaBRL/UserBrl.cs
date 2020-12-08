using AppTipika.Common;
using AppTipika.PersonDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonaBRL
{
    public class UserBrl
    {
        /// <summary>
        /// método lógica de negocio para insertar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Insertar(User usuario)
        {
            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un usuario"));

            try
            {
                UserDal.Insertar(usuario);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar usuario"));

        }

        /// <summary>
        /// método lógica de negocio para actulizar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Actualizar(User usuario)
        {
            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un usuario"));

            try
            {
                UserDal.Actualizar(usuario);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para actualizar usuario"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static void Eliminar(Guid id)
        {
            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Eliminar un usuario"));

            try
            {
                UserDal.Eliminar(id);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Eliminar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Eliminar usuario"));
        }
        /// <summary>
        /// método lógica de negocio para eliminar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static User Obtener(Guid id)
        {
            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un usuario"));

            try
            {
                return UserDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }
        /// <summary>
        /// método lógica de negocio para eliminar un usuario
        /// </summary>
        /// <param name="usuario"></param>
        public static User ObtenerSession(string nombreUsuario, string password)
        {
            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un usuario"));

            try
            {
                return UserDal.ObtenerSession(nombreUsuario, password);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }

        /// <summary>
        /// Metodo que realiza una llamada al metodo LOGIN de la clase UsuarioDAl para iniciar una sesion
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User ObtenerIdUsuario(string nombreUsuario)
        {
            OperationsLogs.WriteLogsDebug("UsuarioBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un usuario"));

            try
            {
                return UserDal.ObtenerIdUsuario(nombreUsuario);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UsuarioBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

        }

        /// <summary>
        /// Validar Pasword
        /// Validar Pasword
        /// </summary>
        /// <param name="nombreUsuario"></param>
        /// <param name="contrsenia"></param>
        /// <returns></returns>

        public static void CambiarPassword(User usuario)
        {
            UserDal.CambiarPassword(usuario);
        }
    }
}
