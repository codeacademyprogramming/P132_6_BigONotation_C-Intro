using System;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "aaa";
            Console.Write(output);
            Console.WriteLine("bbb");
            Console.WriteLine("ccc");

            var input = Console.ReadLine();

            Console.WriteLine(input);

            Console.WriteLine("Heftenin gununu daxil edin:");
            var dayOfWeek = Console.ReadLine();


            if(dayOfWeek == "1")
                Console.WriteLine("Bazar ertesi");
            else if(dayOfWeek == "2")
            {
                Console.WriteLine("Cersenbe axsami");
                Console.WriteLine("eve tez gel");
            }
            else if(dayOfWeek == "3")
            {
                Console.WriteLine("Cersenbe");
            }
            else if(dayOfWeek == "4")
            {
                Console.WriteLine("Cume axsami");
            }
            else if (dayOfWeek == "5")
            {
                Console.WriteLine("Cume");
            }
            else if(dayOfWeek=="6" || dayOfWeek=="7")
            {
                Console.WriteLine("Heftesonu");
            }
            else
            {
                Console.WriteLine("sehvdir");
            }

            switch (dayOfWeek)
            {
                case "1":
                    Console.WriteLine("Bazar ertesi");
                    break;
                case "2":
                    Console.WriteLine("Cersenbe axsami");
                    break;
                case "3":
                    Console.WriteLine("Cersenbe");
                    break;
                case "4":
                    Console.WriteLine("Cume axsami");
                    break;
                case "5":
                    Console.WriteLine("Cume");
                    break;
                case "6":
                    Console.WriteLine("Heftesonu");
                    break;
                case "7":
                    Console.WriteLine("Heftesonu");
                    break;
                default:
                    Console.WriteLine("Sehvdir!");
                    break;
            }


            var result = 10;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine(i);
            }


            var k = 0;

            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
            }
            string[] names = { "Abbas", "Aynur", "Qasim" };


            int nameIndex = -1;
            do
            {
                Console.WriteLine("Axtaris etdiyiniz adi daxil edin:");
                string name = Console.ReadLine();

                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        nameIndex = i;
                        break;
                    }
                        
                }
            } while (nameIndex==-1);

            Console.WriteLine(nameIndex);
           

           




        }
    }
}
