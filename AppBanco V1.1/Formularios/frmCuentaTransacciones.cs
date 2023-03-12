using BankClassSourcesDLL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco_V1._1
{
    public partial class FrmCuentaTransacciones : Form
    {
        ContenedorTransacciones contenedor;
        public FrmCuentaTransacciones(ContenedorTransacciones contenedor)
        {
            InitializeComponent();
            this.contenedor = contenedor;
        }
        public void llenarFLP()
        {
            if (contenedor != null)
            {
                foreach (var item in contenedor.GetTransacciones())
                {
                    flpTransacciones.Controls.Add(getButton(item));
                }
            }
        }
        public Button getButton(Transaccion a)
        {
            Button button = new Button();
            decimal var = a.Monto;
            button.Text = var.ToString();
            if (a.Tipo.Replace(" ", "") == "Abono")//abono
            {
                button.BackColor = Color.Green;
                button.ForeColor = Color.White;
            }
            else if (a.Tipo.Replace(" ", "") == "Retiro")//retiro
            {
                button.BackColor = Color.Red;
                button.ForeColor = Color.White;
            }
            button.Tag = a;

            return button;
        }
    }
}
