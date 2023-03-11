using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClassSourcesDLL
{
    public class Reader
    {
        StreamReader reader;

        public Reader(string rute)
        {
            reader = new StreamReader(rute);
        }

        public string ReadAll(string rute)
        {
            return reader.ReadToEnd();
        }

        public List<string> ReadByLine()
        {
            List<string> list = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list;
        }

        public void Close()
        {
            reader.Close();
        }
    }
}
