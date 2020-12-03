using AppTipika.Common;
using AppTipika.PersonDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonaBRL
{
    public class ClientBrl
    {
        /// <summary>
        /// Método lógica de negocio para insertar un Cliente
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Insert(Client client)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Starting to execute the business logic method to create a Customer"));

            try
            {
                ClientDal.Insert(client);
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
                "I finish executing the business logic method to insert Customer"));

        }
    }
}
