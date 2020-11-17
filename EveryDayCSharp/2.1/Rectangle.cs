using System;
using System.Collections.Generic;
using System.Text;

namespace EveryDayCSharp
{
    //自定义类型
    public class Rectangle
    {
        #region 数据成员
        //const表示常量不可修改
        public const double @const = 80;
        public string @using { get; set; }
        //类型是值的蓝本 int默认值为0
        public int num { get; set; }

        public double Heght { get; set; }
        
        public double Width { get; set; }
        #endregion
        //无参构造函数 无返回类型
        public Rectangle()
        {
            //@using = "@可将保留关键字成为标识符";

            //char c = '\n';//转义字符
            //bool b = true;//布尔类型

            //Console.WriteLine(@const);
            //Console.WriteLine(num);
            //Console.WriteLine(@using);
            Console.WriteLine("构建矩形");
        }
        public Rectangle(double Heght, double Width)
        {
            //@using = "@可将保留关键字成为标识符";

            //char c = '\n';//转义字符
            //bool b = true;//布尔类型

            //Console.WriteLine(@const);
            //Console.WriteLine(num);
            //Console.WriteLine(@using);
            this.Width = Width;
            this.Heght = Heght;
            Console.WriteLine("构建矩形");
        }

        #region 函数成员
        //public 修饰符 公开的 保护级别 
        public double GetArea()
        {
            return Heght * Width;
        }

        public void WirteString()
        {
            Console.WriteLine("长:" + Heght + " 宽:" + Width);
        }
        #endregion


    }
}
