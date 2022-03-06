using System;
using System.Globalization;
using System.IO;
using System.Reflection;
namespace ProjectAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAssemblyInfo assemblyInfo = new GetAssemblyInfo();
            assemblyInfo.GetAssemblyInf(out Assembly asm);

            assemblyInfo.GetStartMenuInf(asm);


        }


    }




}
