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
            flpTransacciones.Location = new Point(12, 30);
            flpTransacciones.Name = "flpTransacciones";
            flpTransacciones.Size = new Size(754, 318);
            flpTransacciones.TabIndex = 0;
            // 
            // btnRetiro
            // 
            btnRetiro.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRetiro.Location = new Point(179, 367);
            btnRetiro.Name = "btnRetiro";
            btnRetiro.Size = new Size(458, 53);
            btnRetiro.TabIndex = 21;
            btnRetiro.Text = "NUEVA TRANSACCIÓN";
            btnRetiro.UseVisualStyleBackColor = true;
            btnRetiro.Click += btnRetiro_Click;
            // 
            // FrmCuentaTransacciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRetiro);
            Controls.Add(flpTransacciones);
            Name = "FrmCuentaTransacciones";
            Text = "frmCuentaTransacciones";
            Load += FrmCuentaTransacciones_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpTransacciones;
        private Button btnRetiro;
    }
}