using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_24NetCore
{
    internal class Mainapp2
    {
        // 매개변수에서 값이 초기화 되어있다면 디폴트 함수 또는 기본매개변수 
        static void Log(string message, byte level = 1)
        {
            Console.WriteLine($"{message},{level}");
        } 
        public static void Main(string[] args)
        {

            //Sum(10, 20);
            //Sum(first:10, second:20);// 명령한 매개변수
            //Sum(second:20, first:20);// 명령한 매개변수2
            Log("디버그"); // 두번째 매개변수 생략
            Log("에러", 4);// 전체 매개변수 사용
            Multi();
            Multi("반갑다");
            Multi("또만나요", 3);
        }

        static void Sum(int first, int second)
        {
            Console.WriteLine(first+second);
        }


        static void Multi()
        {
            Console.WriteLine("안녕하세요");
        }

        static void Multi(string message)
        {
            Console.WriteLine(message);
        }
        static void Multi(string message,int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"{message}");
            }
        }


    }
}
