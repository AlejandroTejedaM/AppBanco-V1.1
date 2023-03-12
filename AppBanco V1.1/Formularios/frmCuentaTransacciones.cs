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
        public FrmCuentaTransacciones(ContenedorTransacciones contenedor, Cuenta cuenta)
        {
            InitializeComponent();
            this.listaTransaccionUnica = contenedor;
            this.cuentaTransaccion = cuenta;
            Leer();
            llenarFLP();
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

            return button;
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
                    //Fecha = columas[2],
                    //TipoTransaccion = bool.Parse(columas[3]),
                    //Monto = decimal.Parse(columas[4]),
                };
                listaTransaccionUnica.AddTransc(transaccionArchivo);
            }
            lectura.Close();
        }

        public void Escribir()
        {
            if (flpTransacciones.Controls.Count != 0)
            {
                Writer esc = new Writer(rutaTransacciones(cuentaTransaccion), false);
                foreach (var item in listaTransaccionUnica.GetTransacciones())
                {
                    //PictureBox pb = item as PictureBox;
                    //Cuenta cuenta = item as Cuenta;
                    esc.Write(item.ToString());
                }
                esc.Close();
            }
        }

        //private void btnRetiro_Click(object sender, EventArgs e)
        //{
        //    FrmNuevaTransaccion frm = new FrmNuevaTransaccion(listaTransaccionUnica, this.cuentaTransaccion);
        //    frm.FormClosed += Frm_FormClosed;
        //    frm.ShowDialog();
        //}

        private void Frm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            llenarFLP();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            FrmNuevaTransaccion frmNuevaTransaccion = new FrmNuevaTransaccion( cuentaTransaccion);
            frmNuevaTransaccion.FormClosed += FrmNuevaTransaccion_FormClosed; ;
            frmNuevaTransaccion.ShowDialog();
        }

        private void FrmNuevaTransaccion_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Leer();
            llenarFLP();
        }
    }
}
