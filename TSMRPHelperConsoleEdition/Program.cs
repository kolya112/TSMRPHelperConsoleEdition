namespace TSMRPHelperConsoleEdition
{
    internal class Program
    {
        private static int count = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("[INFO] HELPER FOR MATRESHKA RP TECHNICAL ADMINISTRATOR IS STARTED");
            MainProgram();
        }

        public static void MainProgram()
        {
            string? action = Console.ReadLine();

            if (action == "+")
            {
                count++;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("[+] OK");
                Console.WriteLine("[All Answers Count] " + count);
                Console.ForegroundColor = ConsoleColor.White;
                MainProgram();
            }

            else if (action == "-")
            {
                count--;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("[-] OK");
                Console.WriteLine("[All Answers Count] " + count);
                Console.ForegroundColor = ConsoleColor.White;
                MainProgram();
            }

            else if (action == "--")
            {
                count = 0;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("[Clear] OK");
                Console.WriteLine("[All Answers Count] " + count);
                Console.ForegroundColor = ConsoleColor.White;
                MainProgram();
            }

            else if (action == "count")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("[All Answers Count] " + count);
                Console.ForegroundColor = ConsoleColor.White;
                MainProgram();
            }

            else if (action == "clear")
            {
                Console.Clear();
                Console.WriteLine("[INFO] HELPER FOR MATRESHKA RP TECHNICAL ADMINISTRATOR IS STARTED");
                MainProgram();
            }

            else if (action == "лаунчер")
            {
                ClipBoard.SetText("Здравствуйте! Пожалуйста, удалите лаунчер с Вашего устройства и скачайте с официального сайта по ссылке: https://cdn.matrp.ru/matrp_mobile/client_matrp.apk");
                Console.WriteLine("[Лаунчер] OK");
                MainProgram();
            }

            else if (action == "группаТП")
            {
                ClipBoard.SetText("Здравствуйте, обратитесь в это сообщество: https://vk.com/matrp_help");
                Console.WriteLine("[группаТП] OK");
                MainProgram();
            }

            else
            {
                Console.WriteLine("Unkown command");
                MainProgram();
            }
        }

        public static void KeysHandler()
        {
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.NumPad1)
                {
                    count++;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("[Key+] OK");
                    Console.WriteLine("[All Answers Count] " + count);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}