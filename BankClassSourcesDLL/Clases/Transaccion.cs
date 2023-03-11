namespace BankClassSourcesDLL.Clases
{
    public class Transaccion
    {
        #region Propiedades
        public string Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Tipo { get; set; }
        #endregion

        #region ToString sobreescrito
        public override string ToString()
        {
            return $"{Fecha},{Tipo},{Monto}";
        }
        #endregion

    }
}
