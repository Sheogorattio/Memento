using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();


            Console.WriteLine("Ctrl + S - Save\nCtrl + Z - Show prev. version\nESC - exit\nPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            Caretaker caretaker = new Caretaker();
            ConsoleKey key;
            do
            {
                var consoleKey = Console.ReadKey();
                key = consoleKey.Key;
                text.Append(consoleKey.KeyChar);
                if (consoleKey.Modifiers == ConsoleModifiers.Control && key == ConsoleKey.S)
                {
                    Console.WriteLine("\nCtrl + S");
                    text[text.Length-1] = '\0';
                    caretaker.Add(new Memento(text.ToString()));
                    Console.WriteLine("---------------\nSaved");
                    text.Clear();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                if(consoleKey.Modifiers == ConsoleModifiers.Control &&key == ConsoleKey.Z)
                {
                    Console.WriteLine("Ctrl + Z");
                    Console.WriteLine(caretaker[--caretaker.currentVersion]);
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    Console.Clear();
                }

            } while (key != ConsoleKey.Escape);
        }
    }
}
