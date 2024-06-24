using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06_19A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 조건문 if, switch
            //WriteLine("영문 대자문자 또는 소문자 하나를 입력하세요");
            //char c = Convert.ToChar(Console.ReadLine());
            //if(c>='A' && c <= 'Z')
            //{
            //    Console.WriteLine($"{c}는 대문자입니다.");
            //}
            //else
            //{
            //    Console.WriteLine($"{c}는 소문자입니다.");
            //}

            //WriteLine("문자를 입력하시오");
            //
            ////char input = Convert .ToChar(Console.ReadLine());
            ////if (input == 'y')
            ////{
            ////    Console.WriteLine("Yes");
            ////}
            ////else
            ////{
            ////    if(input == 'n')
            ////    {
            ////        Console.WriteLine("No");
            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("Cancel");
            ////    }
            ////}
            ///
            //WriteLine("점수:");
            //int scroce =  Convert.ToInt32(Console.ReadLine());
            //string grade = "";
            //if(scroce >= 90)
            //{
            //    grade = "금메달";
            //}
            //else
            //{
            //    if (scroce >= 80)
            //    {
            //        grade = "은메달";
            //    }
            //    else
            //    {
            //        if (scroce >= 70)
            //        {
            //            grade = "동메달";
            //        }
            //        else
            //        {
            //            grade = "?";
            //        }
            //    }

            //}

            //Console.WriteLine($"{grade}을 수상했습니다!");

            //int a = Convert.ToInt32(Console.ReadLine());
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("짝수");
            //}
            //if (a % 2 != 0) 
            //{
            //    Console.WriteLine("홀수");
            //}
            //else
            //{
            //    Console.WriteLine("짝수");
            //}
            //if (a % 3 == 0)
            //{
            //    Console.WriteLine("3의 배수");

            //}
            //else if (a % 5 == 0)
            //{
            //    Console.WriteLine("5의 배수");
            //}
            //else if (a % 7 == 0)
            //{
            //    Console.WriteLine("7의 배수");
            //}
            //else 
            //{
            //    Console.WriteLine("3,5,7의 배수가 아닌 수 ");
            //}
            //int x = Convert.ToInt32(ReadLine());
            //switch (x)
            //{
            //    case 1:Console.WriteLine("1입니다");
            //        break;
            //    case 2:Console.WriteLine("2입니다");
            //        break;
            //        case 3:Console.WriteLine("3입니다");
            //        break;
            //    default:
            //        Console.WriteLine("4입니다");
            //        break;
            //}
            //char ch;
            //WriteLine("아침은 g를 입력 점심은 h를, 저녁은  e를 입력");
            //ch = Convert.ToChar(ReadLine());
            //switch (ch)
            //{ 
            //  case 'G':
            //  case 'g':
            //        Console.WriteLine("아침입니다");
            //        break;
            //    case 'H':
            //    case 'h':
            //        Console.WriteLine("점심입니다.");
            //        break;
            //    case 'E':
            //    case 'e':
            //        Console.WriteLine("저녁입니다");
            //        break;


            //}
            //WriteLine("날씨는 어떤가요?(맑은, 흐림, 비, 눈.....");
            //string weather = Console.ReadLine();
            //switch (weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘은 맑군요");
            //        break;
            //    case "흐림":
            //        Console.WriteLine("오늘은 흐리네요");
            //        break;
            //    case "비":
            //        Console.WriteLine("우산 챙기세요");
            //        break;
            //    default:
            //    Console.WriteLine("눈 내립니다.");
            //        break;
            //}

            //for (int i = 0; i <3 ; i++)
            //{
            //    Console.WriteLine("ㅎㅇ");
            //}
            //int num = 100;
            //int toral = 0;

            //for (var i = 0; i <100 ; i++)
            //{
            //    num--;
            //    toral++;
            //}
            //WriteLine(num);
            //Console.WriteLine(toral);
            ////int num2 = int.Parse(Console.ReadLine());
            ////WriteLine("구구단");
            ////for (var i = 1; i < 10 ; i++)
            ////{
            ////    Console.WriteLine($"{num2} ×{1} ={num2 *i}");
            ////}
            ////WriteLine("\n");

            ////for (var i = 9; 1 > 0; i--)
            ////{
            ////    Console.WriteLine($"{num2} ×{i} ={num2 * i}");
            ////}

            //int sum = 0;

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i%2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"1부터 100까지 짝수의 합: {sum}");

            //for (int i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("{0}\t",i);
            //    if (i % 3 == 0) 
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            //int sum1 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum1 += i; 
            //}
            //WriteLine($"1부터 100까지의 합 : {sum1}");
            //int sum2 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum2 += i;
            //    }
            //}
            //WriteLine($"1부터 100 까지 짝수의 합 : {sum2}");

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //float a = 0.0f;
            //for(int i = 0; i < 10; i++)
            //{
            //    a += 0.01f; // 일반 컴퓨터는 부동 소수점 오차 존재 한다
            //소수점을 가지고 비교 연산을 하지 않는다.
            //}
            //WriteLine(a);
            #endregion

            ////string width = Console.ReadLine();

            ////string height = Console.ReadLine();
            ////int widthint = int.Parse(width); 
            ////int heightint = int.Parse(height);

            ////int all = widthint * heightint;
            ////WriteLine($"너비는 {all}");
            //object obj = 1;
            // object obj2 = 2;
            // object obj3 = 3;

            // obj2 = (int)obj;
            // obj3 = (int)obj2;
            // WriteLine(obj3);

            //var a = 2020;
            //var b = "double";
            //WriteLine($"{a},{b}");
            //int a = 8 >> 1;
            //int b = a >> 2;
            //WriteLine(a);
            //WriteLine(b);

            //int a = 10;
            //string b = a == 0 ? "가나다" : "ABC";
            //WriteLine(b);
        }
    }
}
