namespace BankClassSourcesDLL.Clases
{
    public interface IContenedorCuentas
    {
        void Agregar(Cuenta cuenta);
        List<Cuenta> GetCuentas();
    }
}
