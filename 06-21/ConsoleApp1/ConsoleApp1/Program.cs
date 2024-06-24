//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static System.Console;

//namespace ConsoleApp1
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            #region  1차원 배열 선언 및 초기화 
//            //string arr = "C#8";
//            //WriteLine(arr[0]);
//            //WriteLine(arr[1]);
//            //WriteLine(arr[2]);
//            //// 배열 요소 [] 배열 변수의이름 기록
//            //Type[] name; 

//            //Grboge Collect
//            //컴파일 안에 있는 프로그램으로  참조하는 데이터를 판단하면서 개발자 사용안하면 알아서 삭제한다.
//            //Unmanagement == Grboge Collect
//            // 메모리 관리하면서 삭제 하는 
//            // 배열 +변수이름
//            //int[] intArray;
//            //// 배열에 3개 배열 할당
//            //intArray = new int[3];
//            //// 배열 3개에 정수 할당
//            //intArray[0] = 1;    
//            //intArray[1] = 2;
//            //intArray[2] = 3;
//            //// i가 0부터 시작해서 3이 될때 까지 계속 표현
//            //for (int i = 0; i < 3; i++) 
//            //{
//            //    // 출력
//            //    Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
//            //}
//            //// int Value 안에 intArray 배열 값들 할당
//            //foreach( int intValue in intArray )
//            //{
//            //    //출력
//            //    Console.WriteLine($"{intValue}" );
//            //}

//            //int[] intArray = new int[3] {1,2,3};
//            ////var intArray2 = new int[] {1,2,3};
//            ////int[] intArray3 = {1,2,3};
//            //for (int i = 0; i < 3; i++) 
//            //{
//            //    Console.WriteLine($"{i}번째 인덱스 : {intArray[i]}");
//            //}

//            //foreach (int i in intArray)
//            //{
//            //    Console.WriteLine($"{i}");
//            //}
//            //int index = 0;
//            //int[] array = { 1, 2, 3 };



//            //WriteLine(array[index++]);
//            //WriteLine(array[index++]);
//            //WriteLine(array[index++]);
//            //WriteLine(array[--index]);
//            //WriteLine(array[--index]);
//            //WriteLine(array[--index]);

//            //int[] kor ={100,90,80};
//            //int sum = 0;
//            //float avg = 0;



//            //sum = kor[0] + kor[1] + kor[2];
//            //// (float)명시적 형변환을 하여 3.0출력하게 한다음 sum한테 나눠 명시적으로 출력하게한다.
//            //avg = sum / (float)3.0;


//            //WriteLine($"총점:{sum},평균: {avg:0.00}");

//            //int[] student = new int[3];

//            // student[0] = Convert.ToInt32(Console.ReadLine());
//            // 

//            //float[] arr =  { 10.5f,20.1f,30.2f };
//            //decimal[] arr2 = { 10.5M, 20.1M, 30.2M };

//            //float sum = 0;
//            //decimal sum2 = 0;

//            //foreach (float f in arr )
//            //{
//            //    sum += f;
//            //}
//            //foreach (decimal d in arr2)
//            //{
//            //    sum2 += d;
//            //}
//            //WriteLine(sum);
//            //WriteLine(sum2);
//            //빈배열 선언
//            // String[] authors = {};
//            // if문으로 (author.Legth>0)으로 글씨를 쓸수있다.

//            //char[,] arr = new char[2,2];
//            ////arr[0,0] = 'a';
//            ////arr[0,1] = 'b';
//            ////arr[1,0] = 'c';
//            ////arr[1,1] = 'd';
//            ////WriteLine($"{arr[0, 0]},{arr[0,1]}");
//            //arr[0,0] = Convert.ToChar(ReadLine());
//            //arr[0, 1] = Convert.ToChar(ReadLine());
//            //arr[1, 0] = Convert.ToChar(ReadLine());
//            //arr[1, 1] = Convert.ToChar(ReadLine());


