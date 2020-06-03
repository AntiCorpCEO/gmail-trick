using System;
using System.IO;
using static System.Console;

namespace GmailTrick
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            int amount;
            int emailamount;
            string spacer;
            string username;
            string gmail = ("@gmail.com");

            //main
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("                                                                                                     ");
            WriteLine("                                                                                                     ");
            WriteLine("                   ██████╗ ███████╗██╗   ██╗██╗      ██████╗ ██████╗ ███████╗██████╗ ███████╗        ");
            WriteLine("                   ██╔══██╗██╔════╝██║   ██║██║     ██╔═══██╗██╔══██╗██╔════╝██╔══██╗██╔════╝        ");
            WriteLine("                   ██║  ██║█████╗  ██║   ██║██║     ██║   ██║██████╔╝█████╗  ██████╔╝███████╗        ");
            WriteLine("                   ██║  ██║██╔══╝  ╚██╗ ██╔╝██║     ██║   ██║██╔═══╝ ██╔══╝  ██╔══██╗╚════██║        ");
            WriteLine("                   ██████╔╝███████╗ ╚████╔╝ ███████╗╚██████╔╝██║     ███████╗██║  ██║███████║        ");
            WriteLine("                   ╚═════╝ ╚══════╝  ╚═══╝  ╚══════╝ ╚═════╝ ╚═╝     ╚══════╝╚═╝  ╚═╝╚══════╝        ");
            WriteLine("                                                                                                     ");
            WriteLine("                                                                                                     ");
            WriteLine("                   ██████╗ ███╗   ███╗ █████╗ ██╗██╗          ████████╗██████╗ ██╗ ██████╗██╗  ██╗██╗");
            WriteLine("                   ██╔════╝ ████╗ ████║██╔══██╗██║██║         ╚══██╔══╝██╔══██╗██║██╔════╝██║ ██╔╝██║");
            WriteLine("                   ██║  ███╗██╔████╔██║███████║██║██║            ██║   ██████╔╝██║██║     █████╔╝ ██║");
            WriteLine("                   ██║   ██║██║╚██╔╝██║██╔══██║██║██║            ██║   ██╔══██╗██║██║     ██╔═██╗ ╚═╝");
            WriteLine("                   ╚██████╔╝██║ ╚═╝ ██║██║  ██║██║███████╗       ██║   ██║  ██║██║╚██████╗██║  ██╗██╗");
            WriteLine("                    ╚═════╝ ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝╚══════╝       ╚═╝   ╚═╝  ╚═╝╚═╝ ╚═════╝╚═╝  ╚═╝╚═╝");
            WriteLine("                                                                                                     ");
            WriteLine("                                                                                                     ");
            ForegroundColor = ConsoleColor.White;



            WriteLine("                                 Welcome to Developers Gmail Trick Program.\n\n                                       Press any Key to Begin.");
            ReadKey();
            Clear();


            WriteLine("Please enter your email name you wish to use: ");
            username = ReadLine();


            WriteLine("Please enter any 1 character spacer: ");
            spacer = ReadLine();


            WriteLine("Enter how many emails you wish to create: ");
            emailamount = Convert.ToInt32(ReadLine());

            WriteLine("Press any key for emails to be exported!");
            ReadKey();
            Clear();


            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Out;
            try
            {
                ostrm = new FileStream("./emails.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                WriteLine("Cannot open emails.txt for writing");
                WriteLine(e.Message);
                return;
            }
            SetOut(writer);

            for (amount = 0; amount <= emailamount; amount++)
            {
                WriteLine("{0}{1}{2}{3}", username, spacer, amount, gmail);
            }

            SetOut(oldOut);
            writer.Close();
            ostrm.Close();
            WriteLine("Emails Exported! Please check your the directory your exe is in.\nPress any key to close!");
            ReadKey();
        }
    }
}
