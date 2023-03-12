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
    }
}
