using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.IO
{
    class Program
    {
        static string path;
        static void Main(string[] args)
        {
            beginning:
            path = @"D:\#RandomThings\C#\";
            string[] files = Directory.GetFiles(path, "*.txt", SearchOption.AllDirectories);
            Console.WriteLine("The excisting notes in the note folder are: ");
            foreach (string fa in files)
            {
                Console.WriteLine(fa);
            }
            Console.WriteLine(" ");
            beginning2:
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("To read a note, type 'read';");
            Console.WriteLine("To add a new note, type 'new';");
            Console.WriteLine("To delete a note, type 'delete';");
            Console.WriteLine("To exit the program, type 'exit':");
            string answer1 = Console.ReadLine();
            if (answer1 == "new")
            {
                LisaFail();
                goto beginning;
            }
            else if (answer1 == "read")
            {
                LoeFaili();
                goto beginning;
            }
            else if (answer1 == "delete")
            {
                KustutaFail();
                goto beginning;
            }
            else if (answer1 == "exit")
            {
                Console.ReadKey();
            }
            else
            {
                goto beginning2;
            }

        }

        public static void KustutaFail()
        {
            Console.WriteLine("Type the note name.");
            string path3 = Console.ReadLine();
            string path2 = path + path3 + ".txt";
            File.Delete(path2);
            Console.WriteLine("Note deleted.");
        }

        public static void LoeFaili()
        {
            Console.WriteLine("Type the note name.");
            string path3 = Console.ReadLine();
            string path2 = path + path3 + ".txt";
            string text = File.ReadAllText(path2);
            Console.WriteLine("The note says: ");
            Console.WriteLine(text);
            Console.WriteLine(" ");
        }

        public static void LisaFail()
        {
            Console.WriteLine("Name the new note.");
            string path3 = Console.ReadLine();
            string path2 = path + path3 + ".txt";
            Console.WriteLine("*Path check*");
            Console.WriteLine(path2);
            File.Create(path3);
            Console.WriteLine("Type the note:");
            string tekst = Console.ReadLine();
            File.AppendAllText(path2, tekst);
            Console.WriteLine("Save the note or cancel? 'save' or 'cancel'");
            string saveorcancel = Console.ReadLine();
            if (saveorcancel == "save")
            {
                Console.WriteLine("Note saved to " + path2);
            }
            else if (saveorcancel == "cancel")
            {
                File.Delete(path2);
                Console.WriteLine("Note adding cancelled");
            }
        }
    }
}