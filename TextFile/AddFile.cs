using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Threading.Tasks;

namespace TextFile
{
    class AddFile
    {
        public string tekst = Console.ReadLine();
        public void lisaFail()
        {
            string path = @"C:\Users\Cool\Desktop\Studio";
            File.Create(Console.ReadLine());
            File.AppendAllText(path, tekst);
        }
    }
}
