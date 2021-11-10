using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10112021
{
    class Student
    {
        static int _count;
        public Student()
        {
            _count++;
            No = _count;
        }
        public readonly int No;
        public string FullName;
    }
}
