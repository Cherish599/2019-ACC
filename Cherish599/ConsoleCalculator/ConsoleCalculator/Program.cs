using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("请输入要出题的个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            PrintCalculator(n);
            Console.ReadKey();
        }
        //出一些四则运算题，并且打印出来,并且可以打印到文件subject.txt中
        public static void PrintCalculator(int n)
        {
            Random rd = new Random();
            int a, b, c, d, e, r;
            int i = 0;
            string str;
            do
            {
                a = rd.Next(0, 100);
                b = rd.Next(0, 100);
                c = rd.Next(0, 100);
                d = rd.Next(0, 100);
                e = rd.Next(1, 100);

                string t = Convert.ToString(rd.Next(7));
                switch (t)
                {
                    case "0":
                        r = a + b - c;
                        str = a + " + " + b + " - " + c + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }

                        break;
                    case "1":
                        r = a - b + c;
                        str = a + " - " + b + " + " + c + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }

                        break;
                    case "2":
                        r = a / e - c;
                        str = a + " / " + e + " - " + c + " = " + r;
                        if (a % e == 0 && r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "3":
                        r = a / e * c;
                        str = a + " / " + e + " * " + c + " = " + r;
                        if (a % e == 0 && r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "4":
                        r = a * b - c + d;
                        str = a + " * " + b + " - " + c + " + " + d + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }

                        break;
                    case "5":
                        r = a * b - c / e;
                        str = a + " * " + b + " - " + c + " / " + e + " = " + r;
                        if (c % e == 0 && r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                        break;
                    case "6":
                        r = a * b * c + d;
                        str = a + " * " + b + " * " + c + " + " + d + " = " + r;
                        if (r >= 0)
                        {
                            Console.WriteLine(str);
                            CreateFile(str);
                            i++;
                        }

                        break;
                }
            } while (i < n);
        }

        //创建一个subject.txt文件，使得我们出的题能够写入文件中保存
        public static void CreateFile(string str)
        {
            try
            {

                //创建文件流对象，如果文件不存在，则创建subject.txt 文件,并且可以对文件进行追加操作
                string path = @"F:\First Test\AchaoCalculator\Cherish599\ConsoleCalculator\ConsoleCalculator\bin\Debug\subject.txt";
                StreamWriter sw = new StreamWriter(path, true);

                sw.WriteLine(str);
                sw.Close();

            }
            catch (IOException ex)
            {
                Console.WriteLine("文件操作异常");
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                return;
            }
        }
    }
}