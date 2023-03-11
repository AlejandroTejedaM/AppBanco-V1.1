using BankClassSourcesDLL.Clases;

namespace BankClassSourcesDLL.Contratos
{
    public interface IContenedorClientes
    {
        void AddCliente(Cliente cuenta);
        List<Cliente> GetClientes();
    }
}
