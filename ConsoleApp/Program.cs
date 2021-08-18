using System;

namespace ConsoleApp
{
    class Television
    {
        public string model;
        public string color;
        public int diagonal;
        public bool status;
        public Television(){model = "";color = ""; diagonal = 0; status =false;}
        public Television(string m){model=m;color="";diagonal = 0; status =false;}
        public Television(string m, string c){model=m;color=c;diagonal=0;status=false;}
        public Television(string m, string c, int d){model=m;color=c;diagonal=d;status=false;}
        public Television(string m, string c, int d,bool s){model=m;color=c;diagonal=d;status=s;}
        public void GetInfo(){
            Console.WriteLine($"Модель: {model}, Цвет: {color}, Диогональ: {diagonal}, Статус: {status}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Television sams = new Television();
            Television sams2 =new Television("Samsung");
            Television sams3 =new Television("sams3","black",84,true);

            sams3.GetInfo();
            
        }
    }
}
