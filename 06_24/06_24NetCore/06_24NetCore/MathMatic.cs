using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Major
{
    /// <summary>
    /// 두 수를 더하여 그 결과값을 반환시켜 주는 함수
    /// </summary>
    /// <param name="a">첫번째 매개변수</param>
    /// <param name="b">두번째 매개변수</param>
    /// <ruturen>a+b 결과</ruturen>
    public class MathMatic
    {
        public int sum = 0; //멤버변수
        public float avg = 0f;//멤버 변수
        public static int total = 0;// 멤버 변수 아니고 전역변수
        // 인스턴스 메서드
        public int squareFunction(int x)// 멤버함수: 동적 
                                        // 호출 할 수 있는 함수
        {
            int r = x * x;
            return (r);
        }
        //static  미리 할당된 메서드(함수)는  멤버 함수 가 아니다.
        public static float squareFunction(float x, float y)
        {
            //함수 오버로딩 : 이름은 같지만 매겨변수 갯수나 
            // 자료형이 달라서 같은 이름을 허용한다.
            float r = x * y;
            return r;

        }
        public static float squareFunction(float x)
        {
            //함수 오버로딩 : 이름은 같지만 매겨변수 갯수나 
            // 자료형이 달라서 같은 이름을 허용한다.
            float r = x * x;
            return r;

        }


        //public static int Wox(int x, int y)
        //{
        //    return (x > y) ? x : y;
        //}
        //public static int Mon(in int x, int y)
        //{
        //    if(x < y)
        //    {
        //        return x;
        //    }
        //    else { return y;}
        //}


    }
    public class Wow
    {
        public int Max(int x, int y)
        {
            return (x > y) ? x : y;
        }

        public int Min(in int x, in int y)
        {
            if (x < y)
            {
                return x;
            }
            else
            {
                return y;
            }

        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="num">음수가 인자값이면</param>
    /// <ruturen>절대값 반환 메서드</ruturen>

    public class Sum
    {
        public int Addnum(int x, int y)
        {
            return x + y;
        }

        public static int Abs(int num)
        {
            return (num < 0) ? num * -1 : num;
        }
    }
   
   
   
}
