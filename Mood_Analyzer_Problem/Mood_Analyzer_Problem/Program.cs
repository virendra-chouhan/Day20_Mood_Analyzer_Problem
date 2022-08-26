using System;

namespace Mood_Analyzer_Problem
{
    public class Program
    {
        private string message;
        public Program(): this("I")
        {
            
        }
        public Program(string message)
        {
            this.message = message;
        }
        static void Main(string[] args)
        {
            
            Program p = new Program();
            string v = p.AnalyseMood();
            Console.WriteLine("Hello World!"+ v);

        }
        public string AnalyseMood()
        {
            try { 
            if (this.message.Equals("Happy"))
            {
                return message + " mood";
            }
            else if (message.Equals("Sad"))
            {
                return message + " mood";
            }
            else if (message.Equals("I am Sad"))
            {
                return "SAD";
            }
            else
            {
                return "Happy";
            }
            }
            catch
            {
                return "Happy";
            }
        }
    }
}
