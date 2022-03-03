using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlgorithm
{
    public class NumberOfOptions
    {
        public void InputSequenceSum(out int lengthSequence) {
            Console.WriteLine("Введите количество элементов последовательности:");
            lengthSequence = Convert.ToInt32(Console.ReadLine());
        }
        private void SwapNumber(List<int> list,int i,int j) {

            int temp;
            temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
        public void OptionSequence(int lengthSequence)
        {
            int OptionsCount = 0;
            List<int> list = new List<int>();
            
            for (int n = 1; n <=lengthSequence; n++)
            {

                list.Add(n);
            }
          

            SequenceOpt(list, 0,list.Count - 1);
            Console.WriteLine($"Сумма вариантов:{OptionsCount}");
            void SequenceOpt(List<int> list, int i, int lCount)
            {
                int j;
               
               
                if(i == lCount)
                {
                   foreach (var listItem in list)
                    {
                        Console.Write(listItem+" ");

                    }
                    Console.WriteLine();
                    OptionsCount++;
                    
                }


                else
                {
                    for (j = i; j <= lCount; j++)
                    {
                        SwapNumber(list, i, j);
                        SequenceOpt(list, i + 1, lCount);
                        SwapNumber(list, i, j);
                    }
                   

                }

            }
        }
    }
}
