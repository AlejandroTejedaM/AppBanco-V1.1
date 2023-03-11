namespace BankClassSourcesDLL.Clases
{
    public interface IContenedorTransacciones
    {
        void Agregar(Transaccion cuenta);
        List<Transaccion> GetTransacciones();
    }
}
