namespace BankClassSourcesDLL.Clases
{
    public class Transaccion
    {
        public string Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return $"{Fecha},{Tipo},{Monto}";
        }
    }
}
