using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsWrkList
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int GetId()
        {
            return ID;
        }
       
        public string GetName()
        {
            return Name;
        }

      



    }
}
