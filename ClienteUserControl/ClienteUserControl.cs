using BankClassSourcesDLL.Clases;
using ClienteUserControl.Properties;

namespace ClienteUserControl
{
    public partial class UserControl1 : UserControl
    {
        public Cliente Cliente { get; set; }
        public event EventHandler BtnMostrarCuentasClick;
        public UserControl1()
        {
            InitializeComponent();
        }

        public void Asignar(Cliente cliente)
        {
            txtNombre.Text = cliente.Nombre;
            txtNoCliente.Text = cliente.Id.ToString();
            txtEdad.Text = cliente.Edad.ToString();
            txtSexo.Text = cliente.Sexo.ToString();

            string sexo = cliente.Sexo.ToString().ToUpperInvariant();

            switch (sexo)
            {
                case "M":
                    pbImagenCliente.Image = Properties.Resources.hombre;
                    break;

                case "F":
                    pbImagenCliente.Image = Properties.Resources.mujer;
                    break;

                default:
                    pbImagenCliente.Image = Properties.Resources.usuario;
                    break;
            }
            this.Cliente = cliente;
        }
        private void BtnMostrarCuentas_Click(object sender, EventArgs e)
        {
            if (BtnMostrarCuentasClick != null)
            {
                BtnMostrarCuentasClick(this, e);
            }
        }
    }
}