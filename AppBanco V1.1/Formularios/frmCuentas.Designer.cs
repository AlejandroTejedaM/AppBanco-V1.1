namespace AppBanco_V1._1
{
    partial class frmCuentas
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
            btnAgregarCuenta = new Button();
            txtMonto = new TextBox();
            txtFecha = new TextBox();
            txtCuenta = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nombre = new Label();
            flpCuentas = new FlowLayoutPanel();
            saveFileDialog1 = new SaveFileDialog();
            label4 = new Label();
            txtSaldoNeto = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCuenta.Location = new Point(725, 19);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(194, 61);
            btnAgregarCuenta.TabIndex = 28;
            btnAgregarCuenta.Text = "AGREGAR CUENTA";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += BtnAgregarCuenta_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(288, 176);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(282, 23);
            txtMonto.TabIndex = 27;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(288, 122);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(282, 23);
            txtFecha.TabIndex = 26;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(288, 72);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(282, 23);
            txtCuenta.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(288, 19);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(99, 167);
            label1.Name = "label1";
            label1.Size = new Size(173, 37);
            label1.TabIndex = 23;
            label1.Text = "Monto inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(9, 111);
            label3.Name = "label3";
            label3.Size = new Size(263, 37);
            label3.TabIndex = 22;
            label3.Text = "Fecha de transacción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(129, 64);
            label2.Name = "label2";
            label2.Size = new Size(143, 37);
            label2.TabIndex = 21;
            label2.Text = "No.Cuenta";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = SystemColors.ActiveCaptionText;
            Nombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.Cornsilk;
            Nombre.Location = new Point(157, 11);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(115, 37);
            Nombre.TabIndex = 20;
            Nombre.Text = "Nombre";
            // 
            // flpCuentas
            // 
            flpCuentas.Location = new Point(28, 236);
            flpCuentas.Name = "flpCuentas";
            flpCuentas.Size = new Size(928, 318);
            flpCuentas.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(698, 107);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 29;
            label4.Text = "Saldo:";
            // 
            // txtSaldoNeto
            // 
            txtSaldoNeto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldoNeto.Location = new Point(698, 156);
            txtSaldoNeto.Name = "txtSaldoNeto";
            txtSaldoNeto.Size = new Size(258, 34);
            txtSaldoNeto.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(662, 153);
            label5.Name = "label5";
            label5.Size = new Size(32, 37);
            label5.TabIndex = 31;
            label5.Text = "$";
            // 
            // frmCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 598);
            Controls.Add(label5);
            Controls.Add(txtSaldoNeto);
            Controls.Add(label4);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(txtMonto);
            Controls.Add(txtFecha);
            Controls.Add(txtCuenta);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(flpCuentas);
            Name = "frmCuentas";
            Text = "CUENTAS";
            FormClosing += frmCuentas_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCuenta;
        private TextBox txtMonto;
        private TextBox txtFecha;
        private TextBox txtCuenta;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label Nombre;
        private FlowLayoutPanel flpCuentas;
        private SaveFileDialog saveFileDialog1;
        private Label label4;
        public TextBox txtSaldoNeto;
        private Label label5;
    }
}