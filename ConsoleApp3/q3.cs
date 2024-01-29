//using System;
//using System.Collections.Generic;

//namespace ConsoleApp3
//{
//    class Animal
//    {
//        public int Age { get; set; }
//        public string Color { get; set; }

//        public Animal() { this.Age = 0; }

//        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
//        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
//    }

//    class Dog : Animal
//    {
//        public void Bark()
//        {
//            Console.WriteLine("Dog클래스 호출");
//            Console.WriteLine("왈왈 짓습니다.");
//        }
//    }

//    class Cat : Animal
//    {
//        public void Meow()
//        {
//            Console.WriteLine("Cat클래스 호출");
//            Console.WriteLine("냥냥 웁니다.");
//        }

//    }

//    internal class q3
//    {
//        static void Main(string[] args)
//        {
//            List<Animal> Animal = new List<Animal>()
//            { new Dog(),new Cat(),new Dog(),new Cat()};
//            foreach (var item in Animal)
//            {
//                item.Eat();
//                item.Sleep();
//                if (item is Dog)
//                {
//                    ((Dog)item).Bark();
//                }
//                if (item is Cat)
//                {
//                    ((Cat)item).Meow();
//                }
//                Console.WriteLine();
//            }

//        }
//    }
//}