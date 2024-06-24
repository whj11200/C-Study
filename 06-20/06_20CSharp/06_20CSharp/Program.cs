using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Collections;
namespace _06_20CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 구구단 for 액순으로 출력
            //for (int i = 9; i > 0; i--) 
            //{
            //    for (int j = 9;j >0; j--)
            //    {
            //        WriteLine($"{i}×{j} = {i*j}");
            //    }
            //}
            //WriteLine();
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine();
            //    }
            //}
            //WriteLine();
            #endregion
            #region 2하고 7을 입력하여 2단에서 7단을 출력

            //string two = Console.ReadLine(); 
            //string seven = Console.ReadLine(); 

            //int two2 = int.Parse(two);
            //int sevene = int.Parse(seven);


            //for (int i = two2; i <= two2; i++)
            //{
            //    for (int j = 7; j < 9; j++)
            //    {
            //        Console.WriteLine($"{i*j}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region 무한루프,팩토리얼 구현

            //for (; ; )
            //{
            //    Console.WriteLine("무한루프");
            //}
            //int fact = 0;
            //for (int i = 0; i <= 4; i++)
            //{
            //    Console.Write($"{i}! -> ");

            //    fact = 1;
            //    for (int j = 1; j <= 1; j++)
            //    {
            //        fact = fact * j;
            //    }
            //    Console.WriteLine($"{fact,2}");
            //}
            #endregion
            // 배열에 최적화 된 반복문이다.
            //for (int i = 2; i <= 9; i++) 
            //{
            //    Console.Write($"{i,4}단");
            //}
            //WriteLine();
            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 2; j <= 9; j++)
            //    {
            //        Console.Write($"{j}*{i}= {j *i, 2}"); 
            //    }
            //    Console.WriteLine();
            //}

            //int count = 0;
            //while (true)
            //{
            //    Console.WriteLine("안녕하세요");

            //}
            //int i = 1;
            //while (i <= 5)
            //{

            //    Console.WriteLine($"카운트 : {0}",i);

            //}

            //int num = 2;
            //int i = 1;
            //while (num <=  10)
            //{
            //    while (i < 10) 
            //    {
            //        Write($"{i} ×{num} = {i*num}");
            //        i++;

            //    }
            //   num++;
            //   i = 1;
            //    Console.WriteLine();
            //}
            //while (i++ < 10)
            //{
            //    while (num++ < 10)
            //    {
            //        Write($"{num -1}*{i -1}= {(num -1) *(i -1 )}\t");
            //    }
            //}
            //for (count = 0; count < 3; count++)
            //{
            //    Console.WriteLine("안녕하세요");
            //}
            //for (int i = 0; i< 10; i++)
            // {
            //     Console.Write(i);
            // }
            //for (int i = 2; i < 9; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"{i}*{j} ={i * j}");
            //    }
            //}
            //for (int i = 2; i < 20;  i++)
            //{
            //    if (i%3== 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = 10; i > 0; i--)
            // {
            //     Console.Write(i);
            // }
            //const int N = 100;
            //int sum = 0;

            //int i = 1;
            //while (i <= N)
            //{
            //    if(i % 2 == 0)
            //    {
            //        sum += i;

            //    }
            //    i++;
            //}
            //Console.WriteLine(sum);

            //int first = 0;
            //int second = 1;

            //while (second <= 20)
            //{
            //    Console.WriteLine(second);
            //    int temp = first + second;
            //    first = second;
            //    second = temp;
            //}

            //int count = 0;
            //do
            //{
            //    Console.WriteLine("안녕하세요 ");
            //    count++;
            //}while (count < 3);
            //    int sum = 0;
            //    int i = 1;

            //    //do
            //    //{
            //    //    if (i % 3 == 0 && i % 4 == 0)
            //    //    {
            //    //        sum += i;
            //    //    }
            //    //    i++;
            //    //} while (i <= 100);

            //    //WriteLine(sum);



            //    do
            //    {
            //        if (i % 2 == 0 && i % 5 == 0)
            //        {
            //            sum += i;
            //        }

            //        i++;
            //    } while (i <= 100);

            //    WriteLine(sum);
            //}

            // C 언어 C++에서 배열 선언을 배열이를 다음에 한다.
            // Char  str[];
            // 자바나 C#에서는 char[] str;
            // 배열은 참조형 데이터이다. 즉 주소 위치 정보만 있다.
            #region 1차원 배열
            //string[] names = new string[3];
            //names[0] = "C#";
            //names[1] = "ASP.Net";
            //names[2] = "유니티 엔진";
            //for (int i = 0; i < names.Length; i++) 
            //{
            //    Console.WriteLine(names[i]);
            //}
            //string[ ] names2 = new string[3];
            //names2[0] = "lol";
            //names2[1] = "lol2";
            //names2[2] = "lol3";

            //string[] names = {"주현영","박은비","최수희" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[0], names[1], names[2]);
            //}

            //string str = "ABC123";

            //foreach (var c in str) 
            //{
            //    Console.Write($"{c}\t");
            //}
            //WriteLine();
            #endregion
            #region 배열 초기화 for문으로 
            //  int[] arr = new int[10];

            //  for (int i = 0; i < arr.Length; i++) 
            //  {   // i+1를 증가시켜 10을 곱해 arr[i]에 할당한다
            //      arr[i] = (i + 1)* 10;
            //  }
            //  //int i 를 arr값을 할당 하여 i 출력
            //foreach (int i in arr)
            //      Console.WriteLine($"{i}");
            #endregion

            int[] not = new int[100];

            // 1부터 100까지 배열에 채우기
            //for (int i = 0; i < not.Length; i++)
            //{
            //    not[i] = i + 1;
            //}

            // 3의 배수와 7의 배수를 출력
            //foreach (int num in not)
            //{
            //    if (num % 3 == 0 || num % 7 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int[] not2 = new int[100];
            //for (int i = 0; i < not2.Length; i++)
            //{
            //    not2[i] = i + 1;
            //}


            //for (int i = 0; i < not2.Length; i++)
            //{
            //    //3를 나눴을 떄 나머지가 0이면 출력 
            //    //7를 나눴을 떄 나머지가 0이면 출력
            //    // 둘중 하나라도 맞으면 출
            //    if (not2[i] % 3==0 || not2[i] % 7 == 0)
            //    {
            //        Console.WriteLine(not2[i]);

            //    }
            //}
            //for (int i = 0; i < 5; i++) 
            //{
            //    if (i == 0) 
            //    {
            //        break;
            //    } 

            //}

            //int sum = 0;
            //while (true)
            //{
            //    if (sum >= 500)
            //        break;

            //        sum += 1;

            //}
            //break 멈추는 것 continue 건너뚜니느것
            //WriteLine($"{sum}");
            //
            //for (int i = 0; i <= 5; i++)
            //{
            //    if (i %2 == 0)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            ////int sum = 0;
            ////for (int i = 1; i <= 100; i++)
            ////{
            ////    if (i % 3 == 0)
            ////    {
            ////        continue;
            ////    }
            ////    sum += i;
            ////}
            ////WriteLine("sum: {0}", sum);


            //for (int i = 2; i < 9; i++)
            //{
            //    Console.WriteLine($"{i,4}단");
            //}
            //WriteLine();
            //for (int i = 1; i < 9; i++)
            //{
            //    for (int j = 2; j < 9; j++)
            //    {

            //        if (j % 3 == 0)
            //            continue;

            //        Console.WriteLine($"{i}*{j}={i * j}");
            //    }
            //}


            //for (int i= 1; i < 10; i++)
            //{
            //    if (i % 2 != 0) continue;
            //    for (int j = 1; j < 10; j++)
            //    {
            //        if(i < j) break;
            //        Console.WriteLine($"{i} ×{j}= {i*j}");
            //    }
            //    Console.WriteLine();
            //}
            //할인 마켓 에서 바겐세일 중이다.
            //5000을 가지고 크림빵(500원) 새우깡(700원)
            //콜라 (400원)을  사려함
            // 잔돈을 남기지 않고 세가지 물건을 하나 이상 구매할때의 경우의 수를 나타내어라.
            //int money = 0;
            //const int COKE = 400;
            //const int BAKE = 500;
            //const int SANCK = 700;

            //money = int.Parse(ReadLine());
            //for (int i = 1; i < money / BAKE; i++)
            //{
            //    for (int j = 1; j<money/COKE; j++)
            //    {
            //        for(int k =1; j<money/BAKE; j++)
            //        {
            //            if (money == i * BAKE + j * SANCK * j * COKE)
            //            {
            //                Console.WriteLine($"크림빵{i},t새우깡{i},콜라{k}");
            //            }
            //        }

            //    }
            //}
            //길이 10인 배열을 선언하고 총 10개의 정수를 입력 받아서  홀수 와 짝수를 구분지어 출력하는 프로그램을 작성
            // 일단 홀수 부터 출력하고 나서 짝수를 출력하도록 하자.
            // 단 , 10개의 정수는 Main 함수 내에서 입력받도록 하자
            //int[] arr = new int [10];

            // for (int i = 0; i <10; i ++)
            // {
            //     arr [i] = int.Parse(Console.ReadLine());
            // }
            // for(int i = 0; i <10;i++)
            // {
            //     if(i %2 == 0)
            //     {
            //         Console.WriteLine($"{arr[i]}");
            //     }

            // }
            // for (int i = 0; i <10;i++)
            // {
            //     if (i % 2 != 0)
            //     {
            //         Console.WriteLine($"{arr[i]}");
            //     }
            // }


            //string[] names = {"주현영","박은비","최수희" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[0], names[1], names[2]);
            //}
            //int[] not = new int[100];

            //// 1부터 100까지 배열에 채우기
            //for (int i = 0; i < not.Length; i++)
            //{
            //    not[i] = i + 1;
            //}

            //// 3의 배수와 7의 배수를 출력
            //foreach (int num in not)
            //{
            //    if (num % 3 == 0 || num % 7 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int fact = 0;

            //for (int i = 1; i <= 4; i++)
            //{
            //    Console.WriteLine($"{i}! -> ");
            //}

            // 십진수 정수를 입력 하시오
            //int one = int.Parse(Console.ReadLine());
            // WriteLine($"정수:{one}");
            // WriteLine($"{Convert.ToString(one,2).PadLeft(8,'0')}");

            //int N;
            //string binaryString;
            ////10진수입력
            //N = int.Parse(Console.ReadLine());
            ////2진수 입력
            //binaryString = Convert.ToString(N,2);
            //// 2진수 출력
            //for (int j = binaryString.Length - 1; j >= 0; j--)
            //{
            //    Console.WriteLine(binaryString[j]+"");
            //}

            //int[] number = { 1, 2, 3,4,5 };

            //for (number= 0; number <15; i++)
            //{

            //}


            //#region 컬렉션
            //var array = new string[] {"Array","List","Dictionary"};
            //foreach (var item in array) {Console.WriteLine(item);}

            //var list = new List<string> { "Array", "List", "Dictionary" };
            //foreach (var item in list) { Console.WriteLine(item); }

            //var dictionary = new Dictionary<int, string> 
            //{ { 0, "Array" } ,{1,"List" },{2,"Dictionary" } };
            //foreach (var pair in dictionary)
            //{
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            //#endregion


        }
    }
}
