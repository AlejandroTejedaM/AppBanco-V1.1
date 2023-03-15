namespace CuentaUserControl
{
    partial class CuentaControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            bMovimientos = new Button();
            bNuevaTrans = new Button();
            label1 = new Label();
            txtNombre = new TextBox();
            txtSaldo = new TextBox();
            label2 = new Label();
            txtNoCuenta = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // bMovimientos
            // 
            bMovimientos.Location = new Point(316, 12);
            bMovimientos.Margin = new Padding(3, 4, 3, 4);
            bMovimientos.Name = "bMovimientos";
            bMovimientos.Size = new Size(126, 32);
            bMovimientos.TabIndex = 0;
            bMovimientos.Text = "MOVIMIENTOS";
            bMovimientos.UseVisualStyleBackColor = true;
            bMovimientos.Click += bMovimientos_Click;
            // 
            // bNuevaTrans
            // 
            bNuevaTrans.Location = new Point(316, 57);
            bNuevaTrans.Margin = new Padding(3, 4, 3, 4);
            bNuevaTrans.Name = "bNuevaTrans";
            bNuevaTrans.Size = new Size(126, 68);
            bNuevaTrans.TabIndex = 1;
            bNuevaTrans.Text = "NUEVA TRANSACCIÓN";
            bNuevaTrans.UseVisualStyleBackColor = true;
            bNuevaTrans.Click += bNuevaTrans_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 15);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(187, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(112, 92);
            txtSaldo.Margin = new Padding(3, 4, 3, 4);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(187, 27);
            txtSaldo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 96);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 4;
            label2.Text = "Saldo";
            // 
            // txtNoCuenta
            // 
            txtNoCuenta.Location = new Point(112, 53);
            txtNoCuenta.Margin = new Padding(3, 4, 3, 4);
            txtNoCuenta.Name = "txtNoCuenta";
            txtNoCuenta.Size = new Size(187, 27);
            txtNoCuenta.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 6;
            label3.Text = "No. Cuenta";
            // 
            // CuentaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            Controls.Add(txtNoCuenta);
            Controls.Add(label3);
            Controls.Add(txtSaldo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(bNuevaTrans);
            Controls.Add(bMovimientos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CuentaControl";
            Size = new Size(447, 136);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bMovimientos;
        private Button bNuevaTrans;
        private Label label1;
        private TextBox txtNombre;
        private TextBox txtSaldo;
        private Label label2;
        private TextBox txtNoCuenta;
        private Label label3;
    }
}
