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


            start.Choice(LessonNumber, WorkNumber, 1, 1);
            start.Choice(LessonNumber, WorkNumber, 1, 2);
            start.Choice(LessonNumber, WorkNumber, 1, 3);
            start.Choice(LessonNumber, WorkNumber, 2, 1);
            start.Choice(LessonNumber, WorkNumber, 3, 1);

        }
    }




}
