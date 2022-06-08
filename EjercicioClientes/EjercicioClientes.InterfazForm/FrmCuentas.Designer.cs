
namespace EjercicioClientes.InterfazForm
{
    partial class FrmCuentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblDescripcion = new System.Windows.Forms.Label();
            this._lblCliente = new System.Windows.Forms.Label();
            this._txtDescripcion = new System.Windows.Forms.TextBox();
            this._btnAltaCuenta = new System.Windows.Forms.Button();
            this._btnVolver = new System.Windows.Forms.Button();
            this._btnConsulta = new System.Windows.Forms.Button();
            this._cmbClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _lblDescripcion
            // 
            this._lblDescripcion.AutoSize = true;
            this._lblDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblDescripcion.Location = new System.Drawing.Point(36, 164);
            this._lblDescripcion.Name = "_lblDescripcion";
            this._lblDescripcion.Size = new System.Drawing.Size(101, 18);
            this._lblDescripcion.TabIndex = 8;
            this._lblDescripcion.Text = "Descripción";
            // 
            // _lblCliente
            // 
            this._lblCliente.AutoSize = true;
            this._lblCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblCliente.Location = new System.Drawing.Point(45, 112);
            this._lblCliente.Name = "_lblCliente";
            this._lblCliente.Size = new System.Drawing.Size(66, 18);
            this._lblCliente.TabIndex = 7;
            this._lblCliente.Text = "Cliente";
            // 
            // _txtDescripcion
            // 
            this._txtDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtDescripcion.Location = new System.Drawing.Point(142, 158);
            this._txtDescripcion.Name = "_txtDescripcion";
            this._txtDescripcion.Size = new System.Drawing.Size(324, 27);
            this._txtDescripcion.TabIndex = 6;
            // 
            // _btnAltaCuenta
            // 
            this._btnAltaCuenta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._btnAltaCuenta.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAltaCuenta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnAltaCuenta.Location = new System.Drawing.Point(39, 206);
            this._btnAltaCuenta.Name = "_btnAltaCuenta";
            this._btnAltaCuenta.Size = new System.Drawing.Size(279, 79);
            this._btnAltaCuenta.TabIndex = 9;
            this._btnAltaCuenta.Text = "Alta Cuenta";
            this._btnAltaCuenta.UseVisualStyleBackColor = false;
            this._btnAltaCuenta.Click += new System.EventHandler(this._btnAltaCuenta_Click);
            // 
            // _btnVolver
            // 
            this._btnVolver.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._btnVolver.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnVolver.Location = new System.Drawing.Point(39, 305);
            this._btnVolver.Name = "_btnVolver";
            this._btnVolver.Size = new System.Drawing.Size(279, 79);
            this._btnVolver.TabIndex = 10;
            this._btnVolver.Text = "Volver";
            this._btnVolver.UseVisualStyleBackColor = false;
            this._btnVolver.Click += new System.EventHandler(this._btnVolver_Click);
            // 
            // _btnConsulta
            // 
            this._btnConsulta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._btnConsulta.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnConsulta.Location = new System.Drawing.Point(486, 88);
            this._btnConsulta.Name = "_btnConsulta";
            this._btnConsulta.Size = new System.Drawing.Size(124, 60);
            this._btnConsulta.TabIndex = 11;
            this._btnConsulta.Text = "Consultar Cuenta";
            this._btnConsulta.UseVisualStyleBackColor = false;
            this._btnConsulta.Click += new System.EventHandler(this._btnConsulta_Click);
            // 
            // _cmbClientes
            // 
            this._cmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbClientes.Font = new System.Drawing.Font("Verdana", 12F);
            this._cmbClientes.FormattingEnabled = true;
            this._cmbClientes.Location = new System.Drawing.Point(142, 112);
            this._cmbClientes.Name = "_cmbClientes";
            this._cmbClientes.Size = new System.Drawing.Size(324, 26);
            this._cmbClientes.TabIndex = 12;
            this._cmbClientes.SelectedIndexChanged += new System.EventHandler(this._cmbClientes_SelectedIndexChanged);
            // 
            // FrmCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._cmbClientes);
            this.Controls.Add(this._btnConsulta);
            this.Controls.Add(this._btnVolver);
            this.Controls.Add(this._btnAltaCuenta);
            this.Controls.Add(this._lblDescripcion);
            this.Controls.Add(this._lblCliente);
            this.Controls.Add(this._txtDescripcion);
            this.Name = "FrmCuentas";
            this.Text = "FrmCuentas";
            this.Load += new System.EventHandler(this.FrmCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblDescripcion;
        private System.Windows.Forms.Label _lblCliente;
        private System.Windows.Forms.TextBox _txtDescripcion;
        private System.Windows.Forms.Button _btnAltaCuenta;
        private System.Windows.Forms.Button _btnVolver;
        private System.Windows.Forms.Button _btnConsulta;
        private System.Windows.Forms.ComboBox _cmbClientes;
    }
}