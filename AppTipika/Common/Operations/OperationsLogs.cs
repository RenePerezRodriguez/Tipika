namespace AppTipika.Common
{
    public class OperationsLogs
    {
        /// <summary>
        /// Escribe en el log en modo depuración
        /// </summary>
        /// <param name="table">Nombre de la entidad</param>
        /// <param name="title">Título del mensaje</param>
        /// <param name="message">Mensaje a imprimir en el log</param>
        public static void WriteLogsDebug(string table, string title, string message)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("{0} {1} {2}", message, title, table));
        }


        /// <summary>
        /// Escribe en el log en modo producción
        /// </summary>
        /// <param name="table">Nombre de la entidad</param>
        /// <param name="title">Título del mensaje</param>
        /// <param name="message">Mensaje a imprimir en el log</param>
        public static void WriteLogsRelease(string table, string title, string message)
        {
            System.Diagnostics.Trace.WriteLine(string.Format("{0} {1} {2}", message, title, table));
        }
    }
}