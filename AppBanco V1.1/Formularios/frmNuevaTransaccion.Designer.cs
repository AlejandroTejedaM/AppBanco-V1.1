namespace AppBanco_V1._1
{
    partial class FrmNuevaTransaccion
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
            btnRegresar = new Button();
            btnRetiro = new Button();
            btnAbono = new Button();
            txtMonto = new TextBox();
            label2 = new Label();
            txtFecha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.Location = new Point(566, 637);
            btnRegresar.Margin = new Padding(4, 5, 4, 5);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(107, 38);
            btnRegresar.TabIndex = 21;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = true;
            // 
            // btnRetiro
            // 
            btnRetiro.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetiro.Location = new Point(376, 490);
            btnRetiro.Margin = new Padding(4, 5, 4, 5);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(223, 88);
            btnRetiro.TabIndex = 20;
            btnRetiro.Text = "RETIRO";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // btnAbono
            // 
            btnAbono.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAbono.Location = new Point(54, 490);
            btnAbono.Margin = new Padding(4, 5, 4, 5);
            btnAbono.Name = "btnAbono";
            btnAbono.Size = new Size(236, 88);
            btnAbono.TabIndex = 19;
            btnAbono.Text = "ABONO";
            btnAbono.UseVisualStyleBackColor = true;
            btnAbono.Click += btnAbono_Click;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(303, 233);
            txtMonto.Margin = new Padding(4, 5, 4, 5);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(281, 31);
            txtMonto.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(197, 233);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 40);
            label2.TabIndex = 17;
            label2.Text = "Monto";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(303, 58);
            txtFecha.Margin = new Padding(4, 5, 4, 5);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(281, 31);
            txtFecha.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(24, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(282, 40);
            label1.TabIndex = 15;
            label1.Text = "Fecha de transacción";
            // 
            // FrmNuevaTransaccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 750);
            Controls.Add(btnRegresar);
            Controls.Add(btnRetiro);
            Controls.Add(btnAbono);
            Controls.Add(txtMonto);
            Controls.Add(label2);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmNuevaTransaccion";
            Text = "frmNuevaTransaccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnRetiro;
        private Button btnAbono;
        private TextBox txtMonto;
        private Label label2;
        private TextBox txtFecha;
        private Label label1;
    }
}