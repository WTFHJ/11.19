using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._19
{
    internal class Student
    {
        
            public string Name { get; set; }
            public DateTime? DOB { get; set; }
            public string OMId { get; set; }
            public string ClassLabel { get; set; } = "C";
            public int ClassLevel { get; set; } = 12;

            public Student()
            {

            }
            public Student(string Name, DateTime? DOB, string OMId, string ClassLabel, int ClassLevel)
            {
                this.Name = Name;
                this.OMId = OMId;
                this.ClassLabel = ClassLabel;
                this.DOB = DOB;
                this.ClassLevel = ClassLevel;

            }
            //ird felül a toString-et, hogy
            public override string ToString()
            {
                return "A " + this.Name + " nevű tanuló " + this.ClassLevel + this.ClassLabel + " osztályba jár";
            }
            //osztalytars-e - paraméter egy másik diák, visszatérési érték logikai
            public bool isClassMate(Student otherStudent)
            {
                if (otherStudent == null)
                {
                    return false;
                }
                return this.ClassLevel == otherStudent.ClassLevel && this.ClassLabel == otherStudent.ClassLabel;
            }

            public override bool Equals(object? obj)
            {
                if (obj == null)
                {
                    return false;
                }
                if (!(obj is Student))
                {
                    return false;
                }
                return this.OMId == ((Student)obj).OMId;
            }

            public override int GetHashCode()
            {
                return OMId.GetHashCode();
            }

        
    }
}
