using AppTipika.Common;
using AppTipika.Common.Operations;
using System;
using System.Data.SqlClient;

namespace AppTipika.PersonDAL
{
    public class LocationDal
    {
        /// <summary>
        /// Obtiene la ubicacion de la base de datos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Location Obtener(Guid id)
        {
            Location res = new Location();
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            string query = @"SELECT idUbicacion, latitud, longitud,  
                             FROM Ubicacion 
                             WHERE idUbicacion = @id";
            try
            {
                cmd = OperationsSql.CreateBasicCommand(query);
                cmd.Parameters.AddWithValue("@id", id);
                dr = OperationsSql.ExecuteDataReaderCommand(cmd);
                while (dr.Read())
                {
                    res = new Location()
                    {
                        IdLocation = dr.GetGuid(0),
                        Latitude = dr.GetInt32(1),
                        Length = dr.GetInt32(2)
                    };
                }
            }
            catch (Exception ex)
            {
                OperationsLogs.WriteLogsRelease("LocationDal", "Obtener(Get)", string.Format("{0} {1} Error: {1}", DateTime.Now.ToString(), DateTime.Now.ToString(), ex.Message));
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return res;
        }
    }
}
