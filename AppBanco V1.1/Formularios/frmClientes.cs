using AppBanco_V1._1;
using BankClassSourcesDLL.Clases;
using ClienteUserControl;

namespace AppBank_V1._1
{
    public partial class FrmClientes : Form
    {
        ContenedorClientes listaClientes;
        public FrmClientes()
        {
            InitializeComponent();
            listaClientes = new ContenedorClientes();
            Lectura();
            LlenarFlP();
        }
        public void LlenarFlP()
        {
            if (!listaClientes.vacio())
            {
                foreach (var item in listaClientes.GetClientes())
                {
                    Cliente cliente = item as Cliente;
                    flpClientes.Controls.Add(getControlCliente(cliente));
                }
            }
        }
        public void Escritura()
        {
            if (flpClientes.Controls.Count != 0)
            {
                Writer esc = new Writer(@"C:\TAP\EXAMEN-2\Clientes\ClientesBanco.txt", false);
                foreach (var item in listaClientes.GetClientes())
                {
                    //PictureBox pb = item as PictureBox;
                    //Cuenta cuenta = item as Cuenta;
                    esc.Write(item.ToString());
                }
                esc.Close();
            }
        }
        public void Lectura()
        {
            StreamReader lct = new StreamReader(@"C:\TAP\EXAMEN-2\Clientes\ClientesBanco.txt");
            Reader lectura = new Reader(lct);
            string[] obtenido = lectura.ReadAll().Split("\n");
            for (int i = 0; i < obtenido.Length - 1; i++)
            {
                string[] columas = obtenido[i].Split(",");
                Cliente clienteArchivo = new Cliente()
                {
                    Nombre = columas[0],
                    Id = int.Parse(columas[1]),
                    Edad = int.Parse(columas[2]),
                    Sexo = Convert.ToChar(columas[3]),
                };
                listaClientes.AddCliente(clienteArchivo);
            }
            lectura.Close();
        }

        public ClienteUserControl.ClienteUserControl getControlCliente(Cliente cliente)
        {
            ClienteUserControl.ClienteUserControl controlCliente = new ClienteUserControl.ClienteUserControl();
            controlCliente.Asignar(cliente);
            controlCliente.BtnMostrarCuentasClick += ControlCliente_BtnMostrarCuentasClick;
            return controlCliente;
        }
        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            Cliente clienteNuevo = new Cliente()
            {
                Nombre = txtNombre.Text,
                Id = int.Parse(txtCuenta.Text),
                Edad = int.Parse(txtCuenta.Text),
                Sexo = Convert.ToChar(txtSexo.Text),
            };
            listaClientes.AddCliente(clienteNuevo);
            flpClientes.Controls.Add(getControlCliente(clienteNuevo));
        }

        private void ControlCliente_BtnMostrarCuentasClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException("Aparece formulario de cuentas de esa persona");
        }

        private void FrmClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Escritura();
        }
    }
}
