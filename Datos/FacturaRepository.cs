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

        public List<Factura> MapearArchivo(string archivo)
        {
            List<Factura> facturas = new List<Factura>();
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
                };
                facturas.Add(factura); 
            }
            lector.Close();
            file.Close();
            return facturas;
        }
        public void CargarArchivo(List<Factura> facturas)
        {
            foreach (var item in facturas)
            {
                using (var command = _connection.CreateCommand())
                {

                    command.CommandText = "insert into Factura(NumeroFactura, identificacion, CodigoServicio, Valor, Estado) " +
                                      "values(@NumeroFactura, @identificacion, @CodigoServicio, @Valor, @Estado)";
                    command.Parameters.Add(new SqlParameter("@NumeroFactura", item.NumeroFactura));
                    command.Parameters.Add(new SqlParameter("@identificacion", item.Identificacion));
                    command.Parameters.Add(new SqlParameter("@CodigoServicio", item.CodigoServicios.Codigo));
                    command.Parameters.Add(new SqlParameter("@Valor", item.Valor));
                    command.Parameters.Add(new SqlParameter("@Estado", item.Estado));

                    command.ExecuteNonQuery();
                }
            }
      
        }
        public List<Factura> ConsultarTodasFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Factura";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Factura factura = new Factura();
                    factura.NumeroFactura = reader.GetString(0);
                    factura.Identificacion = reader.GetString(1);
                    factura.CodigoServicios = new Servicios();
                    factura.CodigoServicios.Codigo = reader.GetString(2);
                    factura.Valor = reader.GetString(3);
                    factura.Estado = reader.GetString(4);

                    facturas.Add(factura);
                }
                reader.Close();
            }

            return facturas;
        }
        public List<Factura> ConsultarFiltroFacturas(string filtro)
        {
            List<Factura> facturas = new List<Factura>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Factura where NumeroFactura=@NumeroFactura";
                command.Parameters.Add(new SqlParameter("@NumeroFactura", filtro));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Factura factura = new Factura();
                    factura.NumeroFactura = reader.GetString(0);
                    factura.Identificacion = reader.GetString(1);
                    factura.CodigoServicios = new Servicios();
                    factura.CodigoServicios.Codigo = reader.GetString(2);
                    factura.Valor = reader.GetString(3);
                    factura.Estado = reader.GetString(4);

                    facturas.Add(factura);
                }
                reader.Close();
            }

            return facturas;
        }
    }
}
