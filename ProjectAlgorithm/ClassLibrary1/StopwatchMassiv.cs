using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAlgorithm
{
   public class StopwatchMassiv
    {

        public void Time(int PointSum, out double classTime, out double structTime)
        {


            Random randomClass = new Random();
            var Classpoint = new PointClassDouble() { X = randomClass.NextDouble(), Y = randomClass.NextDouble() };


            var arrayClass = new PointClassDouble[PointSum];
            for (int i = 0; i < arrayClass.Length; i++)
            {

                arrayClass[i] = new PointClassDouble() { X = randomClass.NextDouble(), Y = randomClass.NextDouble() };

            }

            Random randomStruct = new Random();
            PointStructDouble pointStruct = new PointStructDouble() { X = randomStruct.NextDouble(), Y = randomStruct.NextDouble() };

            PointStructDouble[] arrayStruct = new PointStructDouble[PointSum];
            for (int i = 0; i < arrayStruct.Length; i++)
            {
                arrayStruct[i] = new PointStructDouble() { X = randomStruct.NextDouble(), Y = randomStruct.NextDouble() };

            }


            var stopWatchStruct = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < PointSum / 2; i++)
            {

                pointStruct.SQRTStruct(arrayStruct[i], arrayStruct[i + 1]);

            }
            stopWatchStruct.Stop();

            structTime = stopWatchStruct.ElapsedMilliseconds;
            var stopWatchClass = System.Diagnostics.Stopwatch.StartNew();

            for (int i = 0; i < PointSum / 2; i++)
            {

                Classpoint.SQRTClass(arrayClass[i], arrayClass[i + 1]);

            }
            stopWatchClass.Stop();

            classTime = stopWatchClass.ElapsedMilliseconds;
        }

    }
}
