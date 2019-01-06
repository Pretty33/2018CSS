using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Program
    {
        static Demo demo = new Demo();

        static void Main(string[] args)
        {
            int[] res = demo.Perfect(10000); //调用完美数的方法
            foreach(var z in res)
            {
                Console.WriteLine("这是一个完美数:"+ z );
            }

            //排序
            int[] yu = { 5, 4, 3, 2, 1 };
            int[] l = demo.InsertionSort(yu);
            for (int k= 0; k < l.Length;k++)
            {
                Console.WriteLine(l[k]);
            }


            //斐波那契数
            int ba = demo.Fabonacci(10);
            Console.WriteLine(ba);


            //index的阶乘
            int fa = demo.Factoria(5);
            Console.WriteLine(fa);

            DecryptTheQQNumber("321568897");//解密QQ号
            Console.WriteLine(DecryptionPalindrome(Console.ReadLine()));//回文
            Console.ReadKey();
        }


        #region 解密QQ号
        public static void DecryptTheQQNumber(string QQNumber)
        {
            //声明一个队列
            Queue clear = new Queue();
            //将传递过来的参数复制给队列clear
            foreach (var item in QQNumber)
            {
                clear.Enqueue(item);
            }
            //进行循环
            for (int i = 0; i < QQNumber.Length; i++)
            {
                //如果队列只剩下一位，直接输出，并跳出循环
                if (clear.Count == 1)
                {
                    Console.Write(clear.Dequeue());
                    break;
                }
                //输出队列的第一位
                Console.Write(clear.Dequeue());
                //将队列的第一位放到最后
                clear.Enqueue(clear.Dequeue());
            }
        }
        #endregion

        #region 解密回文
        public static string DecryptionPalindrome(string chars)
        {
            //声明一个栈
            Stack stack = new Stack();
            Stack mirroring = new Stack();
            //将传递过来的string型注入栈中
            foreach (var item in chars)
            {
                stack.Push(item);
            }
            //将栈的一半值赋值给另一个栈
            for (int i = 0; i < chars.Length / 2; i++)
            {
                mirroring.Push(stack.Pop());
            }
            //判断chars的原始数据长度是奇数还是偶数
            if (stack.Count != mirroring.Count)
            {
                stack.Pop();
            }
            //通过长度去判断两个栈的值是否相等
            for (int i = 0; i < stack.Count + mirroring.Count; i++)
            {
                if (mirroring.Pop().ToString() != stack.Pop().ToString())
                {
                    return "这不是回文";
                }
            }
            return "这是回文";

        }
        #endregion

    }
}
