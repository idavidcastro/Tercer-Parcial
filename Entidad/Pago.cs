using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Pago
    {
        public Banco NitBanco { get; set; }
        public Factura CodigoFactura { get; set; }
        public string ValorPago { get; set; }
    }
}
