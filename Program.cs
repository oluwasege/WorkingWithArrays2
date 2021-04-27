using System;

namespace WorkingWithArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            // string[] students = { "elijah", "bryan", "michael", "matt" };
            //Array.Sort(students);
            //foreach(var i in students)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(students.IsFixedSize);
            //Array.Reverse(students);
            //Console.WriteLine(students[2]);

            //  Console.WriteLine(Array.Find(students, (e => e.EndsWith("ah"))));
            //  Console.WriteLine(Array.IndexOf(students, "bryan"));

            //int[] numbers = {89,34,79,5,10,43 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);
            //foreach(var i in numbers)
            //{
            //    Console.WriteLine(i);
            //}

            int[] questionNumbers = { 23, 47, 89, 64,102, 90, 2, 5, 10 };
            Array.Reverse(questionNumbers);
            int sum = 0;

            //for (int i=0;i<questionNumbers.Length;i++)
            //{

            //    sum +=questionNumbers[i];


            //}
            //Console.WriteLine(sum);

            foreach (var i in questionNumbers)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
