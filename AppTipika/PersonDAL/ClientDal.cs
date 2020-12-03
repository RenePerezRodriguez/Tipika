using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    public class ClientDal
    {
        /// <summary>
        /// Inserta una Cliente a la base de datos 
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Insert(Client client)
        {
            OperationsLogs.WriteLogsDebug("ClientDal", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Starting to execute the data access method to create a Client"));

            //Consulta para insertar Clientes
            string queryString = @"INSERT INTO Cliente(idPersona, idUbicacion) 
                                   VALUES(@idCliente, @idUbicacion)";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperationsSql.ObtenerConexion();
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Declaro la transaccion
                //Inicio la transaccion
                SqlTransaction transaccion = conexion.BeginTransaction();

                //Inserto a la persona
                PersonDal.InsertWithTransaccionNoUser(client as Person, transaccion, conexion);

                //Inserto al Cliente
                SqlCommand command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idCliente", client.IdentityCard);
                command.Parameters.AddWithValue("@idUbicacion", client.Location);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClientDal", "Insert", string.Format("{0} Error: {1} ",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClientDal", "Insert", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            OperationsLogs.WriteLogsDebug("ClientDal", "Insert", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "I finish executing the data access method to insert Client"));
        } 
    }
}
