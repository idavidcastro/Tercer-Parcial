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
    public class PagoRepository
    {
        DbConnection _connection;
        public PagoRepository(DbConnection connection)
        {
            _connection = connection;
        }

        public List<Pago> MapearArchivo(string archivo)
        {
            List<Pago> pagos = new List<Pago>();
            FileStream file = new FileStream(archivo, FileMode.OpenOrCreate);
            StreamReader lector = new StreamReader(file);
            string linea;
            while ((linea = lector.ReadLine()) != null)
            {
                string[] dato = linea.Split(';');
                Pago pago = new Pago();
                {
                    pago.NitBanco = new Banco();
                    pago.NitBanco.Nit = dato[0];
                    pago.CodigoFactura = new Factura();
                    pago.CodigoFactura.NumeroFactura = dato[1];
                    pago.ValorPago = dato[2];
                    
                };
                pagos.Add(pago);
            }
            lector.Close();
            file.Close();
            return pagos;
        }
        public void CargarArchivoPago(List<Pago> pagos)
        {
            foreach (var item in pagos)
            {
                using (var command = _connection.CreateCommand())
                {

                    command.CommandText = "insert into Pago(NitBanco, CodigoFactura, ValorPago) " +
                                      "values(@NitBanco, @CodigoFactura, @ValorPago)";
                    command.Parameters.Add(new SqlParameter("@NitBanco", item.NitBanco.Nit));
                    command.Parameters.Add(new SqlParameter("@CodigoFactura", item.CodigoFactura.NumeroFactura));
                    command.Parameters.Add(new SqlParameter("@ValorPago", item.ValorPago));

                    command.ExecuteNonQuery();
                }
            }

        }
        public List<Pago> ConsultarTodosPagos()
        {
            List<Pago> pagos = new List<Pago>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Pago";
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pago pago = new Pago();
                    pago.NitBanco = new Banco();
                    pago.NitBanco.Nit = reader.GetString(0);
                    pago.CodigoFactura = new Factura();
                    pago.CodigoFactura.NumeroFactura = reader.GetString(1);
                    pago.ValorPago = reader.GetString(2);


                    pagos.Add(pago);
                }
                reader.Close();
            }

            return pagos;
        }
        public List<Pago> ConsultarFiltroPago(string filtro)
        {
            List<Pago> pagos = new List<Pago>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Pago where CodigoFactura=@CodigoFactura";
                command.Parameters.Add(new SqlParameter("@CodigoFactura", filtro));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Pago pago = new Pago();
                    pago.NitBanco = new Banco();
                    pago.NitBanco.Nit = reader.GetString(0);
                    pago.CodigoFactura = new Factura();
                    pago.CodigoFactura.NumeroFactura = reader.GetString(1);
                    pago.ValorPago = reader.GetString(2);


                    pagos.Add(pago);
                }
                reader.Close();
            }

            return pagos;
        }
    }
}
