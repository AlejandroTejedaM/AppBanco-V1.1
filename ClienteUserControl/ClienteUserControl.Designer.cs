namespace ClienteUserControl
{
    partial class UserControl1
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
            pbImagenCliente.Location = new Point(3, 3);
            pbImagenCliente.Name = "pbImagenCliente";
            pbImagenCliente.Size = new Size(81, 83);
            pbImagenCliente.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagenCliente.TabIndex = 0;
            pbImagenCliente.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 8);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 36);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "No.Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 62);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 3;
            label3.Text = "Sexo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtNoCliente
            // 
            txtNoCliente.Location = new Point(146, 32);
            txtNoCliente.Name = "txtNoCliente";
            txtNoCliente.Size = new Size(114, 23);
            txtNoCliente.TabIndex = 5;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(212, 59);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(48, 23);
            txtEdad.TabIndex = 6;
            // 
            // btnMostrarCuentas
            // 
            btnMostrarCuentas.Location = new Point(266, 32);
            btnMostrarCuentas.Name = "btnMostrarCuentas";
            btnMostrarCuentas.Size = new Size(59, 54);
            btnMostrarCuentas.TabIndex = 7;
            btnMostrarCuentas.Text = "Cuentas";
            btnMostrarCuentas.UseVisualStyleBackColor = true;
            btnMostrarCuentas.Click += BtnMostrarCuentas_Click;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(128, 59);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(48, 23);
            txtSexo.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(176, 62);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 9;
            label4.Text = "Edad";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
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
            Name = "UserControl1";
            Size = new Size(332, 89);
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