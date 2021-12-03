
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRutaArchivo = new System.Windows.Forms.TextBox();
            this.BtnCargarArchivo = new System.Windows.Forms.Button();
            this.BtnSeleccionarArchivo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cargar Facturas";
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
            // TxtRutaArchivo
            // 
            this.TxtRutaArchivo.Location = new System.Drawing.Point(81, 71);
            this.TxtRutaArchivo.Name = "TxtRutaArchivo";
            this.TxtRutaArchivo.Size = new System.Drawing.Size(191, 22);
            this.TxtRutaArchivo.TabIndex = 2;
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
            // todo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 660);
            this.Controls.Add(this.panel1);
            this.Name = "todo";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtRutaArchivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCargarArchivo;
        private System.Windows.Forms.Button BtnSeleccionarArchivo;
    }
}

