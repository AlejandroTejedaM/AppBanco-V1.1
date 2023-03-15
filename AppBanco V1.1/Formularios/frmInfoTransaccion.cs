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

namespace AppBanco_V1._1.Formularios
{
    public partial class frmInfoTransaccion : Form
    {
        Transaccion transaccion;
        public frmInfoTransaccion(Transaccion transaccion)
        {
            InitializeComponent();
            this.transaccion = transaccion;
            txtFecha.Text = transaccion.Fecha;
            txtMontoTran.Text = transaccion.Monto.ToString();
            txtTipo.Text = transaccion.Tipo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
