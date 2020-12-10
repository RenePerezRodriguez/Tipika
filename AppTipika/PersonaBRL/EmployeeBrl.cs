using AppTipika.Common;
using AppTipika.PersonDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonaBRL
{
    public class EmployeeBrl
    {
        /// <summary>
        /// Método lógica de negocio para insertar un Cliente
        /// </summary>
        /// <param name="employee"></param>
        public static void Insert(Employee employee)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un Cliente"));

            try
            {
                EmployeeDal.Insertar(employee);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar Cliente"));

        }
    }
}
