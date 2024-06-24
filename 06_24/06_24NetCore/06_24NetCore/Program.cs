using Major;
namespace _06_24NetCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MathMatic.total = 0;
            //// 클래스 명. 변수명이어도 static이여서 전역변수는 가능하다.

            //멤버 함수여서 new 클래명(); 필요하다
           MathMatic math = new MathMatic();
            math.sum = 0; //멤버변수
            math.avg = 0f; // 멤버 변수
            math.sum = 1 + 10;
            Console.WriteLine(MathMatic.squareFunction(20.0f));
            Console.WriteLine(math.squareFunction(20));
            //Wow wow = new Wow();
            //Console.WriteLine(wow.Max(20, 10));
            //Console.WriteLine(wow.Min(20, 10));
            ////Console.WriteLine(MathMatic.Wox(20,10));
            ////Console.WriteLine(MathMatic.Mon(20,10));
            //Sum sum = new Sum();
            //Console.WriteLine(sum.Addnum(3, 4));
            //Console.WriteLine(Sum.Abs(3));


        }
    }
}