//            ////WriteLine($"{arr[1, 0]},{arr[1,1]}");
//            //for (int i = 0; i< 2; i++)
//            //{
//            //    for (int j =0; j<2; j++)
//            //    {
//            //        Console.Write($"{arr[i,j]}");
//            //        Console.WriteLine();
//            //    }
//            //}
//            ////int[,] intArray;
//            ////intArray = new int[2, 3];
//            //////intArray[0, 0] = 1;
//            //////intArray[0, 1] = 2;
//            //////intArray[0, 2] = 3;
//            //////intArray[1, 0] = 4;
//            //////intArray[1, 1] = 5;
//            //////intArray[1, 2] = 6;
//            ////intArray[0, 0] = Convert.ToInt32(ReadLine());
//            ////intArray[0, 1] = Convert.ToInt32(ReadLine());
//            ////intArray[0, 2] = Convert.ToInt32(ReadLine());
//            ////intArray[1, 0] = Convert.ToInt32(ReadLine());
//            ////intArray[1, 1] = Convert.ToInt32(ReadLine());
//            ////intArray[1, 2] = Convert.ToInt32(ReadLine());
//            ////for (int i = 0; i < 2; i++) 
//            ////{
//            ////    for(int j = 0; j < 3; j++)
//            ////    {
//            ////        Console.Write($"{intArray[i,j]}_");
//            ////    }
//            ////    Console.WriteLine("\n");
//            ////}
//            //int[,] Array = new int[,] { 
//            //    {1,2,3 }, 
//            //    { 4,5,6 }
//            //};
//            //int[,] Array1 = new int[2,3] {
//            //    {1,2,3 },
//            //    { 4,5,6 }
//            //};
//            //int[,] Array2 ={
//            //    { 1,2,3 },
//            //    { 4,5,6 }
//            //};
//            //for (int i = 0; i < 2; i++)
//            //{
//            //    for(int j = 0; j < 2; j++)
//            //    {
//            //        Console.Write($"{Array[i,j]}_");
//            //    }
//            //    Console.WriteLine("\n");
//            //}
//            //for (int i = 0; i < 2; i++)
//            //{
//            //    foreach (int j in Array1)
//            //    {
//            //        Console.Write($"{Array1[i,j]}");
//            //    }
//            //    Console.WriteLine("\n");
//            //}

//            //int[,] arr = new int[3, 3];
//            //for (int i = 0; i<3; i++)
//            //{
//            //    for(int j = 0; j<3; j++)
//            //    {
//            //        if(i == j)
//            //        {
//            //            arr[i,j] = 1;
//            //        }
//            //        else
//            //        {
//            //            arr[i, j] = 0;
//            //        }
//            //        Console.Write(arr[i,j]);
//            //    }
//            //    Console.WriteLine();
//            //}
//            //string[] names = new string[3];
//            //int[,] scores = new int[3, 2];

//            //Console.WriteLine("이름과 국어, 영어 점수를 입력하세요.");

//            //for (int i = 0; i < 3; i++)
//            //{
//            //    Console.Write("이름: ");
//            //    names[i] = Console.ReadLine();
//            //    Console.Write("국어 점수: ");
//            //    scores[i, 0] = Convert.ToInt32(Console.ReadLine());
//            //    Console.Write("영어 점수: ");
//            //    scores[i, 1] = Convert.ToInt32(Console.ReadLine());
//            //}

//            //Console.WriteLine("\n이름\t국어\t영어\t합계\t평균");

//            //for (int i = 0; i < 3; i++)
//            //{
//            //    int sum = scores[i, 0] + scores[i, 1];
//            //    double average = sum / 2.0;
//            //    Console.WriteLine($"{names[i]}\t{scores[i, 0]}\t{scores[i, 1]}\t{sum}\t{average:F2}");
//            //}

//            //int sum2;
//            //for (int i = 2; i < 9; i++)
//            //{
//            //    for (int j = 0; j < 10; j++)
//            //    {
//            //        sum2 = (i * j);
//            //        Console.WriteLine(sum2);
//            //    }
//            //}
//            //int[,] noob = new int [8,9];
//            //for (int i = 0; i < noob.GetLength(0); i++)
//            //{
//            //    for (int j = 0;j <noob.GetLength(0); j++)
//            //    {
//            //        noob[i, j] = i * j;
//            //        Console.Write($"{noob[i,j],3}");

