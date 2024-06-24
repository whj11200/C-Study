using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Text;

namespace _06_18C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 명시적 형변환시 일어나는 일
            //{
            //    long m = long.MaxValue;
            //    long l = long.MinValue;
            //    WriteLine($"long의 값+ :{m}");
            //    WriteLine($"long의 값- :{l}");

            //    // long에 할당한 변수 값을 int 할당하면 과부하되며 -1이 입력된다.
            //    int i = (int)m;
            //    WriteLine($"{i}");

            //    double dum1 = 33.75678d;
            //    int num1 = (int)dum1;
            //    WriteLine($"num1의 값: {num1}");

            //
            //int x = 255;
            //byte y = (byte)x;//byte ==255 까지 가능

            //WriteLine($"{x} -> {y}");
            //byte b = 128;
            //sbyte c = (sbyte)b;
            //WriteLine($"{c}");
            //double d = 12.34;
            //int i = 1234;

            //d = i;
            //WriteLine("암시적 형 식 변환 = " + d);

            //d = 12.34;
            //i = (int)d;
            //WriteLine("묵시적 형식 변환" +i);

            //string s = "";
            //s  = Convert.ToString(d);
            //WriteLine("형식 변환 = " + s);

            //WriteLine("실수를 입력하세요: ");
            //string input = Console.ReadLine();
            //double PI = Convert.ToDouble(input);
            //WriteLine(PI);

            //WriteLine("문자를 입력하시오:");
            //string input = Console.ReadLine(); 
            //char c = Convert.ToChar(input);
            //WriteLine(c);
            //WriteLine("문자를 입력하시오:");
            //string input = Console.ReadLine();
            //char c = Convert.ToChar(input);
            //WriteLine(c);
            //WriteLine("문자를 입력하시오:");
            //int input = Console.Read();
            //string c = Convert.ToString(input);
            //WriteLine(c);

            //char a= 'a';
            //char b= 'b';
            //char c = '하';
            //char d = '세';
            //WriteLine($"{a},{b},{c},{d}");
            //int num = 256;
            //char f = (char)num;
            //WriteLine($"{f}");
            //byte a = 240; //  10진수 리터링
            //WriteLine($"a={a}");
            //byte b = 0b01111_0000; //2 진수 리터링
            //WriteLine($"b={b}");
            //byte c = 0XF0; // 16진수 리터링
            //WriteLine($"C ={c}");
            //uint d = 0x1234_abcd; //16 진수 리터링
            //WriteLine($"d ={d}");
            //byte x = 10;
            //Console.WriteLine($"십진수 {x} = { Convert.ToString(x, 2).PadLeft(8, '0')}");
            // '0'인 이유는 아스키 코드 로 인식 시켜주기 위해
            //WriteLine($"십진수 10을 이진수로 변경 : {Convert.ToString(10,2)}");
            #endregion
            #region var 형식적변형
            //var name = "C#";
            //WriteLine(name);
            //var version = 8.0;
            //WriteLine("{0:0.0}",version);

            //var s = Console.ReadLine(); // 문자열 입력받기
            //var c = Convert.ToChar(Console.Read()); //  문자 하나 입력받기
            //WriteLine($"{s} : {s.GetType()}, {c} : {c.GetType()}");

            //WriteLine("아무키나 입력하십쇼");
            //ConsoleKeyInfo cki  = Console.ReadKey();
            //Console.WriteLine("{0}", cki.Key);
            //Console.WriteLine("{0}", cki.KeyChar);
            //Console.WriteLine("{0}", cki.Modifiers);
            //if (cki .Key  == ConsoleKey.Q)
            //{
            //    Console.WriteLine("Q 입력");
            //}
            //object obj = 123;
            //object b = 3.3121289371893711;
            //object c = true;
            //object d = "문자열";
            //WriteLine(obj + "\n"+b + "\n"+ c+ "\n" +d + "\n");

            //int a = 123;
            //object b =(object)a;// a의 값을 담음
            //int c = (int)b; // b에 담김 값을 언박싱 하여 스택을 저장 후 
            //WriteLine($"{a} \n {b} \n {c}");
            //object d = b;
            //WriteLine($"{d}");
            //object는 박싱 언박싱이 일어나기 때문에 var 보다 느리다
            //대규모 프로젝트에서는 object보다 var선언하고
            // var는 클래스 생성자에서는 쓸수없기 때문에 
            // 매서드 안에 지역변수로 사용이 많이 된다.
            //int i = default;
            //double d = default;
            //char c = default;
            //string s =default;
            //WriteLine($"[{i}],[{d}],[{c == char.MinValue}],[{s == null}]");
            ////int,double은 실수이기때문에  0을 받고 char 은 \을 받고 string  null을 기본값을 받음
            ////default (T)는 자유롭게 작성하는것이며 
            //int intDefault = default(int);
            //WriteLine(intDefault);
            //bool boolDefault = default(bool);
            //WriteLine(boolDefault);
            //string stringDefault = default(string);
            //WriteLine(stringDefault == null);
            //StringBuilder sbDefault = default(StringBuilder);
            //WriteLine(sbDefault);
            // 
            #endregion
            #region 연산자
            //var t = (100,200);
            //WriteLine(t.Item1);
            //WriteLine(t.Item2);
            //var (x, y) = (300, 400);
            //WriteLine($"{x},{y}");
            // 산수 연산자
            //int n1 = 20;
            //int n2 = 30;
            //int result = n1 * n2;
            //Console.WriteLine(result);
            //// 단항 연산자
            //int i = 0;
            //WriteLine($"{i}");
            //i++;
            //WriteLine($"{i}");
            //i--;

            //WriteLine($"{i}");
            //// 그자리에서 증가
            //WriteLine($"{++i}");
            //// 그 전에 증가
            //WriteLine($"{i--}");
            //WriteLine($"{--i}");
            // 이항 연산자
            //int num = 1000;
            //int number = num + 123;
            //WriteLine(number);

            ////int num1 = 10;
            ////int num2 = (num1--) + 12;
            ////WriteLine(num1);
            ////WriteLine(num2);
            // 감소하면 num1-- 감소됌 다만 num2는 안깍이고 바로 해서 10+12  = 20이된다.

            // 삼항 연산자
            //bool isCorrect = (1 > 2)?true : false;  
            //WriteLine($"{isCorrect}");
            //int a = 5;
            //int b = 3;
            //WriteLine(a + b);
            //WriteLine(a - b);
            //WriteLine(a * b);
            //WriteLine(a / b);
            //WriteLine("{0}%{1} ={2}",a,b,(a%b));

            //ToString 과 Covert.Tosting하는이유는 더 빠른 변환을 위해서이다.
            //int days = 28;
            //WriteLine($"2월달은"+Convert.ToString(days)+"일입니다."); 
            //int a = 20;
            //int b = 30;
            //int result = a = b;
            //result += b;
            //Console.WriteLine(result);
            //result -= b;
            //WriteLine($"{result}");
            //result  /= b;
            //WriteLine($"{result}");
            //result %= b;
            //WriteLine($"{result}");
            //WriteLine($"true && true -->{ true && true}");
            //WriteLine($"true && fasle -->{true && false}");
            //WriteLine($"fasle && true -->{false && true}");
            //WriteLine($"flase && fasle -->{false && false}");
            //WriteLine($"true || true -->{true || true}");
            //WriteLine($"true || fasle -->{true || false}");
            //WriteLine($"fasle || true -->{false || true}");
            //WriteLine($"flase || fasle -->{false || false}");
            //WriteLine($"!true --> {!true}");
            //WriteLine($"!false --> {!false}");
            // int 같은 경우 &&를 할당하여 하지만 byte 같은 경우 &만 써도 된다
            //int n1 = 10 , n2 = 20 ;

            //WriteLine($"{n1<11&&n2==20}");

            //double fnum = 23.7612345679d;
            //string result = fnum.ToString("0.00");
            //WriteLine(fnum.ToString()+
            //    "결과" + result);
            ////다 알고싶으면 ToString("0.00");

            //decimal dnum1 = 3.1415678912345678913245678m;
            //result = dnum1.ToString("0.00");
            //WriteLine($"{dnum1} 의 결과{result}");
            //float p1 = 3.14512345679f;
            //result = p1.ToString("0.000000");
            //WriteLine($"{p1}의 결과 {result}");


            //WriteLine("실수를 입력하여 다음과 같이 출력하세요");
            //decimal p3 = decimal.Parse(ReadLine());
            //decimal p4 = decimal.Parse(ReadLine());

            //p3.ToString("0.0000");
            //p4.ToString("0.00000");
            //WriteLine(p3);
            //WriteLine(p4);






            //double p1 = 3.1415;
            //string result = p1.ToString("n4");
            //WriteLine($"{p1} 결과 값 {result}");
            //result = string.Format("{0:n3}",p1);
            //WriteLine(result);


            //float fn1 = 3.1515f;
            //float fn2 = 3.1415f;
            //if (fn1 >= fn2)
            //{
            //    Console.WriteLine("fn1이 fn2보다 크거나 같다");
            //}
            //else
            //{
            //    Console.WriteLine("fn1이 fn2 보다 작다");
            //}
            //if(fn1 == 3.1515f || fn2 >= 3.1415f)
            //{
            //    Console.WriteLine("OR 실행");
            //}
            //int num1;
            //int  num2;
            //int  num3;
            //string str = Console.ReadLine();
            //WriteLine(str);

            //int a =1;
            //int b =2;
            //int c =3;

            //int result = a + b + c;

            decimal Max = 100;
            WriteLine($"{Max}");
            #endregion
        }
    }
}
