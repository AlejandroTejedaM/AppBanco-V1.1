using BankClassSourcesDLL.Clases;

namespace BankClassSourcesDLL.Contratos
{
    public interface IContenedorClientes
    {
        void Agregar(Cuenta cuenta);
        List<Cuenta> GetCuentas();
    }
}
