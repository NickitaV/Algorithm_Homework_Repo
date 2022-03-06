using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace ProjectAlgorithm
{
    public class GetAssemblyInfo
    {
        public void GetAssemblyInf(out Assembly asm)
        {

            string path = Directory.GetCurrentDirectory();

            asm = Assembly.LoadFile($"{path}/ClassLibrary1.dll");
            string FullName = asm.FullName;
            Type[] types = asm.GetTypes();

            foreach (Type t in types)
            {
                Console.WriteLine("Type: {0}", t.FullName);
            }
            Console.WriteLine();
        }
        public void GetStartMenuInf(Assembly asm)
        {
            Type tp = asm.GetType("ProjectAlgorithm.StartMenu");
            MethodInfo[] methods = tp.GetMethods();


            Console.WriteLine("Основные методы меню:");
            
            Console.WriteLine(methods[0]);
            Console.WriteLine(methods[1]);
            Console.WriteLine(); 
            Console.WriteLine("Список уроков:");
            Console.WriteLine();
            object obj = Activator.CreateInstance(tp);
            MethodInfo input = tp.GetMethod("Input", BindingFlags.Public | BindingFlags.Instance);
            MethodInfo choice = tp.GetMethod("Choice", BindingFlags.Public | BindingFlags.Instance);
            object[] paramArray = new object[2];
            input.Invoke(obj, paramArray);

            choice.Invoke(obj, new Object[] { paramArray[0], paramArray[1] });


        }
    }
}
