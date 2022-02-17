using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAlgorithm
{
    interface IStartMenu
    {
        public void Input(out int LessonNumber, out int WorkNumber);
        public void Choice(int LessonNumber, int WorkNumber);
    }
}
