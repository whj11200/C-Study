using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

public class Class1
{
	public Class1()
    { //매개변수 외부로 부터 문자열을 전달하여 받아온다.
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("사용법 : 06_21_CSharp.exe<name>");
                return;// 함수가 빠져나간다.
            }
            WriteLine("Hello,{0}", args[0]);

        }
    }
}
	

