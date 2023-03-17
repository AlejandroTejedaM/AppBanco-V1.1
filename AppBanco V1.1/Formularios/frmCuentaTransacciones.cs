using AppBanco_V1._1.Formularios;
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
    public partial class FrmCuentaTransacciones : Form
    {
        ContenedorTransacciones listaTransaccionUnica;
        Cuenta cuentaTransaccion;
        CuentaControl control;
        frmCuentas frm;
        public FrmCuentaTransacciones(ContenedorTransacciones contenedor, Cuenta cuenta, CuentaControl control, frmCuentas frm)
        {
            InitializeComponent();
            this.listaTransaccionUnica = contenedor;
            this.cuentaTransaccion = cuenta;
            this.control = control;
            this.frm = frm;
            Leer();
            llenarFLP();
            Actualizar();
        }
        public void llenarFLP()
        {
            flpTransacciones.Controls.Clear();
            if (listaTransaccionUnica != null)
            {
                foreach (var item in listaTransaccionUnica.GetTransacciones())
                {
                    flpTransacciones.Controls.Add(getButton(item));
                }
            }
        }

        public void Actualizar()
        {
            this.cuentaTransaccion.SaldoNeto = 0;
            foreach (var item in listaTransaccionUnica.GetTransacciones())
            {
                if (item.Tipo == "Abono")
                {
                    this.cuentaTransaccion.SaldoNeto += item.Monto;
                }
                else if (item.Tipo == "Retiro")
                {
                    this.cuentaTransaccion.SaldoNeto -= item.Monto;
                }
            }
            control.Asignar(cuentaTransaccion);
        }
        public Button getButton(Transaccion a)
        {
            Button button = new Button();
            decimal var = a.Monto;
            button.Width = 100;
            button.Height = 100;
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
            button.Click += Button_Click;

            return button;
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            Button button = sender as Button;
            Transaccion transaccion = button.Tag as Transaccion;
            frmInfoTransaccion frm =  new frmInfoTransaccion(transaccion);
            frm.ShowDialog();
        }

        public string rutaTransacciones(Cuenta cuenta)
        {
            return @"C:\TAP\EXAMEN-2\Transacciones\" + cuenta.NoCuenta + ".txt";
        }
        public void Leer()
        {
            listaTransaccionUnica.Clear();
            StreamReader lct = new StreamReader(rutaTransacciones(cuentaTransaccion));
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
                };
                listaTransaccionUnica.AddTransc(transaccionArchivo);
            }
            lectura.Close();
            Actualizar();
        }

        public void Escribir()
        {
            if (flpTransacciones.Controls.Count != 0)
            {
                Writer esc = new Writer(rutaTransacciones(cuentaTransaccion), false);
                foreach (var item in listaTransaccionUnica.GetTransacciones())
                {
                    esc.Write(item.ToString());
                }
                esc.Close();
            }
        }


        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            llenarFLP();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            FrmNuevaTransaccion frmNuevaTransaccion = new FrmNuevaTransaccion(cuentaTransaccion, this.control, this.frm);
            frmNuevaTransaccion.FormClosed += FrmNuevaTransaccion_FormClosed; ;
            frmNuevaTransaccion.ShowDialog();
        }

        private void FrmNuevaTransaccion_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Leer();
            llenarFLP();
            Actualizar();
        }

        private void FrmCuentaTransacciones_Load(object sender, EventArgs e)
        {

        }
    }
}
