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
        public static void Insert(User user)
        {
            OperationsLogs.WriteLogsDebug("UserBrl", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Starting to run the business logic method to create a user"));
            try
            {
                UserDal.Insert(user);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UserBrl", "Insert", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UserBrl", "Insert", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            OperationsLogs.WriteLogsDebug("UserBrl", "Insert", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "I finish executing the business logic method to insert user"));
        }

        /// <summary>
        /// método lógica de negocio para actulizar un usuario
        /// </summary>
        /// <param name="user"></param>
        public static void ToUpdate(User user)
        {
            OperationsLogs.WriteLogsDebug("UserBrl", "ToUpdate", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Starting to run the business logic method to create a user"));

            try
            {
                UserDal.ToUpdate(user);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("UserBrl", "ToUpdate", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("UserBrl", "ToUpdate", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("UserBrl", "ToUpdate", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "I finish executing the business logic method to update user"));
        }
    }
}
