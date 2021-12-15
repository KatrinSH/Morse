using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Queue_dictinary
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //    ArrayList data = new ArrayList();
            //    data.Add(2001);
            //    data.Add("Kate");
            //    data.Add(2.5);
            //    foreach(object i in data)
            //    {
            //        Console.WriteLine(i);
            //    }

            //Queue<char> name = new Queue<char>();
            //name.Enqueue('K');
            //name.Enqueue('A');
            //name.Enqueue('T');
            //name.Enqueue('E');

            //Stack<char> lastName = new Stack<char>();
            //lastName.Push(name.Dequeue());
            //lastName.Push(name.Dequeue());
            //lastName.Push(name.Dequeue());
            //lastName.Push(name.Dequeue());

            //Console.WriteLine(lastName.Pop());
            //Console.WriteLine(lastName.Pop());
            //Console.WriteLine(lastName.Pop());

            //Dictionary<string, ArrayList> people = new Dictionary<string, ArrayList>();
            //people.Add("Kate", new ArrayList { new Queue<int>(), new Queue<int>(), new Queue<int>(), new Queue<int>(), new Queue<int>()});


            //Console.WriteLine("Enter string to encrypt");
            //string str = Console.ReadLine();
            //Console.WriteLine("Encrypted: ");
            //char[] chr = str.ToCharArray();
            //foreach(char a in chr)
            //{
            //    Console.WriteLine((int)a + " ");
            //}


            //Console.WriteLine("Enter string to encrypt");
            //string inputText = Console.ReadLine();
            //byte[] buf = Encoding.UTF8.GetBytes(inputText);
            //StringBuilder sb = new StringBuilder(buf.Length * 8);
            //foreach (byte b in buf)
            //{
            //   Console.WriteLine( sb.Append(Convert.ToString(b, 2).PadLeft(8, '0')));
            //}

            Console.WriteLine("Введите размер массива:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Введите порядок случайных чисел , в соответствие указанному размеру массива:");
            for (int i = 0; i < arr.Length; i++)
                arr[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (arr[i]);
            }

            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[pos] = arr[i];
                    pos++;
                    Console.WriteLine(arr[i]);
                }
            }
            for (int i = pos; i < arr.Length; i++)
            {
                arr[pos++] = 0;
                Console.WriteLine(arr[i]);
            }
        }

       
    }
}
