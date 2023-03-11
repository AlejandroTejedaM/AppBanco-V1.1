using AppBank_V1._1;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppBanco_V1._1
{
    public partial class frmCuentas : Form
    {
        ContenedorCuentas listaCuentas;
        Cliente cliente;
        public frmCuentas(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            listaCuentas = new ContenedorCuentas();
            Lectura();
            LlenarFlP();
            ActualizarSaldoTotalCliente();
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            Cuenta NuevaCuenta = new Cuenta()
            {
                Nombre = txtNombre.Text,
                Fecha = txtFecha.Text,
                NoCuenta = int.Parse(txtCuenta.Text),
                Monto = decimal.Parse(txtMonto.Text),
                TipoTransaccion = true
            };
            listaCuentas.AddCuenta(NuevaCuenta);
            flpCuentas.Controls.Add(getControlCuenta(NuevaCuenta));
            ActualizarSaldoTotalCliente();
        }
        public CuentaControl getControlCuenta(Cuenta cuenta)
        {
            ContenedorTransacciones listaTransaccionCuenta = new ContenedorTransacciones();
            CuentaControl controlCliente = new CuentaControl();
            controlCliente.Asignar(cuenta);
            controlCliente.AsignarContenedor(listaTransaccionCuenta);
            controlCliente.btnMovimientosClick += ControlCliente_btnMovimientosClick;
            controlCliente.btnNueTransactClick += ControlCliente_btnNueTransactClick;
            ComprobarArchivoCuenta(this.cliente);
            controlCliente.Tag = cuenta;
            return controlCliente;
        }
        private void ControlCliente_btnMovimientosClick(object? sender, EventArgs e)
        {
            CuentaControl control = sender as CuentaControl;
            Cuenta cuenta = control.Tag as Cuenta;
            ContenedorTransacciones contenedor = control.contenedorTransacciones;
            FrmCuentaTransacciones frmCuentaTransacciones = new FrmCuentaTransacciones(contenedor);
            frmCuentaTransacciones.FormClosed += FrmCuentaTransacciones_FormClosed;
            frmCuentaTransacciones.ShowDialog();

        }

        private void FrmCuentaTransacciones_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ActualizarSaldoTotalCliente();
        }

        private void ControlCliente_btnNueTransactClick(object? sender, EventArgs e)
        {
            CuentaControl control = sender as CuentaControl;
            Cuenta cuenta = control.Tag as Cuenta;
            ContenedorTransacciones contenedor = control.contenedorTransacciones;
            FrmNuevaTransaccion frmNuevaTransaccion = new FrmNuevaTransaccion(contenedor);
            frmNuevaTransaccion.FormClosed += FrmNuevaTransaccion_FormClosed; 
            frmNuevaTransaccion.ShowDialog();
        }

        private void FrmNuevaTransaccion_FormClosed(object? sender, FormClosedEventArgs e)
        {
            ActualizarSaldoTotalCliente();
        }

        public void ActualizarSaldoTotalCliente()
        {
            if (listaCuentas != null)
            {
                decimal Aux = 0;
                foreach (var item in listaCuentas.GetCuentas())
                {
                    if (item.TipoTransaccion == true)
                    {
                        Aux += item.Monto;
                    }else if(item.TipoTransaccion == false)
                    {
                        Aux -= item.Monto;
                    }
                }
                txtSaldoNeto.Text = Aux.ToString();
            }
        }
 

        public void LlenarFlP()
        {
            if (!listaCuentas.vacio())
            {
                foreach (var item in listaCuentas.GetCuentas())
                {
                    flpCuentas.Controls.Add(getControlCuenta(item));
                }
            }
        }
        public void Escritura()
        {
            if (flpCuentas.Controls.Count != 0)
            {
                Writer esc = new Writer(@"C:\TAP\EXAMEN-2\Cuentas\" + cliente.Id + ".txt", false);
                foreach (var item in listaCuentas.GetCuentas())
                {
                    //PictureBox pb = item as PictureBox;
                    //Cuenta cuenta = item as Cuenta;
                    esc.Write(item.ToString());
                }
                esc.Close();
            }
        }

        public string rutaCuenta()
        {
            return @"C:\TAP\EXAMEN-2\Cuentas\" + cliente.Id + ".txt";
        }
        public void Lectura()
        {
            StreamReader lct = new StreamReader(rutaCuenta());
            Reader lectura = new Reader(lct);
            string[] obtenido = lectura.ReadAll().Split("\n");
            for (int i = 0; i < obtenido.Length - 1; i++)
            {
                string[] columas = obtenido[i].Split(",");
                Cuenta cuentaArchivo = new Cuenta()
                {
                    Nombre = columas[0],
                    NoCuenta = int.Parse(columas[1]),
                    Fecha = columas[2],
                    TipoTransaccion = bool.Parse(columas[3]),
                    Monto = decimal.Parse(columas[4]),
                };
                listaCuentas.AddCuenta(cuentaArchivo);
            }
            lectura.Close();
        }

        public void ComprobarArchivoCuenta(Cliente cliente)
        {
            //comprueba si existe el archivo con el mismo nombre del Id del cliente
            //este guarda todas sus cuentas cabe recalcar
            if (File.Exists(rutaCuenta()) == false)
            {
                //En caso que no exista se hace uso del savefiledialog
                saveFileDialog1.FileName = rutaCuenta();
                Writer escritura = new Writer(saveFileDialog1.FileName, true);
                escritura.Dispose();
            }
        }

        private void frmCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Escritura();
        }

        //private void ControlCliente_BtnMostrarCuentasClick(object? sender, EventArgs e)
        //{
        //    ClienteUserControl.ClienteUserControl control = sender as ClienteUserControl.ClienteUserControl;
        //    Cliente cliente = control.Tag as Cliente;
        //    frmCuentas frmCuentas = new frmCuentas();
        //    frmCuentas.ShowDialog();
        //}

    }
}
