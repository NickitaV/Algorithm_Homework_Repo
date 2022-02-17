using System;
using System.IO;
namespace ProjectAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            StartMenu start = new StartMenu();
            start.Input(out int LessonNumber, out int WorkNumber);


            start.Choice(LessonNumber, WorkNumber);
           
        }
    }




}
