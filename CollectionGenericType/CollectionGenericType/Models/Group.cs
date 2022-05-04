using CollectionGenericType.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenericType.Models
{
    class Group
    {
        //StudentCollection Students;
        MyCollection<Student> Students = new MyCollection<Student>();
        public void Add(Student student)
        {
            Students.Add(student);
        }
    }
}
