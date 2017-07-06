using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;//答え
            int b1 = 0, b2 = 100;//間を示す数
            int p;//回答
            int count = 1;
            while (true){
                Console.Write(b1+ "から" + b2 + "までの数字を当ててください ＞");

                if (int.TryParse(Console.ReadLine(),out p) && b1<=p && p<=b2 ){
                    if (a > p) {
                        Console.WriteLine("答えはもっと大きいです");
                        b1 = p + 1;

                    }
                    else if (a < p) {
                        Console.WriteLine("答えはもっと小さいです");
                        b2 = p - 1;
                    }
                    else { break; }
                    count++;

                }else { Console.WriteLine("入力値が正しくありません　再入力してください"); }

            }
            Console.WriteLine("おめでとう　正解です");
            Console.WriteLine("あなたは"+ count +"回で当たりました");


        }
    }
}
