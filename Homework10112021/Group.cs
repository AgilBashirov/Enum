using System;
using System.Collections.Generic;
using System.Text;

namespace Homework10112021
{
    enum Type
    {
        Programing,
        Desing,
        System,
    }


    class Group
    {
        Student[] students = new Student[0];


        private static int StaticCount = 100;

        public Group(Type type)
        {
            GroupType = type;
            StaticCount++;
            No = StaticCount.ToString();

        }

        private string _no;
        public string No
        {
            get => _no;
            private set
            {
                _no = GroupType.ToString()[0] + value;

            }
        }
        public Type GroupType { get; private set; }

        public void AddStudents(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public  Student   FindStudentByNo(int no)
        {
            foreach (var item in students)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            throw new Exception("Bele bir student yoxdur");
        }


    }
}