//            //    }
//            //    Console.WriteLine();
//            //}
//            //string[,,] names = new string[2,2,2];

//            //names[0, 0, 0] = "C#";
//            //names[0, 0, 1] = "ASP.NET";
//            //names[0, 1, 0] = "Window Forms";
//            //names[0, 1, 1] = "WPF";
//            //names[1, 0, 0] = "Xamarin";
//            //names[1, 0, 1] = "Uniry";
//            //names[1, 1, 0] = "UWP";
//            //names[1, 1, 1] = "Azure";

//            //WriteLine("\n 0층");
//            //WriteLine($"{names[0, 0, 0],20},{names[0,0,1],20}");
//            //WriteLine($"{names[0, 1, 0],20},{names[0,1,1],20}");

//            //WriteLine("\n 1층");
//            //WriteLine($"{names[1, 0, 0],20},{names[1, 0, 1],20}");
//            //WriteLine($"{names[1, 1, 0],20},{names[0, 1, 1],20}");


//            //int[,,] intArray = new int[2, 3, 4];

//            //for (int i = 0; i < intArray.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < intArray.GetLength(1); j++)
//            //    {
//            //        for (int k = 0; k < intArray.GetLength(2); k++)
//            //        {
//            //            Console.Write($"intArray[{i},{j},{k}] = ");
//            //            intArray[i, j, k] = Convert.ToInt32(Console.ReadLine());
//            //        }
//            //    }
//            //}


//            //for (int i = 0; i < intArray.GetLength(0); i++)
//            //{
//            //    for (int j = 0; j < intArray.GetLength(1); j++)
//            //    {
//            //        for (int k = 0; k < intArray.GetLength(2); k++)
//            //        {
//            //            Console.Write($"{intArray[i, j, k],5}");
//            //        }
//            //        Console.WriteLine();
//            //    }
//            //    Console.WriteLine();
//            //}
//           // int[,,] arr = new int[2, 2, 2]
//           //{{{1 , 2 },{3 , 4 }  },{  { 5 , 6 },{ 7 , 8 } } };
//           // WriteLine("차수 출력:{0}",arr.Rank);
//           // WriteLine("길이 출력:{0}",arr.Length);

//           // for (int i = 0; i < arr.GetLength(0); i++) // 층
//           // {
//           //     for (int j = 0; j < arr.GetLength(1); j++) // 행
//           //     {
//           //         for(int k = 0; k < arr.GetLength(2); k++)  //열
//           //         {
//           //             Console.Write($"\t {arr[i,j,k]}");
//           //         }
//           //         Console.WriteLine();
//           //     }
//           //     Console.WriteLine();
//           // }

//            #endregion
//            #region 가변배열
//            //int[][] zagArray = new int[2][];

//            //zagArray[0] = new int[] { 1, 2 };
//            //zagArray[1] = new int[] { 3, 4, 5};


//            //for (int i = 0; i < 2; i++) 
//            //{
//            //    // n번째 행의 길이만큼 반복: 2번, 3번 반복
//            //    for(int j = 0;j < zagArray[i].Length; j++)
//            //    {
//            //        Console.Write($"{zagArray[i][j]}\t");
//            //    }
//            //    Console.WriteLine();
//            //}


//            WriteLine();
//            #endregion
//            #region var 배열
//            //var i = 5;
//            //WriteLine("i:{0},타입 : {1}",i, i.GetType());

//            //var s = "Hello";
//            //WriteLine("s : {0},타입:{1}",s , s.GetType());

//            //var numbers = new int[] { 1, 2, 3 };
//            //foreach (var number in numbers)
//            //{
//            //    Console.WriteLine("item:{0}타입:{1}",number,number.GetType());
//            //}
//            #endregion
//            #region 함수
//            //API 함수의 집함

//            #endregion
//        }
//    }
//}
