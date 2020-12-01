﻿using AppTipika.Common;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    /// <summary>
    /// Clase que sirve para interactuar con la base de datos
    /// </summary>
    public class PersonDal
    {
        #region Methods
        /// <summary>
        /// Inserta una Persona a la base de datos 
        /// </summary>
        /// <param name="person"></param>
        public static void InsertWithTransaction(Person person, SqlTransaction transaction, SqlConnection connection)
        {
            Operations.WriteLogsDebug("PersonDal", "Insert", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Starting to execute the data access method to create a person"));

            SqlCommand command = null;

            //Consulta para insertar personas
            string queryString = @"INSERT INTO Persona(idPersona, cedulaDeIdentidad, nombres, primerApellido, segundoApellido, correoElectronico, direccion, telefono, eliminado) 
                                   VALUES(@idPersona, @cedulaDeIdentidad, @nombres, @primerApellido, @segundoApellido, @correoElectronico, @direccion, @telefono, @eliminado)";

            try
            {
                command = OperationsPlsql.CreateBasicCommandWithTransaction(queryString, transaction, connection);
                if (person.User != null)
                {
                    UserDal.InsertTransaction(person.User, transaction, connection);
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
                command.Parameters.AddWithValue("@eliminado",1);

                OperationsPlsql.ExecuteBasicCommandWithTransaction(command);    
            }
            catch (SqlException ex)
            {
                Operations.WriteLogsRelease("PersonDal", "Insert", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operations.WriteLogsRelease("PersonDal", "Insert", string.Format("{0} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operations.WriteLogsDebug("PersonDal", "Insert", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "I finish executing the data access method to insert person"));
        }
        /// <summary>
        /// Actualiza Persona de la base de datos
        /// </summary>
        /// <param name="Person"></param>
        public static void ToUpdate(Person person)
        {
            Operations.WriteLogsDebug("PersonDal", "Delete", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET cedulaDeIdentidad=@cedulaDeIdentidad, nombres=@nombres, primerApellido=@primerApellido, segundoApellido=@segundoApellido, correoElectronico=@correoElectronico, direccion=@direccion, telefono=@telefono
                                   WHERE idPersona=@idPersona";
            try
            {

                command = OperationsPlsql.CreateBasicCommand(queryString);
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
                    UserDal.ToUpdate(person.User);
                }
                else
                {
                    command.Parameters.AddWithValue("@idUsuario", DBNull.Value);
                }

                OperationsPlsql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                Operations.WriteLogsRelease("PersonDal", "Delete", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operations.WriteLogsRelease("PPersonDal", "Delete", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operations.WriteLogsDebug("PersonDal", "Delete", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));

        }
        /// <summary>
        /// Elimina Persona de la base de datos
        /// </summary>
        /// <param name="idPersona"></param>
        public static void DeleteWithTransaction(Guid idPersona, SqlTransaction transaction, SqlConnection connection)
        {
            Operations.WriteLogsDebug("PersonDal", "Delete", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Persona"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Persona SET estado=0
                                    WHERE idPersona = @idPersona";
            try
            {
                command = OperationsPlsql.CreateBasicCommandWithTransaction(queryString, transaction, connection);
                command.Parameters.AddWithValue("@idPersona", idPersona);
                OperationsPlsql.ExecuteBasicCommandWithTransaction(command);

                //elimina al usuario
                UserDal.DeleteByPersonIdWithTransaction(idPersona, transaction, connection);

            }
            catch (SqlException ex)
            {
                Operations.WriteLogsRelease("PersonDal", "Delete", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                Operations.WriteLogsRelease("PersonDal", "Delete", string.Format("{0} Error: {1}", DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            Operations.WriteLogsDebug("PersonDal", "Delete", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }
        #endregion
    }
}