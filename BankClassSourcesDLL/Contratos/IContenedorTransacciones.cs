namespace BankClassSourcesDLL.Clases
{
    public interface IContenedorTransacciones
    {
        void AddTransc(Transaccion cuenta);
        List<Transaccion> GetTransacciones();
    }
}
