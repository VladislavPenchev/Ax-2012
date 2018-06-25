namespace Task1
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            //Rs001a_Csharp_HelloWorld();
            //Rs002a_Csharp_ControlOFlowWhile();

            List<string> list = new List<string>();
            List<string> arr = new List<string>{ "5", "6", "7" };

            list.Add("0");
            list.Add("1");
            list.Insert(2, "2");

            var p = list.GetEnumerator();

            while (p.MoveNext())
            {
                var cur = p.Current;

                Console.WriteLine($"{cur}");
            }
            foreach (var item in list)
            {
                Console.WriteLine($"{item}");
            }

            list.InsertRange(5, arr);
            
        }

        public static void Rs002a_Csharp_ControlOFlowWhile()
        {
            int nLoops = 1;
            while (nLoops <= 88)
            {
                Console.Out.WriteLine(nLoops.ToString());
                Console.Out.WriteLine("(Press any key to resume.)");

                Console.In.Read();
                if ((nLoops % 4) == 0) break;
                ++nLoops;
            }
            Console.Beep();
            Console.In.Read();
        }

        public static void Rs001a_Csharp_HelloWorld()
        {
            if (1 == 1)
            {
                Console.Out.WriteLine("Hello World, Explicit.Out, 1.");
                Console.WriteLine("Hello World, Implicit default to .Out, 2.");
            }
            if (1 != 1)
            {
                Console.Error.WriteLine("This message will not appear.");
            }
            else
            {
                Console.Error.WriteLine(".Error is like .Out,"
                    + "but can be for warnings, 3.");
                Console.Error.WriteLine(".Error is like .Out,"
                    + " but is for errors, 4.");
            }
        }

    }
}
