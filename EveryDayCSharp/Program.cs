using System;

namespace EveryDayCSharp
{
    class Program
    {
        //static 静态成员  静态类（static class）中只能包含静态成员且不可被实例化
        static void Main(string[] args)
        {
            //new进行实例化对象
            var rectangle = new Rectangle() { Heght = 20.1,Width=33.56 };
            //rectangle = new Rectangle(113, 222);
            rectangle.WirteString();
            Console.WriteLine("面积:"+rectangle.GetArea());
            Console.ReadKey();
        }

        

    }
}
