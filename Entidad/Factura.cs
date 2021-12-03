using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Factura
    {
        public string NumeroFactura { get; set; }
        public string Identificacion { get; set; }
        public Servicios CodigoServicios { get; set; }
        public string Valor { get; set; }
        public string Estado { get; set; }
    }
}
