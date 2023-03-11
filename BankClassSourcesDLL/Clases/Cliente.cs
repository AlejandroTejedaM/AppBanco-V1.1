namespace BankClassSourcesDLL.Clases
{
    public class Cliente
    {
        #region Propiedades
        public string ?Nombre { get; set; }
        public int Id { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        #endregion

        #region ToString sobreescrito
        public override string ToString()
        {
            return $"{Nombre},{Id},{Edad},{Sexo}";
        }
        #endregion

    }
}
