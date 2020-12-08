using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.ProductDAL
{
    public class ProductDal
    {
        /// <summary>
        /// Inserta un Usuario a la base de datos 
        /// </summary>
        /// <param name="Producto"></param>
        public static void Insert(Product product)
        {
            OperationsLogs.WriteLogsDebug("ProductoDal", "Insertar", string.Format("{0} Info: {1}",
            DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para crear un Producto"));

            SqlCommand command = null;

            //Consulta para insertar Productos
            string queryString = @"INSERT INTO Producto(imagen, nombre, ingredientes, descripcion, oferta, eliminado)
                             VALUES(@imagen, @nombre, @ingredientes, @descripcion, @oferta, @eliminado)";

            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);

                command.Parameters.AddWithValue("@imagen", product.Image);
                command.Parameters.AddWithValue("@nombre", product.Name);
                command.Parameters.AddWithValue("@ingredientes", product.Ingredients);
                command.Parameters.AddWithValue("@descripcion", product.Description);
                command.Parameters.AddWithValue("@oferta", product.Offer);
                command.Parameters.AddWithValue("@eliminado", 1);

                OperationsSql.ExecuteBasicCommand(command);

            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Insertar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ProductoDal", "Insertar", string.Format("{0} {1} Info: {1}",
                DateTime.Now.ToString(), DateTime.Now.ToString(),
                "Termino de ejecutar  el metodo acceso a datos para insertar Producto"));
        }


        /// <summary>
        /// Actualiza Usuario de la base de datos
        /// </summary>
        /// <param name="Producto"></param>
        public static void Update(Product product)
        {
            OperationsLogs.WriteLogsDebug("ProductoDal", "Actualizar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Producto"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Producto SET imagen = @imagen, nombre = @nombre, ingredientes = @ingredientes, descripcion = @descripcion, oferta = @oferta, eliminado = @eliminado
                                   WHERE idProducto = @idProducto";
            try
            {

                command = OperationsSql.CreateBasicCommand(queryString);

                command.Parameters.AddWithValue("@idProducto", product.IdProduct);
                command.Parameters.AddWithValue("@imagen", product.Image);
                command.Parameters.AddWithValue("@nombre", product.Name);
                command.Parameters.AddWithValue("@ingredientes", product.Ingredients);
                command.Parameters.AddWithValue("@descripcion", product.Description);
                command.Parameters.AddWithValue("@oferta", product.Offer);

                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Actualizar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Actualizar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ProductoDal", "Actualizar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }



        /// <summary>
        /// Elimina Usuario de la base de datos
        /// </summary>
        /// <param name="idProducto"></param>
        public static void SoftDelete(Guid idProducto)
        {
            OperationsLogs.WriteLogsDebug("ProductoDal", "Eliminar", string.Format("{0} Info: {1}", DateTime.Now.ToString(), "Empezando a ejecutar el metodo acceso a datos para eliminar un Producto"));

            SqlCommand command = null;

            // Proporcionar la cadena de consulta 
            string queryString = @"UPDATE Producto SET eliminado = 0
                                    WHERE idProducto = @idProducto";
            try
            {
                command = OperationsSql.CreateBasicCommand(queryString);
                command.Parameters.AddWithValue("@idProducto", idProducto);
                OperationsSql.ExecuteBasicCommand(command);
            }
            catch (SqlException ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Eliminar", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }

            OperationsLogs.WriteLogsDebug("ProductoDal", "Eliminar", string.Format("{0} {1} Info: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), "Termino de ejecutar  el metodo acceso a datos para Eliminar un Cliente"));
        }


        public static Product Get(Guid id)
        {
            Product product = new Product();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idProducto, imagen, nombre, ingredientes, descripcion, oferta, eliminado
                           FROM Producto 
                           WHERE idProducto = @id AND eliminado = 1";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    product = new Product
                    {
                        IdProduct = dr.GetGuid(0),
                        Image = dr.GetString(1),
                        Name = dr.GetString(2),
                        Ingredients = dr.GetString(3),
                        Description = dr.GetString(4),
                        Offer = dr.GetByte(5),
                        Price = dr.GetSqlMoney(6)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("ProductoDal", "Obtenet(Get)", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return product;
        }
    }
}