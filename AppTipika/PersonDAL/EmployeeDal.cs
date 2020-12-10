using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    public class EmployeeDal
    {
        public static void Insertar(Employee employee)
        {
            OperationsLogs.WriteLogsDebug("ClienteDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un Cliente"));

            SqlCommand command = null;

            //Consulta para insertar Clientes
            string queryString = @"INSERT INTO Empleado(idPersona) 
                                   VALUES(@idEmpleado)";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperationsSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Inicio la transaccion
                transaccion = conexion.BeginTransaction();

                //Inserto a la persona
                PersonDal.InsertarConTransaccion(employee as Person, transaccion, conexion);

                //Inserto al Cliente
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@idEmpleado", employee.IdPerson);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Insertar", string.Format("{0} Error: {1} ",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            OperationsLogs.WriteLogsDebug("ClienteDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar Cliente"));
        }
        /// <summary>
        /// Método para eliminar a un Cliente
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Eliminar(Guid idEmpleado)
        {
            OperationsLogs.WriteLogsDebug("ClienteDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Empleado SET idPersona = @id
                                    WHERE idPersona=@id";
            //Declaro e inicio la conexion
            SqlConnection conexion = OperationsSql.ObtenerConexion();

            //Declaro la transaccion
            SqlTransaction transaccion = null;
            try
            {
                //Abro la conexion a la base de datos
                conexion.Open();

                //Inicio la transaccion
                transaccion = conexion.BeginTransaction();

                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaccion, conexion);
                command.Parameters.AddWithValue("@id", idEmpleado);

                //Elimino a la persona
                PersonDal.EliminarConTransaccion(idEmpleado, transaccion, conexion);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Eliminar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteDal", "Eliminar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            OperationsLogs.WriteLogsDebug("ClienteDal", "Eliminar", string.Format("{0}  Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }
    }
}