namespace BankClassSourcesDLL.Clases
{
    public interface IContenedorCuentas
    {
        void AddCuenta(Cuenta cuenta);
        List<Cuenta> GetCuentas();
    }
}
