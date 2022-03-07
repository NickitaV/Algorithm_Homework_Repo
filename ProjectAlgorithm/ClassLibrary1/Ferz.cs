using System;
using System.Collections.Generic;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlgorithm
{
    public class FerzAction
    {

        public int varCount = 0;

        void Result(int[] QuennNow)
        {


            string[,] BoardArr = new string[9, 9];
            for (int i = 0; i < BoardArr.GetLength(0); i++)
            {
                for (int j = 1; j < BoardArr.GetLength(1); j++)
                {

                    BoardArr[i, j] = "[_]";

                }
            }

            for (int i = 1; i <= 8; i++)
            {

                BoardArr[QuennNow[i], i] = "[x]";

            }



            for (int i = 0; i < BoardArr.GetLength(0); i++)
            {
                for (int j = 0; j < BoardArr.GetLength(1); j++)
                {
                    Console.Write($"{BoardArr[i, j]}");
                }
                Console.WriteLine();
            }


        }



        public bool BoolCrash(int queenX1, int queenY1, int queenX2, int queenY2)
        {
            int changeX;
            int changeY;
            if ((queenX1 == queenX2) || (queenY1 == queenY2)) { return true; }



            changeX = queenX1 - 1; changeY = queenY1 - 1;
            while ((changeX >= 1) && (changeY >= 1))
            {
                if ((changeX == queenX2) && (changeY == queenY2)) { return true; }
                changeX--; changeY--;
            }


            changeX = queenX1 + 1; changeY = queenY1 + 1;
            while ((changeX <= 8) && (changeX <= 8))
            {
                if ((changeX == queenX2) && (changeY == queenY2)) { return true; }
                changeX++; changeY++;
            }


            changeX = queenX1 + 1; changeY = queenY1 - 1;
            while ((changeX <= 8) && (changeY >= 1))
            {
                if ((changeX == queenX2) && (changeY == queenY2)) { return true; }
                changeX++; changeY--;
            }

            changeX = queenX1 - 1; changeY = queenY1 + 1;
            while ((changeX >= 1) && (changeY <= 8))
            {
                if ((changeX == queenX2) && (changeY == queenY2)) { return true; }
                changeX--; changeY++;
            }
            return false;



        }
        public bool CrashPrev(int[] Quenn, int sampleIndex)
        {


            int newX = Quenn[sampleIndex];
            int newY = sampleIndex;

            for (int i = 1; i < sampleIndex; i++)

            {
                int tempX = Quenn[i];
                int tempY = i;
                bool b = (BoolCrash(tempX, tempY, newX, newY));
                if (b == true) { return true; }
            }
            return false;
        }


        public void Action()
        {

            int[] QuennMax = new int[20];

            int sampleIndex = 1;
            QuennMax[sampleIndex] = 0;
            QuennMax[0] = 0;



            while (sampleIndex > 0)
            {

                QuennMax[sampleIndex] = QuennMax[sampleIndex] + 1;
                if (sampleIndex == 8)
                {
                    if (QuennMax[sampleIndex] > 8)
                    {
                        while ((QuennMax[sampleIndex] > 8)) sampleIndex--;
                    }
                    else
                    {
                        if (!CrashPrev(QuennMax, sampleIndex))
                        {
                            sampleIndex--;
                            Console.WriteLine("Комбинация расстановки найдена:");
                            varCount++;
                            Result(QuennMax);
                            Console.WriteLine("Вариант:" + varCount);

                        }
                    }
                }
                else
                {
                    if (QuennMax[sampleIndex] > 8)
                    {
                        while ((QuennMax[sampleIndex] > 8)) sampleIndex--;
                    }
                    else
                    {
                        if (!CrashPrev(QuennMax, sampleIndex))
                        {
                            sampleIndex++;
                            QuennMax[sampleIndex] = 0;
                        }
                    }
                }
            }


        }



    }
}

