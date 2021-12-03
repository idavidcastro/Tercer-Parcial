using Entidad;
using Lógica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónGUI
{
    public partial class todo : Form
    {
        FacturaService facturaService;
        PagoService pagoService;
        
       public todo()
        {
            InitializeComponent();
            facturaService = new FacturaService(ConfigConnectionString.Cadena);
            pagoService = new PagoService(ConfigConnectionString.Cadena);



            MostrarComboFacturas();
        }

        private void BtnSeleccionarArchivo_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            var respuetsa = openFile.ShowDialog();
            if (respuetsa == DialogResult.OK && openFile.FileName != null)
            {
                string file = openFile.FileName;
                TxtRutaArchivo.Text = openFile.FileName;
            }
        }

        private void BtnCargarArchivo_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();

            var ruta = TxtRutaArchivo.Text;
            if (ruta != " ")
            {
                string mensaje = facturaService.GuardarArchivo(TxtRutaArchivo.Text); 
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Seleccione un Archivo para cargar");
            }
        }
        

        public void MostrarComboFacturas()
        {
            List<Factura> facturas = new List<Factura>();

            facturas = facturaService.ConsultarFacturas();

            CmbCodigoFactura.DataSource = facturas;
            CmbCodigoFactura.DisplayMember = "NumeroFactura";
            
        }

        private void todo_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsultarFacturass_Click(object sender, EventArgs e)
        {
            ConsultaReponseFactura respuesta;
            dataGridView1.DataSource = null;

            respuesta = facturaService.ConsultarListFacturas(CmbCodigoFactura.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dataGridView1.DataSource = respuesta.Facturas;
            }

            //dataGridView1.DataSource = facturas;
        }

        private void BtnSeleccionarArchivoPago_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            var respuetsa = openFile.ShowDialog();
            if (respuetsa == DialogResult.OK && openFile.FileName != null)
            {
                string file = openFile.FileName;
                TxtRutaArchivoPago.Text = openFile.FileName;
            }
        }

        private void BtnCargarArchivoPago_Click(object sender, EventArgs e)
        {


            var ruta = TxtRutaArchivo.Text;
            if (ruta != " ")
            {
                string mensaje = pagoService.GuardarArchivo(TxtRutaArchivoPago.Text);
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Seleccione un Archivo para cargar");
            }
        }

        private void BtnConsultarPago_Click(object sender, EventArgs e)
        {
            ConsultaReponsePago respuesta;
            dataGridView1.DataSource = null;

            respuesta = pagoService.ConsultarListPagos(TxtNumeroPago.Text);

            if (respuesta.Error)
            {
                MessageBox.Show(respuesta.Mensaje);
            }
            else
            {
                dataGridView2.DataSource = respuesta.Pagos;
            }
        }
    }
}
