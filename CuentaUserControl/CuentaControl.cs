using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankClassSourcesDLL.Clases;

namespace CuentaUserControl
{
    public partial class CuentaControl : UserControl
    {
        public Cuenta CuentaInfo { get; set; }
        public ContenedorTransacciones contenedorTransacciones { get; set; }
        public event EventHandler btnMovimientosClick;
        public event EventHandler btnNueTransactClick;
        public CuentaControl()
        {
            InitializeComponent();
        }
        public void Asignar(Cuenta c)
        {
            txtNombre.Text = c.Nombre.ToString();
            txtNoCuenta.Text = c.NoCuenta.ToString();
            txtSaldo.Text = c.SaldoNeto.ToString();
            CuentaInfo = c;
        }
        public void AsignarContenedor(ContenedorTransacciones contenedor)
        {
            contenedorTransacciones = contenedor;
        }


        private void bMovimientos_Click(object sender, EventArgs e)
        {
            if (btnMovimientosClick != null)
            {
                btnMovimientosClick(this, e);
            }
        }

        private void bNuevaTrans_Click(object sender, EventArgs e)
        {
            if (btnNueTransactClick != null)
            {
                btnNueTransactClick(this, e);
            }
        }
    }
}
