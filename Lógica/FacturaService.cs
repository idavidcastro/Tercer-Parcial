using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                if (facturaRepository.MapearArchivo(archivo) != null)
                {
                    facturaRepository.CargarArchivo();
                    return "Secargó el archivo a la tabla correctamente!";
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
    }
}
