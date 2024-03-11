using hometask_InterfaceAbstraction.GeometricShapes;

namespace hometask_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 2

            //int secim;
            //do
            //{
            //    Console.WriteLine("Menu");
            //    Console.WriteLine("1. Kvadrat");
            //    Console.WriteLine("2 .Duzbucaqli");
            //    Console.WriteLine("0. Cixis");
            //    if (!int.TryParse(Console.ReadLine(), out secim))
            //    {
            //        Console.WriteLine("Duzgun secim olunmadi ");
            //        continue;
            //    }

            //    switch (secim)
            //    {
            //        case 1:
            //            Console.WriteLine("Kvadratin yan uzunlugunu daxil edin");
            //            if (!double.TryParse(Console.ReadLine(), out double sl))
            //            {
            //                Console.WriteLine("Yalnis daxil etme zehmet olmasa reqem daxil edin");
            //                break;
            //            }
            //            if (sl < 0)
            //            {
            //                Console.WriteLine("Yan uzunlug menfi ola bilmez");
            //                break;
            //            }
            //            Square square = new Square(sl);
            //            Console.WriteLine("Area Sahesi: " + square.Ca());
            //            break;


            //        case 2:
            //            Console.Write("Duzbucaqli eni daxil edin");
            //            if (!double.TryParse(Console.ReadLine(), out double width))
            //            {
            //                Console.WriteLine("Zehmet olmasa reqem daxil edin.");
            //                break;
            //            }
            //            Console.Write("Duzbucalqi uzunlug daxil edin");
            //            if (!double.TryParse(Console.ReadLine(), out double length))
            //            {
            //                Console.WriteLine("Zehmet olmasa reqem daxil edin.");
            //                break;
            //            }
            //            if (width < 0 || length < 0)
            //            {
            //                Console.WriteLine("Menfi deyer daxil edile bilmez duzgun deyer daxil edin");
            //                break;
            //            }
            //            Rectangular rectangular = new Rectangular(width, length);
            //            Console.WriteLine("Rectangle sahesi: " + rectangular.Ca());
            //            break;
            //        case 3:
            //            Console.WriteLine("Proqramnan cixi olundu xosh gunler");
            //            break;
            //            default: Console.WriteLine("Duzgun deyer daxil edin");
            //                break;

            //    }


            //} while (secim !=0 );

            #endregion


            #region Task 2
            while (true)
            {
                Console.WriteLine("========================================");
                Console.Write("Id daxil edin:  ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("========================================");
                Console.Write("Fullname daxil edin:  ");
                string fullname = Console.ReadLine();
                Console.WriteLine("========================================");
                Console.Write("Email daxil edin:  ");
                string email = Console.ReadLine();
                Console.WriteLine("========================================");
                Console.Write("Password daxil edin:  ");
                string password = Console.ReadLine();

                User user = new User(id, fullname, email, password);
                user.ShowInfo();


            }



            #endregion

        }
    }
}
