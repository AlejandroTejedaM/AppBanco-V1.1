﻿namespace AppBank_V1._1
{
    partial class FrmClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flpClientes = new FlowLayoutPanel();
            btnAgregarCuenta = new Button();
            txtEdad = new TextBox();
            txtSexo = new TextBox();
            txtCuenta = new TextBox();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            Nombre = new Label();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // flpClientes
            // 
            flpClientes.Location = new Point(12, 236);
            flpClientes.Name = "flpClientes";
            flpClientes.Size = new Size(928, 295);
            flpClientes.TabIndex = 0;
            // 
            // btnAgregarCuenta
            // 
            btnAgregarCuenta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarCuenta.Location = new Point(680, 85);
            btnAgregarCuenta.Name = "btnAgregarCuenta";
            btnAgregarCuenta.Size = new Size(194, 61);
            btnAgregarCuenta.TabIndex = 18;
            btnAgregarCuenta.Text = "AGREGAR CLIENTE";
            btnAgregarCuenta.UseVisualStyleBackColor = true;
            btnAgregarCuenta.Click += btnAgregarCuenta_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(276, 178);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(282, 23);
            txtEdad.TabIndex = 17;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(276, 123);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(282, 23);
            txtSexo.TabIndex = 16;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(276, 61);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(282, 23);
            txtCuenta.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(276, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(282, 23);
            txtNombre.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(183, 170);
            label1.Name = "label1";
            label1.Size = new Size(77, 37);
            label1.TabIndex = 13;
            label1.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(187, 114);
            label3.Name = "label3";
            label3.Size = new Size(73, 37);
            label3.TabIndex = 12;
            label3.Text = "Sexo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(117, 53);
            label2.Name = "label2";
            label2.Size = new Size(142, 37);
            label2.TabIndex = 11;
            label2.Text = "No.Cliente";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = SystemColors.ActiveCaptionText;
            Nombre.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.Cornsilk;
            Nombre.Location = new Point(145, 4);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(115, 37);
            Nombre.TabIndex = 10;
            Nombre.Text = "Nombre";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(952, 559);
            Controls.Add(btnAgregarCuenta);
            Controls.Add(txtEdad);
            Controls.Add(txtSexo);
            Controls.Add(txtCuenta);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(flpClientes);
            Name = "FrmClientes";
            Text = " ";
            FormClosing += FrmClientes_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpClientes;
        private Button btnAgregarCuenta;
        private TextBox txtEdad;
        private TextBox txtSexo;
        private TextBox txtCuenta;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label Nombre;
        private SaveFileDialog saveFileDialog1;
    }
}
