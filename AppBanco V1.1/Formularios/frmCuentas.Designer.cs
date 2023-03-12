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
            button1 = new Button();
            saveFileDialog2 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCuenta.Location = new Point(1036, 32);
            btnAgregarCuenta.Margin = new Padding(4, 5, 4, 5);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(277, 102);
            btnAgregarCuenta.TabIndex = 28;
            btnAgregarCuenta.Text = "AGREGAR CUENTA";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += BtnAgregarCuenta_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(411, 293);
            txtMonto.Margin = new Padding(4, 5, 4, 5);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(401, 31);
            txtMonto.TabIndex = 27;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(411, 203);
            txtFecha.Margin = new Padding(4, 5, 4, 5);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(401, 31);
            txtFecha.TabIndex = 26;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(411, 120);
            txtCuenta.Margin = new Padding(4, 5, 4, 5);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(401, 31);
            txtCuenta.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(411, 32);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(401, 31);
            txtNombre.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(141, 278);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 54);
            label1.TabIndex = 23;
            label1.Text = "Monto inicial";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(13, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(392, 54);
            label3.TabIndex = 22;
            label3.Text = "Fecha de transacción";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(184, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 54);
            label2.TabIndex = 21;
            label2.Text = "No.Cuenta";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = SystemColors.ActiveCaptionText;
            Nombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.Cornsilk;
            Nombre.Location = new Point(224, 18);
            Nombre.Margin = new Padding(4, 0, 4, 0);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(169, 54);
            Nombre.TabIndex = 20;
            Nombre.Text = "Nombre";
            // 
            // flpCuentas
            // 
            flpCuentas.Location = new Point(40, 393);
            flpCuentas.Margin = new Padding(4, 5, 4, 5);
            flpCuentas.Name = "flpCuentas";
            flpCuentas.Size = new Size(1326, 530);
            flpCuentas.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(997, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(130, 54);
            label4.TabIndex = 29;
            label4.Text = "Saldo:";
            // 
            // txtSaldoNeto
            // 
            txtSaldoNeto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtSaldoNeto.Location = new Point(997, 260);
            txtSaldoNeto.Margin = new Padding(4, 5, 4, 5);
            txtSaldoNeto.Name = "txtSaldoNeto";
            txtSaldoNeto.Size = new Size(367, 47);
            txtSaldoNeto.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(946, 255);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(45, 54);
            label5.TabIndex = 31;
            label5.Text = "$";
            // 
            // button1
            // 
            button1.Location = new Point(1259, 938);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 32;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmCuentas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 997);
            Controls.Add(button1);
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
            Margin = new Padding(4, 5, 4, 5);
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
        private Button button1;
        private SaveFileDialog saveFileDialog2;
    }
}