//using System;
//using System.Drawing;

//namespace ConsoleApp3
//{
//    internal class CarPicture
//    {
//        private int car_width;
//        private int car_heigth;
//        //private string car_name;
//        //private Color color
//        public string car_name;
//        public Color color;

//        public CarPicture()
//        {
//            car_width = 200;
//            car_heigth = 140;
//            car_name = "casper";
//            color = Color.AliceBlue;
//        }

//        public CarPicture(int car_width, int car_heigth, string car_name, Color color)
//        {
//            this.car_width = car_width;
//            this.car_heigth = car_heigth;
//            this.car_name = car_name;
//            this.color = color;
//        }

//        public void MakeCar()   //3가지 스탭을 통해 과정을 완성한다고 가정
//        {
//            if (ProcessStarted != null) //Event Fire한다고 함
//            {
//                ProcessStarted(this, EventArgs.Empty);  //sender는 this,Args는 Empty, ProcessStarted를 호출
//            }
//            Step1();
//            Step2();
//            Step3();
//            if (ProcessEnded != null)
//            {
//                ProcessEnded(this, EventArgs.Empty);
//            }
//        }

//        public void Step1()
//        {
//            Console.WriteLine("Step #1");
//        }
//        public void Step2()
//        {
//            Console.WriteLine("Step #2");
//        }
//        public void Step3()
//        {
//            Console.WriteLine("Step #3");
//        }


//        //외부에서 필드를 엑세스 할 수 있도록 속성을 지정함
//        public int Width
//        {
//            get { return this.car_width; }
//            set { this.car_width = value; }
//        }
//        public int Height
//        {
//            get { return this.car_heigth; }
//            set { this.car_heigth = value; }
//        }
//        public int area
//        {
//            get { return car_heigth * car_width; }
//        }

//        public event EventHandler ProcessStarted;
//        public event EventHandler ProcessEnded;

//    }


//}
