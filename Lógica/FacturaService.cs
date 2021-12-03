using Datos;
using Entidad;
using System;
using System.Collections.Generic;

namespace Lógica
{
    public class FacturaService
    {
        FacturaRepository facturaRepository;
        ConnectionManager connectionManager;

        public FacturaService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            facturaRepository = new FacturaRepository(connectionManager.Connetion);
        }

        public string GuardarArchivo(string archivo)
        {
            try
            {
                connectionManager.Open();
                List<Factura> facturas = new List<Factura>();

                facturas = facturaRepository.MapearArchivo(archivo);

                if (facturas != null)
                {

                    facturaRepository.CargarArchivo(facturas);
                    return "Los datos del archivo se cargaron correctamente";

                }
                else
                {
                    return "ERROR al mapear el archivo";
                }
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public ConsultaReponseFactura ConsultarListFacturas(string filtro)
        {
            try
            {
                connectionManager.Open();
                if (filtro == "Todos")
                {
                    return new ConsultaReponseFactura(facturaRepository.ConsultarTodasFacturas());
                }
                else
                {
                    return new ConsultaReponseFactura(facturaRepository.ConsultarFiltroFacturas(filtro));
                }

            }
            catch (Exception exception)
            {
                return new ConsultaReponseFactura("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public List<Factura> ConsultarFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            try
            {
                connectionManager.Open();
                facturas = facturaRepository.ConsultarTodasFacturas();
            }
            catch (Exception exception)
            {

            }
            finally
            {
                connectionManager.Close();
            }
            return facturas;
        }
    }




    public class ConsultaReponseFactura
    {
        public List<Factura> Facturas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaReponseFactura(List<Factura> facturas)
        {
            Facturas = facturas;
            Error = false;
        }

        public ConsultaReponseFactura(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
