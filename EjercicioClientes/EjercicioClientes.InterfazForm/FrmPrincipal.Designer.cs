
namespace EjercicioClientes.InterfazForm
{
    partial class FrmPrincipal
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
            this._btnAlta = new System.Windows.Forms.Button();
            this._txtNombre = new System.Windows.Forms.TextBox();
            this._txtApellido = new System.Windows.Forms.TextBox();
            this._lblNombre = new System.Windows.Forms.Label();
            this._lblApellido = new System.Windows.Forms.Label();
            this._lblListaClientes = new System.Windows.Forms.Label();
            this._btnCuentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnAlta
            // 
            this._btnAlta.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._btnAlta.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnAlta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnAlta.Location = new System.Drawing.Point(51, 188);
            this._btnAlta.Name = "_btnAlta";
            this._btnAlta.Size = new System.Drawing.Size(279, 79);
            this._btnAlta.TabIndex = 0;
            this._btnAlta.Text = "Alta Cliente";
            this._btnAlta.UseVisualStyleBackColor = false;
            this._btnAlta.Click += new System.EventHandler(this._btnAlta_Click);
            // 
            // _txtNombre
            // 
            this._txtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtNombre.Location = new System.Drawing.Point(154, 68);
            this._txtNombre.Name = "_txtNombre";
            this._txtNombre.Size = new System.Drawing.Size(176, 27);
            this._txtNombre.TabIndex = 1;
            // 
            // _txtApellido
            // 
            this._txtApellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtApellido.Location = new System.Drawing.Point(154, 111);
            this._txtApellido.Name = "_txtApellido";
            this._txtApellido.Size = new System.Drawing.Size(176, 27);
            this._txtApellido.TabIndex = 2;
            // 
            // _lblNombre
            // 
            this._lblNombre.AutoSize = true;
            this._lblNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblNombre.Location = new System.Drawing.Point(48, 71);
            this._lblNombre.Name = "_lblNombre";
            this._lblNombre.Size = new System.Drawing.Size(71, 18);
            this._lblNombre.TabIndex = 3;
            this._lblNombre.Text = "Nombre";
            // 
            // _lblApellido
            // 
            this._lblApellido.AutoSize = true;
            this._lblApellido.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblApellido.Location = new System.Drawing.Point(48, 117);
            this._lblApellido.Name = "_lblApellido";
            this._lblApellido.Size = new System.Drawing.Size(74, 18);
            this._lblApellido.TabIndex = 4;
            this._lblApellido.Text = "Apellido";
            // 
            // _lblListaClientes
            // 
            this._lblListaClientes.AutoSize = true;
            this._lblListaClientes.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblListaClientes.ForeColor = System.Drawing.Color.DarkRed;
            this._lblListaClientes.Location = new System.Drawing.Point(378, 68);
            this._lblListaClientes.Name = "_lblListaClientes";
            this._lblListaClientes.Size = new System.Drawing.Size(25, 32);
            this._lblListaClientes.TabIndex = 5;
            this._lblListaClientes.Text = ".";
            // 
            // _btnCuentas
            // 
            this._btnCuentas.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this._btnCuentas.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btnCuentas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnCuentas.Location = new System.Drawing.Point(51, 288);
            this._btnCuentas.Name = "_btnCuentas";
            this._btnCuentas.Size = new System.Drawing.Size(279, 79);
            this._btnCuentas.TabIndex = 6;
            this._btnCuentas.Text = "Menú Cuentas";
            this._btnCuentas.UseVisualStyleBackColor = false;
            this._btnCuentas.Click += new System.EventHandler(this._btnCuentas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 424);
            this.Controls.Add(this._btnCuentas);
            this.Controls.Add(this._lblListaClientes);
            this.Controls.Add(this._lblApellido);
            this.Controls.Add(this._lblNombre);
            this.Controls.Add(this._txtApellido);
            this.Controls.Add(this._txtNombre);
            this.Controls.Add(this._btnAlta);
            this.Name = "FrmPrincipal";
            this.Text = "Formulario Alta Cliente";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnAlta;
        private System.Windows.Forms.TextBox _txtNombre;
        private System.Windows.Forms.TextBox _txtApellido;
        private System.Windows.Forms.Label _lblNombre;
        private System.Windows.Forms.Label _lblApellido;
        private System.Windows.Forms.Label _lblListaClientes;
        private System.Windows.Forms.Button _btnCuentas;
    }
}