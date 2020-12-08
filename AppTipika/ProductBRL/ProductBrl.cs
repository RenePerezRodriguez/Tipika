using AppTipika.Common;
using AppTipika.ProductDAL;
using System;
using System.Data.SqlClient;

namespace AppTipika.ProductBRL
{
    public class ProductBrl
    {
        /// <summary>
        /// método lógica de negocio para insertar un Producto
        /// </summary>
        /// <param name="Producto"></param>
        public static void Insert(Product product)
        {
            OperationsLogs.WriteLogsDebug("ProductoBrl", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un Producto"));

            try
            {
                ProductDal.Insert(product);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Insertar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ProductoBrl", "Insertar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para insertar Producto"));

        }

        /// <summary>
        /// método lógica de negocio para actulizar un Producto
        /// </summary>
        /// <param name="Producto"></param>
        public static void Update(Product product)
        {
            OperationsLogs.WriteLogsDebug("ProductoBrl", "Actualizar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para crear un Producto"));

            try
            {
                ProductDal.Update(product);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Actualizar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ProductoBrl", "Actualizar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para actualizar Producto"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un Producto
        /// </summary>
        /// <param name="Producto"></param>
        public static void SoftDelete(Guid id)
        {
            OperationsLogs.WriteLogsDebug("ProductoBrl", "Eliminar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Eliminar un Producto"));

            try
            {
                ProductDal.SoftDelete(id);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Eliminar", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ProductoBrl", "Eliminar", string.Format("{0} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el método lógica de negocio para Eliminar Producto"));
        }

        /// <summary>
        /// método lógica de negocio para eliminar un Producto
        /// </summary>
        /// <param name="Producto"></param>
        public static Product Get(Guid id)
        {
            OperationsLogs.WriteLogsDebug("ProductoBrl", "Obtener", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(),
            "Empezando a ejecutar el método lógica de negocio para Obtener un Producto"));

            try
            {
                return ProductDal.Get(id);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoBrl", "Obtener", string.Format("{0} Error: {1}",
                    DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
        }
    }
}
