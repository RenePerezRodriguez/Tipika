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
        public static void Insert(Client cliente)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un Cliente"));

            try
            {
                ClientDal.Insertar(cliente);
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

        /// <summary>
        /// Método lógica de negocio para crear un Cliente en la lógica de negocio
        /// </summary>
        /// <param name="Cliente"></param>
        public static void Update(Client cliente)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Empezando a ejecutar el método lógica de negocio para Actualizar un Cliente"));

            try
            {
                ClientDal.Actualizar(cliente);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ClienteBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Actualizar Cliente"));
        }
        /// <summary>
        /// Método para obtener  un Cliente
        /// </summary>
        /// <param name="id">Identificado del Cliente </param>
        /// <returns>Cliente</returns>
        public static Client Get(Guid id)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Insertar", string.Format("{0} Info: {1}",
          DateTime.Now.ToString(),
          "Empezando a ejecutar el método lógica de negocio para obtener un Cliente"));
            Client Cliente = null;
            try
            {
                Cliente = ClientDal.Obtener(id);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ClienteBrl", "obtener", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para obtener Cliente"));

            return Cliente;
        }


        /// <summary>
        /// Método lógica de negocio para crear un Cliente en la lógica de negocio
        /// </summary>
        /// <param name="Cliente"></param>
        public static void ActualizarUbicacionCliente(Location location)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Empezando a ejecutar el método lógica de negocio para Actualizar un Cliente"));

            try
            {
                ClientDal.ActualizarUbicacionCliente(location);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ClienteBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Actualizar Cliente"));
        }

        public static void SoftDelete(Guid idCliente)
        {
            OperationsLogs.WriteLogsDebug("ClienteBrl", "Eliminar", string.Format("{0} Info: {1}",
               DateTime.Now.ToString(),
               "Empezando a ejecutar el método lógica de negocio para Eliminar un Cliente"));

            try
            {
                ClientDal.Eliminar(idCliente);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ClienteBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ClienteBrl", "Eliminar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Actualizar Cliente"));
        }
    }
}
