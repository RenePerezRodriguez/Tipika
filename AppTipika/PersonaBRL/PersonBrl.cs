using AppTipika.Common;
using AppTipika.PersonDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonaBRL
{
    public class PersonBrl
    {
        /// <summary>
        /// método lógica de negocio para insertar un persona
        /// </summary>
        /// <param name="persona"></param>
        public static void Insert(Person persona)
        {
            OperationsLogs.WriteLogsDebug("PersonaBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un persona"));

            try
            {
                PersonDal.Insertar(persona);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("PersonaBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar persona"));

        }
    }
}
