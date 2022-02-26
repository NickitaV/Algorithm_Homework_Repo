using System;
using System.IO;
using System.Reflection;
namespace ProjectAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAssemblyInfo();
            static void GetAssemblyInfo()
            {

                string path = Directory.GetCurrentDirectory();

                Assembly asm = Assembly.LoadFile($"{path}/ClassLibrary1.dll");
                string FullName = asm.FullName;
                Type[] types = asm.GetTypes();
            
                foreach (Type t in types)
                {
                    Console.WriteLine("Type: {0}", t.FullName);
                }
                Console.WriteLine();

            }
            StartMenu start = new StartMenu();
            start.Input(out int LessonNumber, out int WorkNumber);


            start.Choice(LessonNumber, WorkNumber);

        }
    }




}
