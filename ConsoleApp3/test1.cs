//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp3
//{
//    class Animal
//    {
//        protected string name;
//        protected int height;
//        protected int weight;
//        protected int age;
//        protected int speed;

//        public Animal()
//        {
//            this.name = "";
//            this.age = 0;
//            this.speed = 0;
//            this.weight = 0;
//            this.age = 0;
//        }

//        public Animal(string name, int height, int weight, int age, int speed)
//        {
//            this.name = name;
//            this.height = height;
//            this.weight = weight;
//            this.age = age;
//            this.speed = speed;
//        }
//        public void Speak()
//        {
//            Console.WriteLine($"이름 : {this.name}");
//            Console.WriteLine($"키 : {this.height}");
//            Console.WriteLine($"몸무게 : {this.weight}");
//            Console.WriteLine($"나이 : {this.age}");
//        }

//        public void Run()
//        {
//            Console.WriteLine($"{this.name}은/는 {this.speed}km/h 속도로 달립니다.");
//        }
//    }

//    class Pig : Animal
//    {
//        public Pig(string name, int height, int weight, int age, int speed) 
//            : base (name,height,weight,age,speed)
//        {

//        }
//    }

//    class Chicken : Animal
//    {
//        private int fly_speed;

//        public Chicken(string name, int height, int weight, int age, int speed, int fly_speed)
//            : base(name, height, weight, age, speed)
//        {
//            this.fly_speed = fly_speed;
//        }

//        public void Fly()
//        {
//            Console.WriteLine($"{this.name}은/는 {this.fly_speed}km/h 속도로 날라다닙니다.");
//        }
//    }

//    internal class test1
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("돼지의 이름과 키, 몸무게, 나이, 속도를 입력하시오");
//            string name = Console.ReadLine();
//            int height = int.Parse(Console.ReadLine());
//            int weight = int.Parse(Console.ReadLine());
//            int age = int.Parse(Console.ReadLine());
//            int speed = int.Parse(Console.ReadLine());

//            Animal pig = new Pig(name, height, weight, age, speed);
//            Console.WriteLine("치킨의 이름과 키, 몸무게, 나이, 속도, 날라다니는 속도를 입력하시오");

//            name = Console.ReadLine();
//            height = int.Parse(Console.ReadLine());
//            weight = int.Parse(Console.ReadLine());
//            age = int.Parse(Console.ReadLine());
//            speed = int.Parse(Console.ReadLine());
//            int fly_speed = int.Parse(Console.ReadLine());

//            Animal chicken = new Chicken(name, height, weight, age, speed, fly_speed);

//            pig.Speak();
//            pig.Run();
//            Console.WriteLine();
//            chicken.Speak();
//            chicken.Run();
//            Chicken chi = chicken as Chicken;
//            //((Chicken)chicken).Fly();
//            chi.Fly();
//        }
//    }
//}
