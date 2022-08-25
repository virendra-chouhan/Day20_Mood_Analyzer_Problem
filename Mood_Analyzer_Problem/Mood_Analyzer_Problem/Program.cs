using System;

namespace Mood_Analyzer_Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public string AnalyseMood(string mood)
        {
            if (mood.Equals("Happy"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("Sad"))
            {
                return mood + " mood";
            }
            else if (mood.Equals("I am Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
        }
    }
}
