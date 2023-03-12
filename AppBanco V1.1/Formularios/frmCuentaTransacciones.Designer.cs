namespace AppBanco_V1._1
{
    partial class FrmCuentaTransacciones
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
            flpTransacciones = new FlowLayoutPanel();
            btnRetiro = new Button();
            SuspendLayout();
            // 
            // flpTransacciones
            // 
            flpTransacciones.Location = new Point(17, 50);
            flpTransacciones.Margin = new Padding(4, 5, 4, 5);
            flpTransacciones.Name = "flpTransacciones";
            flpTransacciones.Size = new Size(1077, 530);
            flpTransacciones.TabIndex = 0;
            // 
            // btnRetiro
            // 
            btnRetiro.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetiro.Location = new Point(256, 611);
            btnRetiro.Margin = new Padding(4, 5, 4, 5);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(654, 88);
            btnRetiro.TabIndex = 21;
            btnRetiro.Text = "NUEVA TRANSACCIÓN";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // FrmCuentaTransacciones
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnRetiro);
            Controls.Add(flpTransacciones);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmCuentaTransacciones";
            Text = "frmCuentaTransacciones";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTransacciones;
        private Button btnRetiro;
    }
}