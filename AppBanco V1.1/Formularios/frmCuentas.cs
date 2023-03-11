using BankClassSourcesDLL.Clases;
using CuentaUserControl;
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
    public partial class frmCuentas : Form
    {
        public frmCuentas()
        {
            InitializeComponent();
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {

        }
        //public CuentaControl GetCuentaControl (Cuenta cuenta)//
        //{
        //    CuentaControl cuentaControl = new CuentaControl();
        //    cuentaControl.Asignar(cuenta);
        //    if (File.Exists(@"C:\TAP\EXAMEN\Transacciones\" + cuenta.NoCuenta + ".txt") == false)
        //    {
        //        saveFileDialog1.FileName = @"C:\TAP\EXAMEN\Transacciones\" + cuenta.NoCuenta + ".txt";
        //        Escritura escritura = new Escritura(saveFileDialog1.FileName, true);
        //        Transaccion transaccion1 = new Transaccion();
        //        transaccion1.Fecha = cuenta.Fecha;
        //        if (cuenta.TipoTransaccion == true)
        //        {
        //            transaccion1.Tipo = "Abono";
        //        }
        //        else
        //        {
        //            transaccion1.Tipo = "Retiro";
        //        }
        //        transaccion1.Monto = cuenta.Monto;
        //        escritura.Escribir(transaccion1.ToString());
        //        escritura.Cerrar();
        //    }

        //    pb.Click += Pb_Click;

        //    return pb;
        //}
    }
}
