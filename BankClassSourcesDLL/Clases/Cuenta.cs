namespace BankClassSourcesDLL.Clases
{
    public class Cuenta
    {
        public string Nombre { get; set; }
        public int NoCuenta { get; set; }
        public string Fecha { get; set; }
        public bool TipoTransaccion { get; set; }
        public decimal Monto { get; set; }

        public override string ToString()
        {
            return $"{Nombre},{NoCuenta},{Fecha},{TipoTransaccion},{Monto}";
        }
    }
}
