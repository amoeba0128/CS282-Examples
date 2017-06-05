using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person()
            {
                Name = "Penny Peng",
                Birthday = "0128",
                Email = "yichun.peng@gmail.com",
                Orientation = 0.0,
                Pos = Position.Generate()
                
            };

            Console.Write("請輸入要畫的方形的邊長:");
            double width = 0.0;
            bool success= double.TryParse
                (Console.ReadLine(),out width);
            if (success)
                person.DrawSquare(width);
            else
                Console.WriteLine("輸入錯誤，請重新執行。");

            for (var count=0; count<4; count++)
            {
                person.MoveForward(100);
                person.TurnRight(90);
                person.ShowPosition();
            }
            //person.ShowPosition();
            //person.MoveForward(100);
            //person.ShowPosition();
            //person.TurnRight(90);
            //person.MoveForward(100);
            //person.ShowPosition();
        }
    }
}
