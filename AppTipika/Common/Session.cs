using System;

namespace AppTipika.Common
{
    /// <summary>
    /// Clase que inicia las variables de Sesion de la tabla Usuario 
    /// </summary>
    public class Session
    {
        public static Guid idSession;
        public static string userSession;
        public static string rolSession;
        public static byte estadoPassword;

        public static string Info()
        {
            return "Usuario: " + userSession + ", Rol: " + rolSession;
        }
    }
}