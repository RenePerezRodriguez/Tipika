using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class PersonDal
    {
        /// <summary>
        /// Inserta una Persona a la base de datos 
        /// </summary>
        /// <param name="person"></param>
        public static void Insertar(Person person)
        {
            OperationsLogs.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un persona"));

            SqlCommand command = null;

            //Consulta para insertar personas
            string queryString = @"INSERT INTO Persona(idPersona, cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado) 
                                   VALUES(@idPersona, @cedulaDeIdentidad, @nombres, @primerApellido, @segundoApellido, @correoElectronico, @direccion, @telefono, @eliminado)";
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
                if (person.User != null)
                {
                    UserDal.InsertarTransaccion(person.User, transaccion, conexion);
                    command.Parameters.AddWithValue("@idUsuario", person.User.IdUser);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", null);
                }

                command.Parameters.AddWithValue("@idPersona", person.IdPerson);
                command.Parameters.AddWithValue("@cedulaDeIdentidad", person.IdentityCard);
                command.Parameters.AddWithValue("@nombres", person.Names);
                command.Parameters.AddWithValue("@primerApellido", person.FirstSurname);
                command.Parameters.AddWithValue("@segundoApellido", person.SecondSurname);
                command.Parameters.AddWithValue("@correoElectronico", person.Email);
                command.Parameters.AddWithValue("@direccion", person.Address);
                command.Parameters.AddWithValue("@telefono", person.Phone);
                command.Parameters.AddWithValue("@eliminado", 1);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                transaccion.Commit();

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            OperationsLogs.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar persona"));
        }

        /// <summary>
        /// Inserta una Persona a la base de datos 
        /// </summary>
        /// <param name="person"></param>
        public static void InsertarConTransaccion(Person person, SqlTransaction transaction, SqlConnection connection)
        {
            OperationsLogs.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un persona"));

            SqlCommand command = null;

            //Consulta para insertar personas
            string queryString = @"INSERT INTO Persona(idPersona, idUsuario, cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado) 
                                   VALUES(@idPersona, @idUsuario, @cedulaDeIdentidad, @nombres, @primerApellido, @segundoApellido, @correoElectronico, @direccion, @telefono, @eliminado)";

            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaction, connection);
                if (person.User != null)
                {
                    UserDal.InsertarTransaccion(person.User, transaction, connection);
                    command.Parameters.AddWithValue("@idUsuario", person.User.IdUser);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", null);
                }

                command.Parameters.AddWithValue("@idPersona", person.IdPerson);
                command.Parameters.AddWithValue("@cedulaDeIdentidad", person.IdentityCard);
                command.Parameters.AddWithValue("@nombres", person.Names);
                command.Parameters.AddWithValue("@primerApellido", person.FirstSurname);
                command.Parameters.AddWithValue("@segundoApellido", person.SecondSurname);
                command.Parameters.AddWithValue("@correoElectronico", person.Email);
                command.Parameters.AddWithValue("@direccion", person.Address);
                command.Parameters.AddWithValue("@telefono", person.Phone);
                command.Parameters.AddWithValue("@eliminado", 1);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar persona"));
        }

        /// <summary>
        /// Inserta una Persona a la base de datos 
        /// </summary>
        /// <param name="person"></param>
        public static void InsertarConTransaccionNoUser(Person person, SqlTransaction transaction, SqlConnection connection)
        {
            OperationsLogs.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un persona"));

            SqlCommand command = null;

            //Consulta para insertar personas
            string queryString = @"INSERT INTO Persona(idPersona, cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado) 
                                   VALUES(@idPersona, @idUsuario, @nombres, @primerApellido, @segundoApellido, @correoElectronico, @direccion, @telefono, @eliminado)";

            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaction, connection);

                command.Parameters.AddWithValue("@idPersona", person.IdPerson);
                command.Parameters.AddWithValue("@cedulaDeIdentidad", person.IdentityCard);
                command.Parameters.AddWithValue("@nombres", person.Names);
                command.Parameters.AddWithValue("@primerApellido", person.FirstSurname);
                command.Parameters.AddWithValue("@segundoApellido", person.SecondSurname);
                command.Parameters.AddWithValue("@correoElectronico", person.Email);
                command.Parameters.AddWithValue("@direccion", person.Address);
                command.Parameters.AddWithValue("@telefono", person.Phone);
                command.Parameters.AddWithValue("@eliminado", 1);

                OperationsSql.ExecuteBasicCommandWithTransaction(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Insertar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("PersonaDal", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar persona"));
        }
        /// <summary>
        /// Elimina Persona de la base de datos
        /// </summary>
        /// <param name="idPerson"></param>
        public static void EliminarConTransaccion(Guid idPerson, SqlTransaction transaction, SqlConnection connection)
        {
            OperationsLogs.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET eliminado=0
                                    WHERE idPersona = @idPersona";
            try
            {
                command = OperationsSql.CreateBasicCommandWithTransaction(queryString, transaction, connection);
                command.Parameters.AddWithValue("@idPersona", idPerson);
                OperationsSql.ExecuteBasicCommandWithTransaction(command);

                //elimina al usuario
                UserDal.EliminarPorIdPersonaConTransaccion(idPerson, transaction, connection);

                ////Eliminar telefonos
                //TelefonoDal.EliminarPorIdPersonaConTransaccion(idPersona, transaccion, conexion);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Eliminar", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("PersonaDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }

        /// <summary>
        /// Actualiza Persona de la base de datos
        /// </summary>
        /// <param name="Persona"></param>
        public static void Actualizar(Person person)
        {
            OperationsLogs.WriteLogsDebug("PersonaDal", "ToUpdate", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Personas SET cedulaDeIdentidad = @cedulaDeIdentidad, nombres = @nombres, primerApellido = @primerApellido, segundoApellido = @segundoApellido, correoElectronico = @correoElectronico, direccion = @direccion, telefono = @telefono
                                   WHERE idPersona=@idPersona";
            try
            {

                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idPersona", person.IdPerson);
                command.Parameters.AddWithValue("@cedulaDeIdentidad", person.IdentityCard);
                command.Parameters.AddWithValue("@nombres", person.Names);
                command.Parameters.AddWithValue("@primerApellido", person.FirstSurname);
                command.Parameters.AddWithValue("@segundoApellido", person.SecondSurname);
                command.Parameters.AddWithValue("@correoElectronico", person.Email);
                command.Parameters.AddWithValue("@direccion", person.Address);
                command.Parameters.AddWithValue("@telefono", person.Phone);

                //Actualizo al usuario
                if (person.User != null)
                {
                    command.Parameters.AddWithValue("@idUsuario", person.User.IdUser);
                    UserDal.Actualizar(person.User);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", DBNull.Value);
                }

                ////Actualizo los telefonos
                //foreach (var telefono in persona.Telefonos)
                //{
                //    TelefonoDal.Actualizar(telefono);
                //}

                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "ToUpdate", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "ToUpdate", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("PersonaDal", "ToUpdate", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Person Obtener(Guid id)
        {
            Person person = new Person();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idPersona, idUsuario, cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado
                             FROM Persona 
                             WHERE idPersona = @id and eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    person = new Person()
                    {
                        IdPerson = dr.GetGuid(0),
                        User = UserDal.Obtener(dr.GetGuid(1)),
                        IdentityCard = dr.GetString(2),
                        Names = dr.GetString(3),
                        FirstSurname = dr.GetString(4),
                        SecondSurname = dr.GetString(5),
                        Email = dr.GetString(6),
                        Address = dr.GetString(7),
                        Phone = dr.GetInt32(8),
                        State = dr.GetByte(9)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "Obtener(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return person;
        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Guid ObtenerIdUsuario(Guid idPersona)
        {
            Guid idUsuario = Guid.Empty;
            SqlCommand cmd = null;
            string query = @"SELECT idUsuario 
                             FROM Persona 
                             WHERE idPersona=@id and eliminado=1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", idPersona);
                idUsuario = new Guid(OperationsSql.ExcecuteScalarCommand(cmd));
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "ObtenerIdUsuario(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return idUsuario;
        }

        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Common.Employee ObtenerEmpleado(Guid id)
        {
            Common.Employee persona = new Common.Employee();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idPersona, idUsuario cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado 
                             FROM Persona 
                             WHERE idPersona = @id and eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    persona = new Common.Employee()
                    {
                        IdPerson = dr.GetGuid(0),
                        User = UserDal.Obtener(dr.GetGuid(1)),
                        IdentityCard = dr.GetString(2),
                        Names = dr.GetString(3),
                        FirstSurname = dr.GetString(4),
                        SecondSurname = dr.GetString(5),
                        Email = dr.GetString(6),
                        Address = dr.GetString(7),
                        Phone = dr.GetInt32(8),
                        State = dr.GetByte(9)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "ObtenerEmpleado(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return persona;
        }
        /// <summary>
        /// Obtiene un Persona de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Client ObtenerCliente(Guid id)
        {
            Client persona = new Client();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idPersona, idUsuario cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado 
                             FROM Persona 
                             WHERE idPersona = @id and eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    persona = new Client()
                    {
                        IdPerson = dr.GetGuid(0),
                        User = UserDal.Obtener(dr.GetGuid(1)),
                        IdentityCard = dr.GetString(2),
                        Names = dr.GetString(3),
                        FirstSurname = dr.GetString(4),
                        SecondSurname = dr.GetString(5),
                        Email = dr.GetString(6),
                        Address = dr.GetString(7),
                        Phone = dr.GetInt32(8),
                        State = dr.GetByte(9)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("PersonaDal", "ObtenerCliente(Get)", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return persona;
        }
    }
}