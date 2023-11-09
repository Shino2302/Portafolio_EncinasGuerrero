using System.Data.SqlClient;

namespace Portafolio_EncinasGuerrero.Datos
{
    public class Conexion
    {
        private string _cadenaSql = string.Empty;

        public Conexion()
        {
            var builder = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            _cadenaSql = builder.GetSection("ConnectionStrings:cadenaSql").Value;
        }

        public string PasameLaCadena()
        {
            return _cadenaSql;
        }
    }
}
