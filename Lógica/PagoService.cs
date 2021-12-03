using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class PagoService
    {
        PagoRepository pagoRepository;
        ConnectionManager connectionManager;

        public PagoService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            pagoRepository = new PagoRepository(connectionManager.Connetion);
        }

        public string GuardarArchivo(string archivo)
        {
            try
            {
                connectionManager.Open();
                List<Pago> pagos = new List<Pago>();

                pagos = pagoRepository.MapearArchivo(archivo);

                if (pagos != null)
                {

                    pagoRepository.CargarArchivoPago(pagos);
                    return "Se cargaron correctamente los datos del archivo";

                }
                else
                {
                    return "ERROR al mapear el archivo";
                }
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public ConsultaReponsePago ConsultarListPagos(string filtro)
        {
            try
            {
                connectionManager.Open();
                if (filtro == "Todos")
                {
                    return new ConsultaReponsePago(pagoRepository.ConsultarTodosPagos());
                }
                else
                {
                    return new ConsultaReponsePago(pagoRepository.ConsultarFiltroPago(filtro));
                }

            }
            catch (Exception exception)
            {
                return new ConsultaReponsePago("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public List<Pago> ConsultarPagos()
        {
            List<Pago> pagos = new List<Pago>();

            try
            {
                connectionManager.Open();
                pagos = pagoRepository.ConsultarTodosPagos();
            }
            catch (Exception exception)
            {

            }
            finally
            {
                connectionManager.Close();
            }
            return pagos;
        }
    }


    public class ConsultaReponsePago
    {
        public List<Pago> Pagos { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaReponsePago(List<Pago> pagos)
        {
            Pagos = pagos;
            Error = false;
        }

        public ConsultaReponsePago(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
