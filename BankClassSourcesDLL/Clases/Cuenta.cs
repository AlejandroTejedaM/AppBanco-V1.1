namespace BankClassSourcesDLL.Clases
{
    public class Cuenta
    {
        #region Propiedades
        public string? Nombre { get; set; }
        public int NoCuenta { get; set; }
        //public string ?Fecha { get; set; }
        //public bool TipoTransaccion { get; set; }
        public decimal SaldoNeto { get; set; }
        #endregion

        public void setSaldoNeto(decimal saldoNeto)
        {
            this.SaldoNeto = saldoNeto;
        }

        #region ToString sobreescrito
        public override string ToString()
        {
            return $"{Nombre},{NoCuenta},{SaldoNeto}";
            //$"{Fecha},";
            //$"{TipoTransaccion},{Monto}";
        }
        #endregion
    }
}
