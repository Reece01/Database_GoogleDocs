using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test_GoogleDocs.ConsoleMenu
{
    class MainMenu
    {
        public static string StartingMenu(string user)
        {
            Console.Clear();
            Console.WriteLine("{0}",System.DateTime.Now);
            Console.WriteLine("Welcome: {0}", user);

            string[] Menu = {
                "[1]. Item 1",
                "[2]. Item 2",
                ""
            };

            foreach(var Item in Menu)
            {
                Console.WriteLine(Item.ToString());
            }

            Console.WriteLine("Select what cheat You want");
            var SelectedMenu = Console.ReadLine();

            switch (SelectedMenu)
            {
                case "1":
                    Console.WriteLine("Item 1");
                    Console.Read();
                    break;

                case "2":
                    Console.WriteLine("Item 2");
                    Console.Read();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please Select a Vaild Item");
                    Thread.Sleep(1500);
                    StartingMenu(user);
                    break;
                    
            }

            return "failed";
        }
    }
}
