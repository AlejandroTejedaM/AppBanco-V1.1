using BankClassSourcesDLL.Clases;
using CuentaUserControl;
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
        //ContenedorTransacciones contenedorTransacciones;
        List<Transaccion> listatransa;
        Cuenta cuentaAux;
        CuentaControl control;
        frmCuentas frm;
        public FrmNuevaTransaccion(Cuenta cuenta, CuentaControl control, frmCuentas frm)
        {
            InitializeComponent();
            listatransa = new List<Transaccion>();
            cuentaAux = cuenta;
            this.control = control;
            this.frm = frm;
            Leer();
        }
        public void Actualizar()
        {
            this.cuentaAux.SaldoNeto = 0;
            foreach (var item in listatransa)
            {
                if (item.Tipo == "Abono")
                {
                    this.cuentaAux.SaldoNeto += item.Monto;
                }
                else if (item.Tipo == "Retiro")
                {
                    this.cuentaAux.SaldoNeto -= item.Monto;
                }
            }
            control.Asignar(cuentaAux);
        }
        private void btnAbono_Click(object sender, EventArgs e)
        {
            Transaccion NuevaTransaccion = new Transaccion()
            {
                Fecha = txtFecha.Text,
                Monto = decimal.Parse(txtMonto.Text),
            };
            NuevaTransaccion.Tipo = "Abono";
            listatransa.Add(NuevaTransaccion);
            Escribir();
            Actualizar();
            this.frm.Escritura();
            this.frm.Lectura();
            this.frm.ActualizarSaldo();
            this.Close();
        }
        public void Escribir()
        {
            //if (contenedorTransacciones.vacio() == false)
            //{
            Writer esc = new Writer(rutaTransacciones(cuentaAux), false);
            foreach (var item in listatransa)
            {
                //PictureBox pb = item as PictureBox;
                //Cuenta cuenta = item as Cuenta;
                esc.Write(item.ToString());
            }
            esc.Close();
            //}
            //else
            //{
            //    MessageBox.Show("SOPAS");
            //}
        }
        public string rutaTransacciones(Cuenta cuenta)
        {
            return @"C:\TAP\EXAMEN-2\Transacciones\" + cuenta.NoCuenta + ".txt";
        }
        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Transaccion NuevaTransaccion = new Transaccion()
            {
                Fecha = txtFecha.Text,
                Monto = decimal.Parse(txtMonto.Text),
            };
            NuevaTransaccion.Tipo = "Retiro";
            listatransa.Add(NuevaTransaccion);
            Escribir();
            Actualizar();
            this.frm.Escritura();
            this.frm.Lectura();
            this.frm.ActualizarSaldo();
            this.Close();
        }

        private void Leer()
        {
            StreamReader lct = new StreamReader(rutaTransacciones(cuentaAux));
            Reader lectura = new Reader(lct);
            string[] obtenido = lectura.ReadAll().Split("\n");
            for (int i = 0; i < obtenido.Length - 1; i++)
            {
                string[] columas = obtenido[i].Split(",");
                Transaccion transaccionArchivo = new Transaccion()
                {
                    Fecha = columas[0],
                    Tipo = columas[1],
                    Monto = int.Parse(columas[2]),
                    //Fecha = columas[2],
                    //TipoTransaccion = bool.Parse(columas[3]),
                    //Monto = decimal.Parse(columas[4]),
                };
                listatransa.Add(transaccionArchivo);
            }
            lectura.Close();
        }
    }
}
