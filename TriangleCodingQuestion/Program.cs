using System;

namespace TriangleCodingQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageCalculator = new ImageCalculator();
            string output = imageCalculator.GetImageTriangle(args);
            Console.WriteLine(output);
        }
    }
}
