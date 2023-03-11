using BankClassSourcesDLL.Contratos;

namespace BankClassSourcesDLL.Clases
{
    public class ContenedorCuentas : IContenedorCuentas
    {
        private List<Cuenta> listaCuentas;

        public ContenedorCuentas()
        {
            listaCuentas = new List<Cuenta>();
        }

        public void AddCuenta(Cuenta cuenta)
        {
            listaCuentas.Add(cuenta);
        }
        
        public List<Cuenta> GetCuentas()
        {
            return listaCuentas;
        }

        public void Clear()
        {
            listaCuentas.Clear();
        }

    }
}
