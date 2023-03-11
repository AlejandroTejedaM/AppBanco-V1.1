namespace BankClassSourcesDLL.Clases
{
    public class Writer : IDisposable
    {
        private StreamWriter wr;
        public Writer(string filePath)
        {
            wr = new StreamWriter(filePath);
        }

        #region Metodos
        public void Write(Stream stream)
        {
            wr.WriteLine(stream);
        }
        public void Close()
        {
            wr.Close();
        }
        public void Dispose()
        {
            wr.Dispose();
        }
        #endregion

    }
}