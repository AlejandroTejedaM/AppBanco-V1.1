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
            bMovimientos.Location = new Point(3, 98);
            bMovimientos.Name = "bMovimientos";
            bMovimientos.Size = new Size(110, 51);
            bMovimientos.TabIndex = 0;
            bMovimientos.Text = "MOVIMIENTOS";
            bMovimientos.UseVisualStyleBackColor = true;
            bMovimientos.Click += bMovimientos_Click;
            // 
            // bNuevaTrans
            // 
            bNuevaTrans.Location = new Point(152, 98);
            bNuevaTrans.Name = "bNuevaTrans";
            bNuevaTrans.Size = new Size(110, 51);
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
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(98, 11);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(98, 69);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(164, 23);
            txtSaldo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 72);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Saldo";
            // 
            // txtNoCuenta
            // 
            txtNoCuenta.Location = new Point(98, 40);
            txtNoCuenta.Name = "txtNoCuenta";
            txtNoCuenta.Size = new Size(164, 23);
            txtNoCuenta.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 43);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "No. Cuenta";
            // 
            // CuentaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(txtNoCuenta);
            Controls.Add(label3);
            Controls.Add(txtSaldo);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(bNuevaTrans);
            Controls.Add(bMovimientos);
            Name = "CuentaControl";
            Size = new Size(265, 155);
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
