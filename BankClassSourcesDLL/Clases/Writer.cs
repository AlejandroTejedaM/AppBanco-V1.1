namespace BankClassSourcesDLL.Clases
{
    public class Writer : IDisposable
    {
        private StreamWriter wr;
        public Writer(string filePath, bool rewrite = false)
        {
            wr = new StreamWriter(filePath);
        }

        #region Metodos
        public void Write(string text)
        {
            wr.WriteLine(text);
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