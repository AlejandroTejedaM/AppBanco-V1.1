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
            txtCuenta = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            Nombre = new Label();
            flpCuentas = new FlowLayoutPanel();
            saveFileDialog1 = new SaveFileDialog();
            button1 = new Button();
            saveFileDialog2 = new SaveFileDialog();
            label1 = new Label();
            txtSaldoNeto = new TextBox();
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
            // txtCuenta
            // 
            txtCuenta.Location = new Point(297, 120);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(282, 23);
            txtCuenta.TabIndex = 25;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(297, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(138, 112);
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
            Nombre.Location = new Point(166, 59);
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
            // button1
            // 
            button1.Location = new Point(881, 563);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 32;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(138, 179);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 33;
            label1.Text = "Saldo neto";
            // 
            // txtSaldoNeto
            // 
            txtSaldoNeto.Location = new Point(297, 193);
            txtSaldoNeto.Name = "txtSaldoNeto";
            txtSaldoNeto.Size = new Size(282, 23);
            txtSaldoNeto.TabIndex = 34;
            // 
            // frmCuentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 598);
            Controls.Add(txtSaldoNeto);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(txtCuenta);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(flpCuentas);
            Name = "frmCuentas";
            Text = "CUENTAS";
            FormClosing += frmCuentas_FormClosing;
            Load += frmCuentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarCuenta;
        private TextBox txtCuenta;
        private TextBox txtNombre;
        private Label label2;
        private Label Nombre;
        private FlowLayoutPanel flpCuentas;
        private SaveFileDialog saveFileDialog1;
        private Button button1;
        private SaveFileDialog saveFileDialog2;
        private Label label1;
        private TextBox txtSaldoNeto;
    }
}