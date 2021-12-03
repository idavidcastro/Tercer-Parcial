using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class FacturaRepository
    {
        DbConnection _connection;
        public FacturaRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public Factura MapearArchivo(string archivo)
        {
            FileStream file = new FileStream(archivo, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(file);
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                Factura factura = new Factura();
                {
                    factura.NumeroFactura = dato[0];
                    factura.Identificacion = dato[1];
                    factura.CodigoServicios = new Servicios();
                    factura.CodigoServicios.Codigo = dato[2];
                    factura.Valor = dato[3];
                    factura.Estado = dato[4];

                    return factura;
                };
            }
            lector.Close();
            file.Close();
            return null;
        }
        public void CargarArchivo()
        {
            Factura factura = new Factura();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert into Factura(NumeroFactura, identificacion, CodigoServicio, Valor, Estado) " +
                                      "values(@NumeroFactura, @identificacion, @CodigoServicio, @Valor, @Estado)";
                command.Parameters.Add(new SqlParameter("@NumeroFactura", factura.NumeroFactura));
                command.Parameters.Add(new SqlParameter("@identificacion", factura.Identificacion));
                command.Parameters.Add(new SqlParameter("@CodigoServicio", factura.CodigoServicios));
                command.Parameters.Add(new SqlParameter("@Valor", factura.Valor));
                command.Parameters.Add(new SqlParameter("@Estado", factura.Estado));

                command.ExecuteNonQuery();
            }
        }
    }
}
