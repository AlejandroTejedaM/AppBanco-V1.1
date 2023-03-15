using AppBank_V1._1;
using BankClassSourcesDLL.Clases;
using ClienteUserControl;
using CuentaUserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppBanco_V1._1
{
    public partial class frmCuentas : Form
    {
        ContenedorCuentas listaCuentas;
        ClienteUserControl.ClienteUserControl clienteUserControl;
        Cliente cliente;
        int saldoTotal;
        public frmCuentas(Cliente cliente, ClienteUserControl.ClienteUserControl control)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.clienteUserControl = control;
            listaCuentas = new ContenedorCuentas();
            Lectura();
            LlenarFlP();
            ActualizarSaldo();
            txtNombre.Text = cliente.Nombre;
            //ActualizarSaldoTotalCliente();
        }

        //public void sumaSaldos(Cuenta)
        //{
        //    //int aux = 0;
        //    //foreach (var item in listaCuentas)
        //    //{
        //    //    aux += item;
        //    //}
        //}
        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            Cuenta NuevaCuenta = new Cuenta()
            {
                Nombre = txtNombre.Text,
                NoCuenta = int.Parse(txtCuenta.Text),
                //TipoTransaccion = true
            };
            listaCuentas.AddCuenta(NuevaCuenta);
            flpCuentas.Controls.Add(getControlCuenta(NuevaCuenta));
            //ActualizarSaldoTotalCliente();
        }

        public void ActualizarSaldo()
        {
            decimal contadorSaldo = 0;
            txtSaldoNeto.Text = "";
            foreach (var item in listaCuentas.GetCuentas())
            {
                StreamReader reader = new StreamReader(@"C:\TAP\EXAMEN-2\Transacciones\" + item.NoCuenta + ".txt");
                Reader lector = new Reader(reader);
                string[] lineas = lector.ReadAll().Split("\n");
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] lineasP = lineas[i].Split(",");

                    if (lineasP[1] == "Abono")
                    {
                        contadorSaldo += decimal.Parse(lineasP[2]);
                    }
                    else if (lineasP[1] == "Retiro")
                    {
                        contadorSaldo -= decimal.Parse(lineasP[2]);
                    }
                }
                lector.Close();
            }
            txtSaldoNeto.Text = contadorSaldo.ToString();
        }
        public CuentaControl getControlCuenta(Cuenta cuenta)//Alex,2222,0
        {
            ContenedorTransacciones listaTransaccionCuenta = new ContenedorTransacciones();
            CuentaControl controlCliente = new CuentaControl();

            decimal contadorSaldo = 0;
            //Historial de esa cuenta
            if (File.Exists(@"C:\TAP\EXAMEN-2\Transacciones\" + cuenta.NoCuenta + ".txt") == true)
            {
                StreamReader reader = new StreamReader(@"C:\TAP\EXAMEN-2\Transacciones\" + cuenta.NoCuenta + ".txt");
                Reader lector = new Reader(reader);
                string[] lineas = lector.ReadAll().Split("\n");
                for (int i = 0; i < lineas.Length - 1; i++)
                {
                    string[] lineasSeparada = lineas[i].Split(",");
                    //222,Retiro,343,
                    //0,1,2
                    if (lineasSeparada[1] == "Abono")
                    {
                        contadorSaldo += decimal.Parse(lineasSeparada[2]);
                    }
                    //contadorSaldo = 343;
                    else if (lineasSeparada[1] == "Retiro")
                    {
                        contadorSaldo -= decimal.Parse(lineasSeparada[2]);
                    }
                }
                lector.Close();
            }
            else
            {
                saveFileDialog1.FileName = @"C:\TAP\EXAMEN-2\Transacciones\" + cuenta.NoCuenta + ".txt";
                Writer writer = new Writer(saveFileDialog1.FileName);
                writer.Close();
            }
            cuenta.SaldoNeto = contadorSaldo;

            controlCliente.Asignar(cuenta);
            controlCliente.AsignarContenedor(listaTransaccionCuenta);
            controlCliente.btnMovimientosClick += ControlCliente_btnMovimientosClick;
            controlCliente.btnNueTransactClick += ControlCliente_btnNueTransactClick;
            ComprobarArchivoCuenta(this.cliente);
            ComprobarArchivoTransaccion(cuenta);
            controlCliente.Tag = cuenta;
            return controlCliente;
        }
        private void ControlCliente_btnMovimientosClick(object? sender, EventArgs e)
        {
            CuentaControl control = sender as CuentaControl;
            Cuenta cuenta = control.Tag as Cuenta;
            ContenedorTransacciones contenedor = control.contenedorTransacciones;
            FrmCuentaTransacciones frmCuentaTransacciones = new FrmCuentaTransacciones(contenedor, cuenta, control, this);
            frmCuentaTransacciones.Actualizar();
            frmCuentaTransacciones.FormClosed += FrmCuentaTransacciones_FormClosed;
            frmCuentaTransacciones.ShowDialog();
        }

        private void FrmCuentaTransacciones_FormClosed(object? sender, FormClosedEventArgs e)
        {
            FrmCuentaTransacciones frmCuenta = sender as FrmCuentaTransacciones;
            frmCuenta.Actualizar();
            Escritura();
            Lectura();
            ActualizarSaldo();
        }

        private void ControlCliente_btnNueTransactClick(object? sender, EventArgs e)
        {
            CuentaControl control = sender as CuentaControl;
            Cuenta cuenta = control.Tag as Cuenta;
            ContenedorTransacciones contenedor = control.contenedorTransacciones;
            FrmNuevaTransaccion frmNuevaTransaccion = new FrmNuevaTransaccion(cuenta, control, this);
            frmNuevaTransaccion.Actualizar();
            frmNuevaTransaccion.FormClosed += FrmNuevaTransaccion_FormClosed;
            frmNuevaTransaccion.ShowDialog();
        }

        private void FrmNuevaTransaccion_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Escritura();
            Lectura();
            ActualizarSaldo();
        }

        //public void ActualizarSaldoTotalCliente()
        //{
        //    if (listaCuentas != null)
        //    {
        //        decimal Aux = 0;
        //        foreach (var item in listaCuentas.GetCuentas())
        //        {
        //            if (item.TipoTransaccion == true)
        //            {
        //                Aux += item.Monto;
        //            }
        //            else if (item.TipoTransaccion == false)
        //            {
        //                Aux -= item.Monto;
        //            }
        //        }
        //        txtSaldoNeto.Text = Aux.ToString();
        //    }
        //}


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

        public string rutaTransacciones(Cuenta cuenta)
        {
            return @"C:\TAP\EXAMEN-2\Transacciones\" + cuenta.NoCuenta + ".txt";
        }
        public void Lectura()
        {
            listaCuentas.Clear();
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
                    //SaldoNeto = int.Parse(columas[2]),
                    //Fecha = columas[2],
                    //TipoTransaccion = bool.Parse(columas[3]),
                    //Monto = decimal.Parse(columas[4]),
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
        public void ComprobarArchivoTransaccion(Cuenta cuenta)
        {
            //comprueba si existe el archivo con el mismo nombre del Id del cliente
            //este guarda todas sus cuentas cabe recalcar
            if (File.Exists(rutaTransacciones(cuenta)) == false)
            {
                //En caso que no exista se hace uso del savefiledialog
                saveFileDialog2.FileName = rutaTransacciones(cuenta);
                Writer escritura = new Writer(saveFileDialog2.FileName, true);
                escritura.Dispose();
            }
        }

        private void frmCuentas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Escritura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            Escritura();
            Lectura();
            ActualizarSaldo();
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
