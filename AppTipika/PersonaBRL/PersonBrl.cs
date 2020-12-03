using AppTipika.Common;
using AppTipika.PersonDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonaBRL
{
    public class PersonBrl
    {
        #region Methods
        /// <summary>
        /// método lógica de negocio para insertar un persona
        /// </summary>
        /// <param name="person"></param>
        public static void Insert(Person person)
        {
            OperationsLogs.WriteLogsDebug("PersonBrl", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Starting to run the business logic method to create a persona"));

            try
            {
                PersonDal.Insert(person);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonBrl", "Insert", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonBrl", "Insert", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("PersonBrl", "Insert", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar persona"));

        }
        #endregion
    }
}
