using Portafolio_EncinasGuerrero.Models;
using Portafolio_EncinasGuerrero.Datos;
using System.Data;
using System.Data.SqlClient;
namespace Portafolio_EncinasGuerrero.Datos
{
    public class InformacionDatos
    {
        public List<InformacionModel> Listar()
        {
            List<InformacionModel> lista = new List<InformacionModel>();
            var cn = new Conexion();
            using (var conexion = new SqlConnection(cn.PasameLaCadena()))
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("sp_Mostrar", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new InformacionModel
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Nombre = dr["Nombre"].ToString(),
                            Apellido = dr["Apellido"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Telefono = dr["Telefono"].ToString()
                        });
                    }
                }
                return lista;
            }
        }
    }
}
