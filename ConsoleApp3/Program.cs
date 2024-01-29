//using System;
//using System.Drawing;
//namespace ConsoleApp3
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            CarPicture carpicture = new CarPicture();
//            Console.WriteLine(carpicture.car_name);
//            Console.WriteLine(carpicture.color);
//            Console.WriteLine(carpicture.Width);
//            Console.WriteLine(carpicture.Height);
//            carpicture.Width = 300;
//            Console.WriteLine(carpicture.Width);

//            CarPicture carpicture2 = new CarPicture(210, 160, "Santape", Color.Aqua);
//            Console.WriteLine("4개의 생성자를 갖는 생성자의 필드 출력");
//            Console.WriteLine(carpicture2.car_name);
//            Console.WriteLine(carpicture2.color);
//            Console.WriteLine(carpicture2.Width);
//            Console.WriteLine(carpicture2.Height);
//            Console.WriteLine(carpicture2.area);

//            Console.WriteLine("메서드 호출");
//            carpicture.MakeCar();

//            Console.WriteLine("이벤트 호출");
//            carpicture2.ProcessStarted += Carpicture2_ProcessStarted;
//            carpicture2.ProcessEnded += Carpicture2_ProcessEnded;
//            carpicture2.MakeCar();
//        }

//        private static void Carpicture2_ProcessStarted(object sender, EventArgs e)
//        {
//            Console.WriteLine("Process Started");
//        }

//        private static void Carpicture2_ProcessEnded(object sender, EventArgs e)
//        {
//            Console.WriteLine("Process Ended");
//        }


//    }
//}