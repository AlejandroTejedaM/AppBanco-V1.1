namespace BankClassSourcesDLL.Clases
{
    public class Reader : IDisposable
    {
        private readonly StreamReader reader;

        public Reader(StreamReader reader)
        {
            this.reader = reader;
        }

        public string ReadAll(string rute)
        {
            try
            {
                return reader.ReadToEnd();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return string.Empty;
            }
        }

        public List<string> ReadByLine()
        {
            List<string> list = new List<string>();
            try
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return list;

        }

        public void Close()
        {
            reader.Dispose();
        }

        public void Dispose()
        {
            reader.Dispose();
        }
    }
}
