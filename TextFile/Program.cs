using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to add a note? 'yes' or 'no'");
            string answer1 = Console.ReadLine();
            if (answer1 == "yes")
            {
                string tekst = Console.ReadLine();
                LisaFail();
            }
            else
                Console.ReadKey();
        }

        //VIGANE AS FUCK, AGA KELL ON JUBA PALJU

        public static void LisaFail()
        {
            Console.WriteLine("Type the note:");
            string tekst = Console.ReadLine();
            Console.WriteLine("Type the path (including txt file name):");
            Console.WriteLine("For example:C:/Users/Cool/Desktop/Studio/NEWFILENAME.txt");
            Console.WriteLine("The slashes must be the other way!");
            string path = Console.ReadLine();
            string path2 = path;
            Console.WriteLine("*Path check*");
            Console.WriteLine(path);
            Console.WriteLine("Type the txt file name again");
            string FileName = Console.ReadLine();
            File.Create(FileName);
            File.AppendAllText(path, tekst);
            Console.WriteLine("The note says:");
            File.ReadLines(FileName);
        }
    }   
}
