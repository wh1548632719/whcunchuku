using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Caculator cac = new Caculator();
            while (true)
            {
                cac.Calcu();
                Console.WriteLine("是否继续执行循环？Y/N");
                string s = Console.ReadLine();
                if (s.ToUpper() == "Y")
                {
                    cac.Calcu();
                    continue;
                }
                break;
            }
        }
    }
    class Caculator
    {
        public int x;
        public int y;
        public int add;
        public int substrct;
        public int multiply;
        public int divide;
        public int Add
        {
            get
            {
                return add;
            }
            set
            {
                add = x+y;
            }
        }
        public int Substrct
        {
            get
            {
                return substrct;
            }
            set
            {
                substrct= x - y;
            }
        }
        public int Multiply
        {
            get
            {
                return multiply;
            }
            set
            {
                multiply = x * y;
            }
        }
        public int Divide
        {
            get
            {
                return divide;
            }
            set
            {
                divide = x / y;
            }
        }
        public void Calcu()
        {
            //Caculator cac = new Caculator();
            //Console.WriteLine("请输入x:/n");
            //Console.ReadKey();
            //Console.WriteLine("请输入y:/n");
            //Console.ReadKey();
            //cac.Add = x + y;
            //cac.Substrct = x - y;
            //cac.Multiply = x * y;
            //cac.Divide = x / y;
            //Console.WriteLine("cac.Add=" + cac.Add);
            //Console.WriteLine(" cac.Substrct=" + cac.Substrct);
            //Console.WriteLine("cac.Multiply=" + cac.Multiply);
            //Console.WriteLine("cac.Divide=" + cac.Divide);

            Console.WriteLine("请输入第一个数字：");
            float x = 0;
            float y = 0;
            string symbol = "";
            while (true)
            {
                try
                {
                    x = Convert.ToSingle(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    x = 0;
                    Console.WriteLine("输入错误，请重新输入第一个数字：");
                }
            }
            Console.WriteLine("请输入第二个数字：");
            while (true)
            {
                try
                {
                    y = Convert.ToSingle(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    y = 0;
                    Console.WriteLine("输入错误，请重新输入第二个数字：");
                }
            }
            Console.WriteLine("请输入运算符(+ - * /)：");
            while (true)
            {
                try
                {
                    symbol = Console.ReadLine();
                    if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "/")
                        break;
                    symbol = "";
                    Console.WriteLine("运算符输入错误，请重新输入运算符(+ - * /)：");
                }
                catch (Exception)
                {
                    symbol = "";
                    Console.WriteLine("运算符输入错误，请重新输入运算符(+ - * /)");
                }
            }
            bool flag = Equals(x, y);
            Console.WriteLine("x和y比较的结果为，{0}", flag);
            float z = 0;
            switch (symbol)
            {
                case "+": z = x + y; break;
                case "-":z = x - y; break;
                case "*": z = x * y; break;
                case "/": z = x / y; break;
            }
            Console.WriteLine("运算结果出炉： " + x + symbol + y + "=" + z);
        }
     }
}
