using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _06_19_CShar_
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 비트 부호 양수 음수 표현
            //55는 sbyte의 값의 범위(127)를 초과하기 때문에 오버플로우가 발생한다는 것입니다.
            //이진수로 255는 8비트로 1111 1111입니다.
            //이를 sbyte로 해석하면, 부호 비트가 1이 되어 음수로 해석
            //byte a = 255;
            //sbyte b = 127;
            //WriteLine($"{a} ,{b}");
            //b = (sbyte)a;
            //WriteLine($"{a} ,{b}");

            #endregion
            //WriteLine($"!true == {!true}");
            //WriteLine($"!fasle == {!false}");
            #region 비트 OR,XOR 연산자 사용,시프트 연산자 사용,조건 연산자 사용
            //var i = 3;
            //var j = 4;
            //var r = false;

            //r = (i == 3) && (j != 3);
            //WriteLine(r);
            //r = (i != 3) || (j == 3);
            //WriteLine(r);

            //r = (i >= 5);
            //WriteLine($"{!r}");

            //WriteLine(false && true);
            //WriteLine((1 == 1) || (1 != 1));
            //WriteLine(!(1 == 1));

            //byte x = 0b1010;
            //byte y = 0b1100;

            //WriteLine($"{Convert.ToString(x,2)} -> {x}");
            //WriteLine($"{Convert.ToString(y,2)} -> {y}");

            //WriteLine($"{Convert.ToString(x | y, 2)} -> {x | y,2}");
            //WriteLine($"{Convert.ToString(x ^y,2).PadLeft(4,'0')} -> {x^y,2}");
            //byte x = 0b_0000_1010;
            //WriteLine($"{Convert.ToString(x,2).PadLeft(0,'0')}->{x,2}");


            //var x = Convert.ToInt32("1010", 2); // 1010 (2진수) 10진수로 해서 10
            //var y = Convert.ToInt32("0110", 2); //  0110 (2진수) 10진수로 해서 6
            // 연산을 수행하고 결과를 출력
            //var and = x & y; // 10 & 6 -> 1010&110 했을때 
            //WriteLine($"{and} : {Convert.ToString(and, 2)}");

            //var or = x | y; 
            //WriteLine($"{or} : {Convert.ToString(or, 2)}");

            //var xor = x ^ y;
            //WriteLine($"{xor} : {Convert.ToString(xor, 2)}");

            //var not = -x;
            //WriteLine($"{not}: {Convert.ToString(not, 2)}");

            //int num = 2; //0000 0010
            //WriteLine($"{num << 1}");//0000 0100 =4
            //WriteLine($"{num << 2}");//0000 1000 =8// 쉽게 설명해서 << *2를 곱한다

            //int num2 = 32; //000 10000
            //WriteLine($"{num2 >> 1}"); // 0000100 
            //WriteLine($"{num2 >> 2}"); // 0001000 // 쉽게 설명해서 >> %2를 나눈다

            // 무조건 비교하면서 1이 나오면 1000
            //byte num1 = 4; //100&101 = 1이 나온다 따라서 4가출력된다.
            //num1 &= 5;
            //WriteLine(num1);

            //byte num2 = 4; // 100&001이기때문에 1이라도 나오면 그대로 합해진다 따라서 101이 나오기때문에
            //num2 |= 1;
            //WriteLine(num2);// 5가 출력된다



            //조건 연산자
            //int number1 = 3;// 변수선언
            //string result = (number1 % 2 == 0) ? "짝수" : "홀수"; // 3에 2를 나눠서 0이면 짝수일까 홀수 일까를 ?로 표현
            //Console.WriteLine($"{number1}은 {result}이다.");

            //const int max_size = 20;
            //int pagesize = 0;
            //pagesize = 10;
            //pagesize = (pagesize>max_size) ? max_size : max_size;//20 >10
            //Console.WriteLine(pagesize);

            //pagesize = 50;
            //pagesize = (pagesize > max_size) ? max_size : pagesize;
            //WriteLine(pagesize);
            //조건 연산자 를 사용하여 최댓값
            //var num = -21;
            //var abs = (num<0)? num*-1 : num;
            //WriteLine($"{abs}");

            //// 데이터 옹량 크기를 구할 떄 사용한다.
            //WriteLine("sizeof(데이터형식"); 
            //WriteLine($" char 형식 : {sizeof(char)} byte");
            //WriteLine($" int 형식 : {sizeof(int)} byte");
            //WriteLine($" long 형식 : {sizeof(long)} byte");
            //WriteLine($" float 형식 : {sizeof(float)} byte");
            //WriteLine($" double 형식 : {sizeof(double)} byte");

            #endregion

            #region 제어문,조건문
            //int kor = 100;
            //int eng = 90;
            //int tot = 0;
            //double avg = 0.0;

            //tot = kor + eng;
            //avg = tot / 3.0;
            //WriteLine($"총점: {tot}");
            //WriteLine($"평균 : {avg:F1}");



            //if (avg >= 90)
            //{
            //    Console.WriteLine("올 ㅋ");
            //}
            //else if (avg >= 80)
            //{
            //    Console.WriteLine("우!");
            //}
            //else if (avg >= 70)
            //{
            //    Console.WriteLine("낙");
            //}
            //else if (avg >= 60)
            //{
            //    Console.WriteLine("gg");
            //}
            //else
            //{
            //    Console.WriteLine("ㅋ");
            //}

            //if else if 차이 는 if는 계속 검사하면서 맞으면 계속출력하지만 else if를 맞으면 출력되지만 여러번 출력되지않는다.

            //   int kot = int.Parse(ReadLine());
            //   WriteLine(kot);
            //   int math = int.Parse(ReadLine());
            //   WriteLine(math);
            //   int eng = int.Parse(ReadLine());
            //   WriteLine(eng);
            //   int all = (kot+math+eng);
            //   int avg = all/3;


            //if (avg >= 90)
            //   {
            //       Console.WriteLine("A학점");
            //   }

            //else if (avg >= 80)
            //   {
            //       Console.WriteLine("B학점");
            //   }
            //else if (avg >= 70)
            //   {
            //       Console.WriteLine("C학점");
            //   }
            //else if (avg >= 60)
            //   {
            //       Console.WriteLine("D학점");
            //   }
            //else if (avg < 60)
            //   {
            //       Console.WriteLine("F학점(재수강)");
            //   }

            //bool bin = false;
            //if (!bin)
            //{
            //    // 원래 false인데 !로 true로 만든다
            //    Console.WriteLine("bin : false -> ! -> true");
            //}

            //string name = "C#";
            //int version = 8;
            //if (name == "C#")
            //{
            //    if (version == 8)
            //    {
            //        Console.WriteLine($"{name},{version}");
            //    }
            //}
            //int number = 1234;

            ////if (number == 1234 && number >= 1234)
            ////{
            ////    Console.WriteLine("정답");
            ////}
            //if (number == 1234 || number <= 1000)
            //{
            //    Console.WriteLine("하나라도 참이면 참");
            //}
            

            //WriteLine(" 정수(양수,음수)입력 ");
            //num = int.Parse(ReadLine());
            //WriteLine (num >= 0 ? $"양수출력 :{num}" : $"음수출력:{ num}");
            //if (num >= 0)
            //{
            //    Console.WriteLine($"양수:{num}");
            //}

            //else if (num == 0)
            //{
            //    Console.WriteLine($"0:{num}");
            //}


            //else 
            //{
            //    Console.WriteLine($"음수:{num}");
            //}
            //string result = (number1 % 2 == 0) ? "짝수" : "홀수"; // 3에 2를 나눠서 0이면 짝수일까 홀수 일까를 ?로 표현
            //WriteLine("정수 입력");
            //int num;
            //num = int.Parse(Console.ReadLine());
            //string result = (num == 2)? $"양의 정수 :{num}" : $"음의 정수 :{num}";
            //if (num == 2)
            //{
            //    Console.WriteLine($"양의 정수 :{num}");
            //}
            //else
            //{
            //    Console.WriteLine($"음의 정수 :{num}");
            //}
            

            //int one = int.Parse(Console.ReadLine());
            //int two = one * -1;


            //WriteLine($"절대값 :{two}");


            #endregion
        }
    }
}
