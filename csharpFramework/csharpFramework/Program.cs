using System;

namespace csharpFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            MathExt.Counter counter = new MathExt.Counter();
            Console.WriteLine(counter.GetProgressText());
        }
    }
}
