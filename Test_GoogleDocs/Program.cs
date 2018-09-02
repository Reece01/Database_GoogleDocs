using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Linq;
using Newtonsoft.Json;
using HwidGetter.HWID_Getter;

namespace Test_GoogleDocs
{
    class Program
    {

        static void Main(string[] args)
        {

            var db = "1YSj42ZFy7NSQ50qm5L1NQOu9dASByw9CU4lorNBRq7k"; // ID of spread Sheet
            var range = "B4"+ ":" + "C8"; // login range

            string UserHwid = ConsoleMenu.User.Hwid(); // Hwid
            Console.WriteLine("Your HWID: {0}",UserHwid);

            string LoginFunction = ReadWrite.Read.ReadDb(db,range, UserHwid);

            if (LoginFunction == UserHwid)
            {
                ConsoleMenu.MainMenu.StartingMenu(UserHwid);
            }
            else
            {
                Console.WriteLine("Account not in Database");
                Console.ReadKey();
            }
        }
    }
}
