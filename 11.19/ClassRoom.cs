using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._19
{
    internal class ClassRoom
    {


        HomeRoomTeacher teacher;
        string RoomNumber;
        HashSet<Student> students = new HashSet<Student>();

        public ClassRoom(HomeRoomTeacher teacher, string RoomNumber, HashSet<Student> students)
        {
            this.teacher = teacher;
            this.RoomNumber = RoomNumber;
            this.students = students;
        }

        //paraméternek megkap egy student listát, és visszatér egy listával ami ebbe az osztályba jár
        public HashSet<Student> studentClassSelector(HashSet<Student> studentsToSelectFrom)
        {
            HashSet<Student> selectedStudents = new HashSet<Student>();
            foreach (Student student in studentsToSelectFrom)
            {
                if (this.teacher.isTheirHomeRoomTEacher(student))
                {
                    selectedStudents.Add(student);
                }
            }
            return selectedStudents;
        }
        public override string ToString()
        {
            string roomproperties;
            roomproperties = "HomeRoom " + RoomNumber + ", Home Room Teacher: " + teacher;
            roomproperties += "\nAktuális diák lista: ";
            foreach (Student s in students)
            {
                roomproperties += s.Name + "\n";
            }
            return roomproperties.Trim();
        }
    }
    
}
