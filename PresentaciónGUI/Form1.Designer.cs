
namespace PresentaciónGUI
{
    partial class todo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.BtnCargarArchivo = new System.Windows.Forms.Button();
            this.TxtRutaArchivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmbCodigoFactura = new System.Windows.Forms.ComboBox();
            this.BtnConsultarFacturass = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRutaArchivoPago = new System.Windows.Forms.TextBox();
            this.BtnSeleccionarArchivoPago = new System.Windows.Forms.Button();
            this.BtnCargarArchivoPago = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNumeroPago = new System.Windows.Forms.TextBox();
            this.BtnConsultarPago = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnSeleccionarArchivo);
            this.panel1.Controls.Add(this.BtnCargarArchivo);
            this.panel1.Controls.Add(this.TxtRutaArchivo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 174);
            this.panel1.TabIndex = 0;
            // 
            // BtnSeleccionarArchivo
            // 
            this.BtnSeleccionarArchivo.Location = new System.Drawing.Point(294, 68);
            this.BtnSeleccionarArchivo.Name = "BtnSeleccionarArchivo";
            this.BtnSeleccionarArchivo.Size = new System.Drawing.Size(128, 29);
            this.BtnSeleccionarArchivo.TabIndex = 4;
            this.BtnSeleccionarArchivo.Text = "Seleccionar";
            this.BtnSeleccionarArchivo.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivo.Click += new System.EventHandler(this.BtnSeleccionarArchivo_Click);
            // 
            // BtnCargarArchivo
            // 
            this.BtnCargarArchivo.Location = new System.Drawing.Point(125, 127);
            this.BtnCargarArchivo.Name = "BtnCargarArchivo";
            this.BtnCargarArchivo.Size = new System.Drawing.Size(191, 32);
            this.BtnCargarArchivo.TabIndex = 3;
            this.BtnCargarArchivo.Text = "Cargar Archivo";
            this.BtnCargarArchivo.UseVisualStyleBackColor = true;
            this.BtnCargarArchivo.Click += new System.EventHandler(this.BtnCargarArchivo_Click);
            // 
            // TxtRutaArchivo
            // 
            this.TxtRutaArchivo.Location = new System.Drawing.Point(81, 71);
            this.TxtRutaArchivo.Name = "TxtRutaArchivo";
            this.TxtRutaArchivo.Size = new System.Drawing.Size(191, 22);
            this.TxtRutaArchivo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ruta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargar Facturas";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnConsultarFacturass);
            this.panel2.Controls.Add(this.CmbCodigoFactura);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(522, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 352);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Factura";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(601, 221);
            this.dataGridView1.TabIndex = 3;
            // 
            // CmbCodigoFactura
            // 
            this.CmbCodigoFactura.FormattingEnabled = true;
            this.CmbCodigoFactura.Items.AddRange(new object[] {
            "Todos"});
            this.CmbCodigoFactura.Location = new System.Drawing.Point(89, 43);
            this.CmbCodigoFactura.Name = "CmbCodigoFactura";
            this.CmbCodigoFactura.Size = new System.Drawing.Size(184, 24);
            this.CmbCodigoFactura.TabIndex = 4;
            this.CmbCodigoFactura.Text = "Todos";
            // 
            // BtnConsultarFacturass
            // 
            this.BtnConsultarFacturass.Location = new System.Drawing.Point(312, 37);
            this.BtnConsultarFacturass.Name = "BtnConsultarFacturass";
            this.BtnConsultarFacturass.Size = new System.Drawing.Size(167, 35);
            this.BtnConsultarFacturass.TabIndex = 5;
            this.BtnConsultarFacturass.Text = "Consultar";
            this.BtnConsultarFacturass.UseVisualStyleBackColor = true;
            this.BtnConsultarFacturass.Click += new System.EventHandler(this.BtnConsultarFacturass_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnCargarArchivoPago);
            this.panel3.Controls.Add(this.BtnSeleccionarArchivoPago);
            this.panel3.Controls.Add(this.TxtRutaArchivoPago);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(22, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 165);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cargar Pagos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ruta: ";
            // 
            // TxtRutaArchivoPago
            // 
            this.TxtRutaArchivoPago.Location = new System.Drawing.Point(81, 56);
            this.TxtRutaArchivoPago.Name = "TxtRutaArchivoPago";
            this.TxtRutaArchivoPago.Size = new System.Drawing.Size(191, 22);
            this.TxtRutaArchivoPago.TabIndex = 2;
            // 
            // BtnSeleccionarArchivoPago
            // 
            this.BtnSeleccionarArchivoPago.Location = new System.Drawing.Point(294, 53);
            this.BtnSeleccionarArchivoPago.Name = "BtnSeleccionarArchivoPago";
            this.BtnSeleccionarArchivoPago.Size = new System.Drawing.Size(128, 35);
            this.BtnSeleccionarArchivoPago.TabIndex = 3;
            this.BtnSeleccionarArchivoPago.Text = "Seleccionar";
            this.BtnSeleccionarArchivoPago.UseVisualStyleBackColor = true;
            this.BtnSeleccionarArchivoPago.Click += new System.EventHandler(this.BtnSeleccionarArchivoPago_Click);
            // 
            // BtnCargarArchivoPago
            // 
            this.BtnCargarArchivoPago.Location = new System.Drawing.Point(113, 108);
            this.BtnCargarArchivoPago.Name = "BtnCargarArchivoPago";
            this.BtnCargarArchivoPago.Size = new System.Drawing.Size(203, 38);
            this.BtnCargarArchivoPago.TabIndex = 4;
            this.BtnCargarArchivoPago.Text = "Cargar Archivo";
            this.BtnCargarArchivoPago.UseVisualStyleBackColor = true;
            this.BtnCargarArchivoPago.Click += new System.EventHandler(this.BtnCargarArchivoPago_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.BtnConsultarPago);
            this.panel4.Controls.Add(this.TxtNumeroPago);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(522, 415);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(651, 334);
            this.panel4.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pagos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Número de pago:";
            // 
            // TxtNumeroPago
            // 
            this.TxtNumeroPago.Location = new System.Drawing.Point(178, 59);
            this.TxtNumeroPago.Name = "TxtNumeroPago";
            this.TxtNumeroPago.Size = new System.Drawing.Size(165, 22);
            this.TxtNumeroPago.TabIndex = 6;
            // 
            // BtnConsultarPago
            // 
            this.BtnConsultarPago.Location = new System.Drawing.Point(375, 52);
            this.BtnConsultarPago.Name = "BtnConsultarPago";
            this.BtnConsultarPago.Size = new System.Drawing.Size(155, 36);
            this.BtnConsultarPago.TabIndex = 7;
            this.BtnConsultarPago.Text = "Consultar";
            this.BtnConsultarPago.UseVisualStyleBackColor = true;
            this.BtnConsultarPago.Click += new System.EventHandler(this.BtnConsultarPago_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 108);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(596, 210);
            this.dataGridView2.TabIndex = 8;
            // 
            // todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 773);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "todo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.todo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtRutaArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCargarArchivo;
        private System.Windows.Forms.Button BtnSeleccionarArchivo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbCodigoFactura;
        private System.Windows.Forms.Button BtnConsultarFacturass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCargarArchivoPago;
        private System.Windows.Forms.Button BtnSeleccionarArchivoPago;
        private System.Windows.Forms.TextBox TxtRutaArchivoPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnConsultarPago;
        private System.Windows.Forms.TextBox TxtNumeroPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

