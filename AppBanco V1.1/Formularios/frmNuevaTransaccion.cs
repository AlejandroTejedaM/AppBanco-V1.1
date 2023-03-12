using BankClassSourcesDLL.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanco_V1._1
{
    public partial class FrmNuevaTransaccion : Form
    {
        ContenedorTransacciones contenedorTransacciones;
        public FrmNuevaTransaccion(ContenedorTransacciones contenedor)
        {
            InitializeComponent();
            contenedorTransacciones = contenedor;
        }
    }
}
