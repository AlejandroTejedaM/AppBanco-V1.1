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

namespace AppBanco_V1._1
{
    public partial class frmCuentas : Form
    {   
        ContenedorCuentas listaCuentas;
        Cliente Cliente;
        public frmCuentas(Cliente cliente)
        {
            InitializeComponent();
            this.Cliente = cliente;
            listaCuentas = new ContenedorCuentas();
            //Lectura();
            //LlenarFlP();
        }

        private void BtnAgregarCuenta_Click(object sender, EventArgs e)
        {
            //Cuenta NuevaCuenta = new Cuenta()
            //{
            //    Nombre = txtNombre.Text,
            //    Fecha = int.Parse(txtCuenta.Text),
            //    NoCuenta = int.Parse(txtCuenta.Text),
            //    Monto = Convert.ToChar(txtSexo.Text),
            //    TipoTransaccion =
            //};
            //listaCuentas.AddCuenta(NuevaCuenta);
            //flpCuentas.Controls.Add(getControlCuenta(NuevaCuenta));
        }

        //public void LlenarFlP()
        //{
        //    if (!listaClientes.vacio())
        //    {
        //        foreach (var item in listaClientes.GetClientes())
        //        {
        //            Cliente cliente = item as Cliente;
        //            flpClientes.Controls.Add(getControlCliente(cliente));
        //        }
        //    }
        //}
        //public void Escritura()
        //{
        //    if (flpClientes.Controls.Count != 0)
        //    {
        //        Writer esc = new Writer(@"C:\TAP\EXAMEN-2\Clientes\ClientesBanco.txt", false);
        //        foreach (var item in listaClientes.GetClientes())
        //        {
        //            //PictureBox pb = item as PictureBox;
        //            //Cuenta cuenta = item as Cuenta;
        //            esc.Write(item.ToString());
        //        }
        //        esc.Close();
        //    }
        //}
        //public void Lectura()
        //{
        //    StreamReader lct = new StreamReader(@"C:\TAP\EXAMEN-2\Clientes\ClientesBanco.txt");
        //    Reader lectura = new Reader(lct);
        //    string[] obtenido = lectura.ReadAll().Split("\n");
        //    for (int i = 0; i < obtenido.Length - 1; i++)
        //    {
        //        string[] columas = obtenido[i].Split(",");
        //        Cliente clienteArchivo = new Cliente()
        //        {
        //            Nombre = columas[0],
        //            Id = int.Parse(columas[1]),
        //            Edad = int.Parse(columas[2]),
        //            Sexo = Convert.ToChar(columas[3]),
        //        };
        //        listaClientes.AddCliente(clienteArchivo);
        //    }
        //    lectura.Close();
        //}

        //public void ComprobarArchivoCuenta(Cliente cliente)
        //{
        //    //comprueba si existe el archivo con el mismo nombre del Id del cliente
        //    //este guarda todas sus cuentas cabe recalcar
        //    if (File.Exists(@"C:\TAP\EXAMEN-2\Cuentas\" + cliente.Id + ".txt") == false)
        //    {
        //        //En caso que no exista se hace uso del savefiledialog
        //        saveFileDialog1.FileName = @"C:\TAP\EXAMEN-2\Cuentas\" + cliente.Id + ".txt";
        //        Writer escritura = new Writer(saveFileDialog1.FileName, true);
        //        escritura.Dispose();
        //    }
        //}
        //public CuentaControl getControlCuenta(Cuenta cuenta)
        //{
        //    ClienteUserControl.ClienteUserControl controlCliente = new ClienteUserControl.ClienteUserControl();
        //    controlCliente.Asignar(cliente);
        //    controlCliente.BtnMostrarCuentasClick += ControlCliente_BtnMostrarCuentasClick;
        //    ComprobarArchivoCuenta(cliente);
        //    controlCliente.Tag = cliente;
        //    return controlCliente;
        //}
        //private void ControlCliente_BtnMostrarCuentasClick(object? sender, EventArgs e)
        //{
        //    ClienteUserControl.ClienteUserControl control = sender as ClienteUserControl.ClienteUserControl;
        //    Cliente cliente = control.Tag as Cliente;
        //    frmCuentas frmCuentas = new frmCuentas();
        //    frmCuentas.ShowDialog();
        //}

        //private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Escritura();
        //}
    }
}
