using System;

namespace Hello1
{
    class WaterHeater
    {
        protected int i_temp;

        public void setTemp(int i_temp)
        {
            if(i_temp <10 || i_temp > 42)
            {
                Console.WriteLine("10~42사이 입력");
                Console.WriteLine("물의 온도는 15도로 리셋");
                this.i_temp = 15;
                return;
            }
            this.i_temp = i_temp;
        }

        public void turnOnWater()
        {
            Console.WriteLine($"Turn on water : {i_temp}");
        }
    }
    internal class q1
    {        
        static void Main(string[] args)
        {
            WaterHeater WH = new WaterHeater();
            for(int i = 0;i<3;i++)
            {
                Console.WriteLine("물의 온도를 입력하세요");
                int n = int.Parse(Console.ReadLine());
                WH.setTemp(n);
                WH.turnOnWater();
            }
        }
    }
}