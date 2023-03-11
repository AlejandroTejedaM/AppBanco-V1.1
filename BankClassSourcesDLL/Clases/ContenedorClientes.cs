using BankClassSourcesDLL.Contratos;

namespace BankClassSourcesDLL.Clases
{
    public class ContenedorClientes : IContenedorClientes
    {
        private readonly List<Cliente> listaClientes;

        public ContenedorClientes()
        {
            listaClientes = new List<Cliente>();
        }

        public void AddCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);
        }
        
        public List<Cliente> GetClientes()
        {
            return listaClientes;
        }

        public void Clear()
        {
            listaClientes.Clear();
        }

    }
}
