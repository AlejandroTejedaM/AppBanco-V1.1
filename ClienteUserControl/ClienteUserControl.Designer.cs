namespace ClienteUserControl
{
    partial class ClienteUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbImagenCliente = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtNoCliente = new TextBox();
            txtEdad = new TextBox();
            btnMostrarCuentas = new Button();
            txtSexo = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbImagenCliente).BeginInit();
            SuspendLayout();
            // 
            // pbImagenCliente
            // 
            pbImagenCliente.Location = new Point(3, 4);
            pbImagenCliente.Margin = new Padding(3, 4, 3, 4);
            pbImagenCliente.Name = "pbImagenCliente";
            pbImagenCliente.Size = new Size(93, 111);
            pbImagenCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenCliente.TabIndex = 0;
            pbImagenCliente.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 11);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 48);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "No.Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 83);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 3;
            label3.Text = "Sexo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(167, 7);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(220, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtNoCliente
            // 
            txtNoCliente.Location = new Point(167, 43);
            txtNoCliente.Margin = new Padding(3, 4, 3, 4);
            txtNoCliente.Name = "txtNoCliente";
            txtNoCliente.Size = new Size(130, 27);
            txtNoCliente.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(242, 79);
            txtEdad.Margin = new Padding(3, 4, 3, 4);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(54, 27);
            txtEdad.TabIndex = 6;
            // 
            // btnMostrarCuentas
            // 
            btnMostrarCuentas.Location = new Point(304, 43);
            btnMostrarCuentas.Margin = new Padding(3, 4, 3, 4);
            btnMostrarCuentas.Name = "btnMostrarCuentas";
            btnMostrarCuentas.Size = new Size(83, 72);
            btnMostrarCuentas.TabIndex = 7;
            btnMostrarCuentas.Text = "Cuentas";
            btnMostrarCuentas.UseVisualStyleBackColor = true;
            btnMostrarCuentas.Click += BtnMostrarCuentas_Click;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(146, 79);
            txtSexo.Margin = new Padding(3, 4, 3, 4);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(54, 27);
            txtSexo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 83);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 9;
            label4.Text = "Edad";
            // 
            // ClienteUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(txtSexo);
            Controls.Add(btnMostrarCuentas);
            Controls.Add(txtEdad);
            Controls.Add(txtNoCliente);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbImagenCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClienteUserControl";
            Size = new Size(390, 119);
            ((System.ComponentModel.ISupportInitialize)pbImagenCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbImagenCliente;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtNoCliente;
        private TextBox txtEdad;
        private Button btnMostrarCuentas;
        private TextBox txtSexo;
        private Label label4;
    }
}