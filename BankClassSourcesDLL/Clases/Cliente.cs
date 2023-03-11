namespace BankClassSourcesDLL.Clases
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public int Id { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public override string ToString()
        {
            return $"{Nombre},{Id},{Edad},{Sexo}";
        }
    }
}
