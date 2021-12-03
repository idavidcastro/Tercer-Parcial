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
        public todo()
        {
            InitializeComponent();
            facturaService = new FacturaService(ConfigConnectionString.Cadena);
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
           

            var ruta = TxtRutaArchivo.Text;
            if (ruta != " ")
            {
                string mensaje = facturaService.GuardarArchivo(TxtRutaArchivo.Text); // validar el cargue
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("Seleccione un Archivo para cargar");
            }
        }
    }
}
